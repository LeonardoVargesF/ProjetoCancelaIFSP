using AForge.Video;
using AForge.Video.DirectShow;
using CancelaIFSP.App.Cadastros;
using CancelaIFSP.App.Infra;
using CancelaIFSP.App.Outros;
using CancelaIFSP.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjetoCancelaIFSP
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public partial class FormPrincipal : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Timer timer;
        private VideoCaptureDevice videoCapture;
        private FilterInfoCollection filterInfo;
        private Bitmap frameOriginal;
        private bool estaEnviandoImagem = false;
        private readonly object frameLock = new object();
        private Form formAtivo;
        public FormPrincipal()
        {
            InitializeComponent();
            startCamera();
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            btnCloseForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(39, 109, 48);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                    btnCloseForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(57, 160, 72);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

            if (pictureBox1.Width <= 0 || pictureBox1.Height <= 0)
            {
                eventArgs.Frame.Dispose();
                return;
            }

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
        private async Task<string> EnviarImagemAsync(byte[] imagemBytes)
        {
            using var client = new HttpClient();
            using var form = new MultipartFormDataContent();

            var content = new ByteArrayContent(imagemBytes);
            content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
            form.Add(content, "file", "imagem.jpg");

            var response = await client.PostAsync("http://127.0.0.1:8000/detectar_rosto", form);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        byte[] ImageToBytes(Image image)
        {
            using var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            try
            {
                Bitmap frameParaEnviar = null;
                lock (frameLock)
                {
                    if (frameOriginal != null)
                    {
                        frameParaEnviar = (Bitmap)frameOriginal.Clone();
                    }
                }

                if (frameParaEnviar != null)
                {
                    byte[] frameBytes = ImageToBytes(frameParaEnviar);
                    string resposta = await EnviarImagemAsync(frameBytes);


                    frameParaEnviar.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao enviar imagem: " + ex.Message);
            }
            finally
            {
                timer.Start();
            }
        }

        private void AbrirFormularioNoPainel<TFormlario>(object btnSender) where TFormlario : Form
        {
            if (formAtivo != null && formAtivo.GetType() == typeof(TFormlario))
            {
                formAtivo.BringToFront();
                return;
            }

            var childForm = ConfigureDI.ServicesProvider!.GetService<TFormlario>();

            if (childForm != null)
            {
                if (formAtivo != null)
                {
                    formAtivo.Close();
                }

                ActivateButton(btnSender);
                formAtivo = childForm;

                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDesktopPane.Controls.Add(childForm);
                this.panelDesktopPane.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                lblTitle.Text = childForm.Text;
            }
            else
            {
                MessageBox.Show("Erro ao carregar o formulário. Verifique o DI.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel<CadastroUsuario>(sender);
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel<CadastroVeiculo>(sender);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel<RelatorioVeiculo>(sender);
        }

        private void btnRelatorioUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel<RelatorioUsuario>(sender);
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            currentButton = null;
            btnCloseForm.Visible = false;

        }

        private void btnCloseForm_Click_1(object sender, EventArgs e)
        {
            if (formAtivo != null)
            {
                formAtivo.Close();
            }
            Reset();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTelaCheia_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
    }
}
