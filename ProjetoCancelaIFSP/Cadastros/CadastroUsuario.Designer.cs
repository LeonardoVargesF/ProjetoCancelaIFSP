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
            components = new System.ComponentModel.Container();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCPF = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
            cboVeiculos = new ReaLTaiizor.Controls.MaterialComboBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            imageList1 = new System.Windows.Forms.ImageList(components);
            btnCapture = new ReaLTaiizor.Controls.MaterialButton();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            materialTabControl.Dock = System.Windows.Forms.DockStyle.None;
            materialTabControl.Size = new System.Drawing.Size(444, 372);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnCapture);
            tabPageCadastro.Controls.Add(pictureBox1);
            tabPageCadastro.Controls.Add(cboVeiculos);
            tabPageCadastro.Controls.Add(cboCategoria);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtMatricula);
            tabPageCadastro.Controls.Add(txtCPF);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Size = new System.Drawing.Size(436, 337);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCPF, 0);
            tabPageCadastro.Controls.SetChildIndex(txtMatricula, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCategoria, 0);
            tabPageCadastro.Controls.SetChildIndex(cboVeiculos, 0);
            tabPageCadastro.Controls.SetChildIndex(pictureBox1, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCapture, 0);
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
            txtMatricula.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
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
            txtMatricula.Size = new System.Drawing.Size(287, 48);
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
            // cboVeiculos
            // 
            cboVeiculos.AutoResize = false;
            cboVeiculos.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cboVeiculos.Depth = 0;
            cboVeiculos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cboVeiculos.DropDownHeight = 174;
            cboVeiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboVeiculos.DropDownWidth = 121;
            cboVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            cboVeiculos.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            cboVeiculos.FormattingEnabled = true;
            cboVeiculos.Hint = "Veículo";
            cboVeiculos.IntegralHeight = false;
            cboVeiculos.ItemHeight = 43;
            cboVeiculos.Location = new System.Drawing.Point(6, 223);
            cboVeiculos.MaxDropDownItems = 4;
            cboVeiculos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboVeiculos.Name = "cboVeiculos";
            cboVeiculos.Size = new System.Drawing.Size(250, 49);
            cboVeiculos.StartIndex = 0;
            cboVeiculos.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(262, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(169, 156);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageSize = new System.Drawing.Size(16, 16);
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnCapture
            // 
            btnCapture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnCapture.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCapture.Depth = 0;
            btnCapture.HighEmphasis = true;
            btnCapture.Icon = null;
            btnCapture.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCapture.Location = new System.Drawing.Point(302, 171);
            btnCapture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnCapture.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCapture.Name = "btnCapture";
            btnCapture.NoAccentTextColor = System.Drawing.Color.Empty;
            btnCapture.Size = new System.Drawing.Size(86, 36);
            btnCapture.TabIndex = 11;
            btnCapture.Text = "Capture";
            btnCapture.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCapture.UseAccentColor = false;
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(450, 439);
            Location = new System.Drawing.Point(0, 0);
            Name = "CadastroUsuario";
            Text = "Cadastro Usuario";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCPF;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialComboBox cboCategoria;
        private ReaLTaiizor.Controls.MaterialComboBox cboVeiculos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialButton btnCapture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
    }
}