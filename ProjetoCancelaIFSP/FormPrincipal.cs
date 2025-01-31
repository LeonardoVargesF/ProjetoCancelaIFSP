using CancelaIFSP.App.Infra;
using ReaLTaiizor.Forms;
using System;
using CancelaIFSP.App.Cadastros;
using CancelaIFSP.Domain.Entities;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;


namespace ProjetoCancelaIFSP
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCarro>();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroUsuario>();
        }

        private void tagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroTag>();
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }

        private void FormPrincipal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}
