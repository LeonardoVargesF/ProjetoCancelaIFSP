namespace CancelaIFSP.App.Cadastros
{
    partial class CadastroUsuarioCarro
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
            cboUsuarios = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCarros = new ReaLTaiizor.Controls.MaterialComboBox();
            btnCadastrar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPageConsulta = new System.Windows.Forms.TabPage();
            flowLayoutCadastros = new System.Windows.Forms.FlowLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // cboUsuarios
            // 
            cboUsuarios.AutoResize = false;
            cboUsuarios.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cboUsuarios.Depth = 0;
            cboUsuarios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cboUsuarios.DropDownHeight = 174;
            cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboUsuarios.DropDownWidth = 121;
            cboUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            cboUsuarios.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            cboUsuarios.FormattingEnabled = true;
            cboUsuarios.Hint = "Usuário";
            cboUsuarios.IntegralHeight = false;
            cboUsuarios.ItemHeight = 43;
            cboUsuarios.Location = new System.Drawing.Point(27, 49);
            cboUsuarios.MaxDropDownItems = 4;
            cboUsuarios.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboUsuarios.Name = "cboUsuarios";
            cboUsuarios.Size = new System.Drawing.Size(121, 49);
            cboUsuarios.StartIndex = 0;
            cboUsuarios.TabIndex = 0;
            // 
            // cboCarros
            // 
            cboCarros.AutoResize = false;
            cboCarros.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cboCarros.Depth = 0;
            cboCarros.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cboCarros.DropDownHeight = 174;
            cboCarros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCarros.DropDownWidth = 121;
            cboCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            cboCarros.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            cboCarros.FormattingEnabled = true;
            cboCarros.Hint = "Veiculo";
            cboCarros.IntegralHeight = false;
            cboCarros.ItemHeight = 43;
            cboCarros.Location = new System.Drawing.Point(193, 49);
            cboCarros.MaxDropDownItems = 4;
            cboCarros.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCarros.Name = "cboCarros";
            cboCarros.Size = new System.Drawing.Size(121, 49);
            cboCarros.StartIndex = 0;
            cboCarros.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnCadastrar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadastrar.Depth = 0;
            btnCadastrar.HighEmphasis = true;
            btnCadastrar.Icon = null;
            btnCadastrar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCadastrar.Location = new System.Drawing.Point(208, 128);
            btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnCadastrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.NoAccentTextColor = System.Drawing.Color.Empty;
            btnCadastrar.Size = new System.Drawing.Size(106, 36);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadastrar.UseAccentColor = false;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new System.Drawing.Point(27, 128);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            btnCancelar.Size = new System.Drawing.Size(96, 36);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPageConsulta);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(3, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(349, 210);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cboUsuarios);
            tabPage1.Controls.Add(btnCadastrar);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(cboCarros);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(341, 182);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(flowLayoutCadastros);
            tabPageConsulta.Location = new System.Drawing.Point(4, 24);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new System.Windows.Forms.Padding(3);
            tabPageConsulta.Size = new System.Drawing.Size(341, 182);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Relatório";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            tabPageConsulta.Leave += tabPageConsulta_Leave;
            // 
            // flowLayoutCadastros
            // 
            flowLayoutCadastros.AutoScroll = true;
            flowLayoutCadastros.Location = new System.Drawing.Point(3, 3);
            flowLayoutCadastros.Name = "flowLayoutCadastros";
            flowLayoutCadastros.Size = new System.Drawing.Size(335, 176);
            flowLayoutCadastros.TabIndex = 0;
            // 
            // CadastroUsuarioCarro
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(355, 277);
            Controls.Add(tabControl1);
            Name = "CadastroUsuarioCarro";
            Text = "CadastroUsuarioCarro";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboUsuarios;
        private ReaLTaiizor.Controls.MaterialComboBox cboCarros;
        private ReaLTaiizor.Controls.MaterialButton btnCadastrar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageConsulta;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCadastros;
    }
}