namespace CancelaIFSP.App.Cadastros
{
    partial class CadastroCarro
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
            txtModelo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPlaca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCor = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAno = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new System.Drawing.Size(256, 316);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtAno);
            tabPageCadastro.Controls.Add(txtCor);
            tabPageCadastro.Controls.Add(txtPlaca);
            tabPageCadastro.Controls.Add(txtModelo);
            tabPageCadastro.Size = new System.Drawing.Size(248, 281);
            tabPageCadastro.Controls.SetChildIndex(txtModelo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPlaca, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCor, 0);
            tabPageCadastro.Controls.SetChildIndex(txtAno, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // txtModelo
            // 
            txtModelo.AnimateReadOnly = false;
            txtModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txtModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txtModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtModelo.Depth = 0;
            txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtModelo.HideSelection = true;
            txtModelo.LeadingIcon = null;
            txtModelo.Location = new System.Drawing.Point(6, 6);
            txtModelo.MaxLength = 32767;
            txtModelo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtModelo.Name = "txtModelo";
            txtModelo.PasswordChar = '\0';
            txtModelo.PrefixSuffixText = null;
            txtModelo.ReadOnly = false;
            txtModelo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtModelo.SelectedText = "";
            txtModelo.SelectionLength = 0;
            txtModelo.SelectionStart = 0;
            txtModelo.ShortcutsEnabled = true;
            txtModelo.Size = new System.Drawing.Size(234, 48);
            txtModelo.TabIndex = 1;
            txtModelo.TabStop = false;
            txtModelo.Text = "Modelo do Carro";
            txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtModelo.TrailingIcon = null;
            txtModelo.UseSystemPasswordChar = false;
            // 
            // txtPlaca
            // 
            txtPlaca.AnimateReadOnly = false;
            txtPlaca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txtPlaca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txtPlaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtPlaca.Depth = 0;
            txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtPlaca.HideSelection = true;
            txtPlaca.LeadingIcon = null;
            txtPlaca.Location = new System.Drawing.Point(6, 60);
            txtPlaca.MaxLength = 32767;
            txtPlaca.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.PasswordChar = '\0';
            txtPlaca.PrefixSuffixText = null;
            txtPlaca.ReadOnly = false;
            txtPlaca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtPlaca.SelectedText = "";
            txtPlaca.SelectionLength = 0;
            txtPlaca.SelectionStart = 0;
            txtPlaca.ShortcutsEnabled = true;
            txtPlaca.Size = new System.Drawing.Size(234, 48);
            txtPlaca.TabIndex = 2;
            txtPlaca.TabStop = false;
            txtPlaca.Text = "Placa";
            txtPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtPlaca.TrailingIcon = null;
            txtPlaca.UseSystemPasswordChar = false;
            // 
            // txtCor
            // 
            txtCor.AnimateReadOnly = false;
            txtCor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txtCor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txtCor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            txtCor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtCor.Depth = 0;
            txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtCor.HideSelection = true;
            txtCor.LeadingIcon = null;
            txtCor.Location = new System.Drawing.Point(6, 114);
            txtCor.MaxLength = 32767;
            txtCor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCor.Name = "txtCor";
            txtCor.PasswordChar = '\0';
            txtCor.PrefixSuffixText = null;
            txtCor.ReadOnly = false;
            txtCor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCor.SelectedText = "";
            txtCor.SelectionLength = 0;
            txtCor.SelectionStart = 0;
            txtCor.ShortcutsEnabled = true;
            txtCor.Size = new System.Drawing.Size(178, 48);
            txtCor.TabIndex = 3;
            txtCor.TabStop = false;
            txtCor.Text = "Cor";
            txtCor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtCor.TrailingIcon = null;
            txtCor.UseSystemPasswordChar = false;
            // 
            // txtAno
            // 
            txtAno.AnimateReadOnly = false;
            txtAno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txtAno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txtAno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            txtAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtAno.Depth = 0;
            txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtAno.HideSelection = true;
            txtAno.LeadingIcon = null;
            txtAno.Location = new System.Drawing.Point(6, 168);
            txtAno.MaxLength = 32767;
            txtAno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAno.Name = "txtAno";
            txtAno.PasswordChar = '\0';
            txtAno.PrefixSuffixText = null;
            txtAno.ReadOnly = false;
            txtAno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtAno.SelectedText = "";
            txtAno.SelectionLength = 0;
            txtAno.SelectionStart = 0;
            txtAno.ShortcutsEnabled = true;
            txtAno.Size = new System.Drawing.Size(234, 48);
            txtAno.TabIndex = 4;
            txtAno.TabStop = false;
            txtAno.Text = "Ano";
            txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtAno.TrailingIcon = null;
            txtAno.UseSystemPasswordChar = false;
            txtAno.Click += materialTextBoxEdit4_Click;
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
            txtId.Location = new System.Drawing.Point(190, 114);
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
            txtId.Size = new System.Drawing.Size(50, 48);
            txtId.TabIndex = 5;
            txtId.TabStop = false;
            txtId.Text = "ID";
            txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroCarro
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(262, 383);
            Location = new System.Drawing.Point(0, 0);
            Name = "CadastroCarro";
            Text = "CadastroCarro";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCor;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPlaca;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtModelo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAno;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}