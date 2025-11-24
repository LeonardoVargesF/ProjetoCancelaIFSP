namespace ProjetoCancelaIFSP
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelMenu = new Panel();
            btnRelatorioUsuario = new Button();
            btnRelatorioVeiculo = new Button();
            btnUsuario = new Button();
            btnVeiculo = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panelDesktopPane = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnFechar = new Button();
            btnMaximizar = new Button();
            btnMinimizar = new Button();
            btnCloseForm = new Button();
            lblTitle = new Label();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(57, 160, 72);
            panelMenu.Controls.Add(btnRelatorioUsuario);
            panelMenu.Controls.Add(btnRelatorioVeiculo);
            panelMenu.Controls.Add(btnUsuario);
            panelMenu.Controls.Add(btnVeiculo);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.Gainsboro;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(180, 461);
            panelMenu.TabIndex = 5;
            // 
            // btnRelatorioUsuario
            // 
            btnRelatorioUsuario.Dock = DockStyle.Top;
            btnRelatorioUsuario.FlatAppearance.BorderSize = 0;
            btnRelatorioUsuario.FlatStyle = FlatStyle.Flat;
            btnRelatorioUsuario.Font = new Font("Segoe UI", 10F);
            btnRelatorioUsuario.Image = (Image)resources.GetObject("btnRelatorioUsuario.Image");
            btnRelatorioUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorioUsuario.Location = new Point(0, 240);
            btnRelatorioUsuario.Name = "btnRelatorioUsuario";
            btnRelatorioUsuario.Size = new Size(180, 60);
            btnRelatorioUsuario.TabIndex = 9;
            btnRelatorioUsuario.Text = "Relatório";
            btnRelatorioUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRelatorioUsuario.UseVisualStyleBackColor = true;
            btnRelatorioUsuario.Click += btnRelatorioUsuario_Click;
            // 
            // btnRelatorioVeiculo
            // 
            btnRelatorioVeiculo.Dock = DockStyle.Top;
            btnRelatorioVeiculo.FlatAppearance.BorderSize = 0;
            btnRelatorioVeiculo.FlatStyle = FlatStyle.Flat;
            btnRelatorioVeiculo.Font = new Font("Segoe UI", 10F);
            btnRelatorioVeiculo.Image = (Image)resources.GetObject("btnRelatorioVeiculo.Image");
            btnRelatorioVeiculo.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorioVeiculo.Location = new Point(0, 180);
            btnRelatorioVeiculo.Name = "btnRelatorioVeiculo";
            btnRelatorioVeiculo.Size = new Size(180, 60);
            btnRelatorioVeiculo.TabIndex = 8;
            btnRelatorioVeiculo.Text = "Relatório";
            btnRelatorioVeiculo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRelatorioVeiculo.UseVisualStyleBackColor = true;
            btnRelatorioVeiculo.Click += btnRelatorio_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Dock = DockStyle.Top;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Segoe UI", 10F);
            btnUsuario.Image = (Image)resources.GetObject("btnUsuario.Image");
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.Location = new Point(0, 120);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(180, 60);
            btnUsuario.TabIndex = 7;
            btnUsuario.Text = "Cadastro Usuários";
            btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnVeiculo
            // 
            btnVeiculo.Dock = DockStyle.Top;
            btnVeiculo.FlatAppearance.BorderSize = 0;
            btnVeiculo.FlatStyle = FlatStyle.Flat;
            btnVeiculo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVeiculo.Image = (Image)resources.GetObject("btnVeiculo.Image");
            btnVeiculo.ImageAlign = ContentAlignment.MiddleLeft;
            btnVeiculo.Location = new Point(0, 60);
            btnVeiculo.Name = "btnVeiculo";
            btnVeiculo.Size = new Size(180, 60);
            btnVeiculo.TabIndex = 6;
            btnVeiculo.Text = "Cadastro Veículos";
            btnVeiculo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVeiculo.UseVisualStyleBackColor = true;
            btnVeiculo.Click += btnVeiculo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 45, 0);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 60);
            panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 60);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Controls.Add(pictureBox1);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(180, 60);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(604, 401);
            panelDesktopPane.TabIndex = 9;
            panelDesktopPane.Paint += panelDesktopPane_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(178, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 226);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 160, 72);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(btnMaximizar);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnCloseForm);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(180, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 60);
            panel1.TabIndex = 7;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 9F);
            btnFechar.ForeColor = Color.Gainsboro;
            btnFechar.Location = new Point(574, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(30, 20);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "x";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Font = new Font("Segoe UI", 9F);
            btnMaximizar.ForeColor = Color.Gainsboro;
            btnMaximizar.Location = new Point(539, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(30, 20);
            btnMaximizar.TabIndex = 3;
            btnMaximizar.Text = "o";
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnTelaCheia_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 9F);
            btnMinimizar.ForeColor = Color.Gainsboro;
            btnMinimizar.Location = new Point(503, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 20);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCloseForm
            // 
            btnCloseForm.Dock = DockStyle.Left;
            btnCloseForm.FlatAppearance.BorderSize = 0;
            btnCloseForm.FlatStyle = FlatStyle.Flat;
            btnCloseForm.Image = (Image)resources.GetObject("btnCloseForm.Image");
            btnCloseForm.Location = new Point(0, 0);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(60, 60);
            btnCloseForm.TabIndex = 1;
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += btnCloseForm_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(272, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(76, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            lblTitle.MouseDown += lblTitle_MouseDown;
            // 
            // FormPrincipal
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(784, 461);
            Controls.Add(panelDesktopPane);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            IsMdiContainer = true;
            MinimumSize = new Size(800, 500);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IFSP - Birigui";
            FormClosing += FormPrincipal_FormClosing;
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnVeiculo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRelatorioVeiculo;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRelatorioUsuario;
    }
}

