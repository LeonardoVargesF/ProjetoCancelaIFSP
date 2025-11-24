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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCPF = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            imageList1 = new System.Windows.Forms.ImageList(components);
            cboVeiculos = new ReaLTaiizor.Controls.MaterialComboBox();
            btnCapture = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            txtNome.Location = new System.Drawing.Point(28, 28);
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
            txtCPF.Location = new System.Drawing.Point(28, 98);
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
            txtMatricula.Location = new System.Drawing.Point(28, 168);
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
            txtMatricula.Size = new System.Drawing.Size(250, 48);
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
            txtId.Location = new System.Drawing.Point(233, 98);
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
            cboCategoria.Location = new System.Drawing.Point(28, 238);
            cboCategoria.MaxDropDownItems = 4;
            cboCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new System.Drawing.Size(250, 49);
            cboCategoria.StartIndex = 0;
            cboCategoria.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(312, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(261, 252);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageSize = new System.Drawing.Size(16, 16);
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            cboVeiculos.Items.AddRange(new object[] { "", "Estudante", "Servidor", "Professor" });
            cboVeiculos.Location = new System.Drawing.Point(28, 308);
            cboVeiculos.MaxDropDownItems = 4;
            cboVeiculos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboVeiculos.Name = "cboVeiculos";
            cboVeiculos.Size = new System.Drawing.Size(250, 49);
            cboVeiculos.StartIndex = 0;
            cboVeiculos.TabIndex = 12;
            // 
            // btnCapture
            // 
            btnCapture.BackColor = System.Drawing.Color.Gray;
            btnCapture.BackgroundColor = System.Drawing.Color.Gray;
            btnCapture.BorderColor = System.Drawing.Color.Black;
            btnCapture.BorderRadius = 35;
            btnCapture.BorderSize = 1;
            btnCapture.FlatAppearance.BorderSize = 0;
            btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCapture.ForeColor = System.Drawing.Color.White;
            btnCapture.Image = (System.Drawing.Image)resources.GetObject("btnCapture.Image");
            btnCapture.Location = new System.Drawing.Point(405, 287);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new System.Drawing.Size(70, 70);
            btnCapture.TabIndex = 13;
            btnCapture.TextColor = System.Drawing.Color.White;
            btnCapture.UseVisualStyleBackColor = false;
            btnCapture.Click += btnCapture_Click_1;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(610, 437);
            Controls.Add(btnCapture);
            Controls.Add(cboVeiculos);
            Controls.Add(pictureBox1);
            Controls.Add(txtNome);
            Controls.Add(cboCategoria);
            Controls.Add(txtCPF);
            Controls.Add(txtId);
            Controls.Add(txtMatricula);
            Name = "CadastroUsuario";
            Text = "Cadastro Usuario";
            FormClosing += CadastroUsuario_FormClosing;
            Controls.SetChildIndex(txtMatricula, 0);
            Controls.SetChildIndex(txtId, 0);
            Controls.SetChildIndex(txtCPF, 0);
            Controls.SetChildIndex(cboCategoria, 0);
            Controls.SetChildIndex(txtNome, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(cboVeiculos, 0);
            Controls.SetChildIndex(btnCapture, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCPF;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialComboBox cboCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialComboBox cboVeiculos;
        private CustomControls.RJControls.RJButton btnCapture;
    }
}