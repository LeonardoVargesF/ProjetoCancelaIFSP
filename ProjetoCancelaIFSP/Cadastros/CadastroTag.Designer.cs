namespace CancelaIFSP.App.Cadastros
{
    partial class CadastroTag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboUsuario = new ReaLTaiizor.Controls.MaterialComboBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new System.Drawing.Size(269, 209);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboUsuario);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtCodigo);
            tabPageCadastro.Size = new System.Drawing.Size(261, 174);
            tabPageCadastro.Controls.SetChildIndex(txtCodigo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboUsuario, 0);
            // 
            // txtCodigo
            // 
            txtCodigo.AnimateReadOnly = false;
            txtCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txtCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txtCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtCodigo.Depth = 0;
            txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtCodigo.HideSelection = true;
            txtCodigo.LeadingIcon = null;
            txtCodigo.Location = new System.Drawing.Point(6, 6);
            txtCodigo.MaxLength = 32767;
            txtCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.PrefixSuffixText = null;
            txtCodigo.ReadOnly = false;
            txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.ShortcutsEnabled = true;
            txtCodigo.Size = new System.Drawing.Size(197, 48);
            txtCodigo.TabIndex = 1;
            txtCodigo.TabStop = false;
            txtCodigo.Text = "Tag RFID";
            txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txtId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.LeadingIcon = null;
            txtId.Location = new System.Drawing.Point(209, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new System.Drawing.Size(47, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.Text = "ID";
            txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboUsuario
            // 
            cboUsuario.AutoResize = false;
            cboUsuario.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cboUsuario.Depth = 0;
            cboUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cboUsuario.DropDownHeight = 174;
            cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboUsuario.DropDownWidth = 121;
            cboUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            cboUsuario.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            cboUsuario.FormattingEnabled = true;
            cboUsuario.IntegralHeight = false;
            cboUsuario.ItemHeight = 43;
            cboUsuario.Location = new System.Drawing.Point(6, 60);
            cboUsuario.MaxDropDownItems = 4;
            cboUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new System.Drawing.Size(250, 49);
            cboUsuario.StartIndex = 0;
            cboUsuario.TabIndex = 3;
            // 
            // CadastroTag
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(275, 276);
            Location = new System.Drawing.Point(0, 0);
            Name = "CadastroTag";
            Text = "CadastroTag";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigo;
        private ReaLTaiizor.Controls.MaterialComboBox cboUsuario;
    }
}