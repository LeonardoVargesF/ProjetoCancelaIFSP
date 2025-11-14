using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Windows.Forms;
using System;

namespace CancelaIFSP.App.Base
{
    public partial class CadastroBase : Form
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

        #region Construtor
        public CadastroBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Salvar();
        }

        protected void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (var control in this.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }

                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        protected virtual void Salvar()
        {

        }


        #endregion

        private void CadastroBase_Load(object sender, EventArgs e)
        {

        }

        
    }
}