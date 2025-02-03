namespace CancelaIFSP.App.Cadastros
{
    partial class CadastroUsuario
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCPF = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
            txtTag = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new System.Drawing.Size(271, 315);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtTag);
            tabPageCadastro.Controls.Add(cboCategoria);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtMatricula);
            tabPageCadastro.Controls.Add(txtCPF);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Size = new System.Drawing.Size(263, 280);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCPF, 0);
            tabPageCadastro.Controls.SetChildIndex(txtMatricula, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCategoria, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTag, 0);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new System.Drawing.Point(6, 6);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new System.Drawing.Size(250, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            txtNome.Click += txtNome_Click;
            // 
            // txtCPF
            // 
            txtCPF.AnimateReadOnly = false;
            txtCPF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txtCPF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txtCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            txtCPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtCPF.Depth = 0;
            txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtCPF.HideSelection = true;
            txtCPF.Hint = "CPF";
            txtCPF.LeadingIcon = null;
            txtCPF.Location = new System.Drawing.Point(6, 60);
            txtCPF.MaxLength = 32767;
            txtCPF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCPF.Name = "txtCPF";
            txtCPF.PasswordChar = '\0';
            txtCPF.PrefixSuffixText = null;
            txtCPF.ReadOnly = false;
            txtCPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCPF.SelectedText = "";
            txtCPF.SelectionLength = 0;
            txtCPF.SelectionStart = 0;
            txtCPF.ShortcutsEnabled = true;
            txtCPF.Size = new System.Drawing.Size(199, 48);
            txtCPF.TabIndex = 2;
            txtCPF.TabStop = false;
            txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtCPF.TrailingIcon = null;
            txtCPF.UseSystemPasswordChar = false;
            // 
            // txtMatricula
            // 
            txtMatricula.AnimateReadOnly = false;
            txtMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txtMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txtMatricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            txtMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtMatricula.Depth = 0;
            txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtMatricula.HideSelection = true;
            txtMatricula.Hint = "Matrícula";
            txtMatricula.LeadingIcon = null;
            txtMatricula.Location = new System.Drawing.Point(6, 114);
            txtMatricula.MaxLength = 32767;
            txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PasswordChar = '\0';
            txtMatricula.PrefixSuffixText = null;
            txtMatricula.ReadOnly = false;
            txtMatricula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtMatricula.SelectedText = "";
            txtMatricula.SelectionLength = 0;
            txtMatricula.SelectionStart = 0;
            txtMatricula.ShortcutsEnabled = true;
            txtMatricula.Size = new System.Drawing.Size(156, 48);
            txtMatricula.TabIndex = 3;
            txtMatricula.TabStop = false;
            txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtMatricula.TrailingIcon = null;
            txtMatricula.UseSystemPasswordChar = false;
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
            txtId.Location = new System.Drawing.Point(211, 60);
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
            txtId.Size = new System.Drawing.Size(45, 48);
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.Text = "ID";
            txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboCategoria
            // 
            cboCategoria.AutoResize = false;
            cboCategoria.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cboCategoria.Depth = 0;
            cboCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cboCategoria.DropDownHeight = 174;
            cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCategoria.DropDownWidth = 121;
            cboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            cboCategoria.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Hint = "Categoria";
            cboCategoria.IntegralHeight = false;
            cboCategoria.ItemHeight = 43;
            cboCategoria.Items.AddRange(new object[] { "", "Estudante", "Servidor", "Professor" });
            cboCategoria.Location = new System.Drawing.Point(6, 168);
            cboCategoria.MaxDropDownItems = 4;
            cboCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new System.Drawing.Size(250, 49);
            cboCategoria.StartIndex = 0;
            cboCategoria.TabIndex = 5;
            // 
            // txtTag
            // 
            txtTag.AnimateReadOnly = false;
            txtTag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txtTag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txtTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            txtTag.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtTag.Depth = 0;
            txtTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtTag.HideSelection = true;
            txtTag.Hint = "Tag";
            txtTag.LeadingIcon = null;
            txtTag.Location = new System.Drawing.Point(168, 114);
            txtTag.MaxLength = 32767;
            txtTag.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTag.Name = "txtTag";
            txtTag.PasswordChar = '\0';
            txtTag.PrefixSuffixText = null;
            txtTag.ReadOnly = false;
            txtTag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtTag.SelectedText = "";
            txtTag.SelectionLength = 0;
            txtTag.SelectionStart = 0;
            txtTag.ShortcutsEnabled = true;
            txtTag.Size = new System.Drawing.Size(87, 48);
            txtTag.TabIndex = 6;
            txtTag.TabStop = false;
            txtTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtTag.TrailingIcon = null;
            txtTag.UseSystemPasswordChar = false;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(277, 382);
            Location = new System.Drawing.Point(0, 0);
            Name = "CadastroUsuario";
            Text = "Cadastro Usuario";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCPF;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialComboBox cboCategoria;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTag;
    }
}