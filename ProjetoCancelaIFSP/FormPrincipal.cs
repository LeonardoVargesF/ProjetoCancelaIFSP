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
using OpenCvSharp;
using System.Threading;



namespace ProjetoCancelaIFSP
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public partial class FormPrincipal : Form
    {
        private Button currentButton;
        private Form formAtivo;
        private bool isRunning = true;
        VideoCapture _capture = new VideoCapture(0);
        Mat _image = new Mat();
        Thread thread;

        public FormPrincipal()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            thread = new Thread(CaptureVideo);
            thread.IsBackground = true;
            thread.Start();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
            if (thread != null && thread.IsAlive)
            {
                thread.Join(1000);
            }

            _capture?.Dispose();
        }

        public void CaptureVideo()
        {
            while (isRunning)
            {
                _capture.Read(_image);

                if (_image == null || _image.Empty())
                    continue;

                var bmp = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(_image);

                if (pictureBox1.InvokeRequired)
                {
                    pictureBox1.Invoke(new Action(() =>
                    {
                        pictureBox1.Image?.Dispose();
                        pictureBox1.Image = bmp;
                    }));
                }
                else
                {
                    pictureBox1.Image?.Dispose();
                    pictureBox1.Image = bmp;
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


        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
