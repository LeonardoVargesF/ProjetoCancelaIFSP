using AForge.Video;
using AForge.Video.DirectShow;
using CancelaIFSP.App.Base;
using CancelaIFSP.App.Models;
using CancelaIFSP.Domain.Base;
using CancelaIFSP.Domain.Entities;
using CancelaIFSP.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace CancelaIFSP.App.Cadastros
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public partial class CadastroUsuario : CadastroBase
    {
        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Carro> _carroService;
        private readonly IBaseService<UsuarioCarro> _usuariocarroService;

        private List<Usuario> usuarios;
        private List<UsuarioCarro> cadveiculos;

        private VideoCaptureDevice videoCapture;
        private FilterInfoCollection filterInfo;
        private Bitmap frameOriginal;

        public CadastroUsuario(IBaseService<Usuario> usuarioService, IBaseService<Carro> carroService, IBaseService<UsuarioCarro> usuariocarroService)
        {
            _usuarioService = usuarioService;
            _carroService = carroService;
            _usuariocarroService = usuariocarroService;
            InitializeComponent();
            CarregarCombo();
            startCamera();
        }

        private void CarregarCombo()
        {
            cboVeiculos.ValueMember = "Id";
            cboVeiculos.DisplayMember = "PlacaNome";
            cboVeiculos.DataSource = _carroService.Get<CarroModel>().ToList();
        }

        private void PreencheObjeto(Usuario usuario, string embedding)
        {
            usuario.Nome = txtNome.Text;
            usuario.CPF = txtCPF.Text;
            usuario.Matricula = txtMatricula.Text;
            usuario.Embedding = embedding;
            usuario.Categoria = cboCategoria.Text;
        }

        protected override async void Salvar()
        {
            try
            {
                string embedding = await SalvarFotoAsync();

                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var usuario = _usuarioService.GetById<Usuario>(id);
                        PreencheObjeto(usuario, embedding);
                        usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                    }
                }
                else
                {
                    var usuario = new Usuario();
                    PreencheObjeto(usuario, embedding);
                    _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);

                    int novoId = usuario.Id;

                    int.TryParse(cboVeiculos.SelectedValue.ToString(), out var idCarro);
                    var carro = _carroService.GetById<Carro>(idCarro);

                    try
                    {
                        var cadastro = new UsuarioCarro()
                        {
                            Carro = carro,
                            Usuario = usuario,
                        };
                        _usuariocarroService.Add<UsuarioCarro, UsuarioCarro, UsuarioCarroValidator>(cadastro);
                        MessageBox.Show(@"Cadastro Realizado!", @"IFSP", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, @"IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txtNome_Click(object sender, EventArgs e) { }

        byte[] ImageToBytes(Image image)
        {
            using var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private async Task<string> SalvarFotoAsync()
        {
            try
            {
                if (videoCapture != null && videoCapture.IsRunning)
                {
                    videoCapture.NewFrame -= Camera_On;
                    videoCapture.SignalToStop();
                    videoCapture.WaitForStop();
                    videoCapture = null;
                }

                if (frameOriginal == null)
                {
                    throw new Exception("Nenhuma imagem capturada da câmera.");
                }

                var bytes = ImageToBytes(frameOriginal);
                string resposta = await EnviarImagemAsync(bytes);
                return resposta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar foto: " + ex.Message);
                return null;
            }
        }

        private async Task<string> EnviarImagemAsync(byte[] imagemBytes)
        {
            using var client = new HttpClient();
            using var form = new MultipartFormDataContent();

            var content = new ByteArrayContent(imagemBytes);
            content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
            form.Add(content, "file", "imagem.jpg");

            var response = await client.PostAsync("http://127.0.0.1:8000/gerar_embedding", form);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        private void startCamera()
        {
            try
            {
                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                videoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString);
                videoCapture.NewFrame += new NewFrameEventHandler(Camera_On);
                videoCapture.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao iniciar câmera: " + e.Message);
            }
        }

        private void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            frameOriginal?.Dispose();
            frameOriginal = (Bitmap)frame.Clone();

            Bitmap resized = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(frame, 0, 0, pictureBox1.Width, pictureBox1.Height);
            }

            pictureBox1.Image?.Dispose();
            pictureBox1.Image = resized;

            frame.Dispose();
        }

        private async void btnCapture_Click_1(object sender, EventArgs e)
        {
            string embedding = await SalvarFotoAsync();
            MessageBox.Show("Embedding gerado com sucesso!");
        }

        private void StopCamera()
        {
            if (videoCapture != null && videoCapture.IsRunning)
            {
                videoCapture.NewFrame -= Camera_On;
                videoCapture.SignalToStop();
                videoCapture.WaitForStop();
                videoCapture = null;
            }
        }

        private void CadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        private void materialTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
