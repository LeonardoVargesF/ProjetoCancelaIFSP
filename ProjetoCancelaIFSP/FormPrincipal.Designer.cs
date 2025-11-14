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
            panelMenu = new System.Windows.Forms.Panel();
            btnRelatorioVeiculo = new System.Windows.Forms.Button();
            btnUsuario = new System.Windows.Forms.Button();
            btnVeiculo = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            panelDesktopPane = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            btnFechar = new System.Windows.Forms.Button();
            btnMaximizar = new System.Windows.Forms.Button();
            btnMinimizar = new System.Windows.Forms.Button();
            btnCloseForm = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            btnRelatorioUsuario = new System.Windows.Forms.Button();
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
            panelMenu.BackColor = System.Drawing.Color.FromArgb(57, 160, 72);
            panelMenu.Controls.Add(btnRelatorioUsuario);
            panelMenu.Controls.Add(btnRelatorioVeiculo);
            panelMenu.Controls.Add(btnUsuario);
            panelMenu.Controls.Add(btnVeiculo);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.ForeColor = System.Drawing.Color.Gainsboro;
            panelMenu.Location = new System.Drawing.Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(180, 461);
            panelMenu.TabIndex = 5;
            // 
            // btnRelatorioVeiculo
            // 
            btnRelatorioVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            btnRelatorioVeiculo.FlatAppearance.BorderSize = 0;
            btnRelatorioVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRelatorioVeiculo.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnRelatorioVeiculo.Image = (System.Drawing.Image)resources.GetObject("btnRelatorioVeiculo.Image");
            btnRelatorioVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRelatorioVeiculo.Location = new System.Drawing.Point(0, 180);
            btnRelatorioVeiculo.Name = "btnRelatorioVeiculo";
            btnRelatorioVeiculo.Size = new System.Drawing.Size(180, 60);
            btnRelatorioVeiculo.TabIndex = 8;
            btnRelatorioVeiculo.Text = "Relatório";
            btnRelatorioVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRelatorioVeiculo.UseVisualStyleBackColor = true;
            btnRelatorioVeiculo.Click += btnRelatorio_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnUsuario.Image = (System.Drawing.Image)resources.GetObject("btnUsuario.Image");
            btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUsuario.Location = new System.Drawing.Point(0, 120);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new System.Drawing.Size(180, 60);
            btnUsuario.TabIndex = 7;
            btnUsuario.Text = "Cadastro Usuários";
            btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnVeiculo
            // 
            btnVeiculo.Dock = System.Windows.Forms.DockStyle.Top;
            btnVeiculo.FlatAppearance.BorderSize = 0;
            btnVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnVeiculo.Image = (System.Drawing.Image)resources.GetObject("btnVeiculo.Image");
            btnVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVeiculo.Location = new System.Drawing.Point(0, 60);
            btnVeiculo.Name = "btnVeiculo";
            btnVeiculo.Size = new System.Drawing.Size(180, 60);
            btnVeiculo.TabIndex = 6;
            btnVeiculo.Text = "Cadastro Veículos";
            btnVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnVeiculo.UseVisualStyleBackColor = true;
            btnVeiculo.Click += btnVeiculo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(0, 45, 0);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(180, 60);
            panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(180, 60);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Controls.Add(pictureBox1);
            panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            panelDesktopPane.Location = new System.Drawing.Point(180, 60);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new System.Drawing.Size(604, 401);
            panelDesktopPane.TabIndex = 9;
            panelDesktopPane.Paint += panelDesktopPane_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            pictureBox1.Location = new System.Drawing.Point(173, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(251, 226);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(57, 160, 72);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(btnMaximizar);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnCloseForm);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(180, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(604, 60);
            panel1.TabIndex = 7;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnFechar.ForeColor = System.Drawing.Color.Gainsboro;
            btnFechar.Location = new System.Drawing.Point(574, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new System.Drawing.Size(30, 20);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "x";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMaximizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnMaximizar.ForeColor = System.Drawing.Color.Gainsboro;
            btnMaximizar.Location = new System.Drawing.Point(539, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new System.Drawing.Size(30, 20);
            btnMaximizar.TabIndex = 3;
            btnMaximizar.Text = "o";
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnTelaCheia_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnMinimizar.ForeColor = System.Drawing.Color.Gainsboro;
            btnMinimizar.Location = new System.Drawing.Point(503, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new System.Drawing.Size(30, 20);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCloseForm
            // 
            btnCloseForm.Dock = System.Windows.Forms.DockStyle.Left;
            btnCloseForm.FlatAppearance.BorderSize = 0;
            btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseForm.Image = (System.Drawing.Image)resources.GetObject("btnCloseForm.Image");
            btnCloseForm.Location = new System.Drawing.Point(0, 0);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new System.Drawing.Size(60, 60);
            btnCloseForm.TabIndex = 1;
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += btnCloseForm_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(272, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(76, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            lblTitle.MouseDown += lblTitle_MouseDown;
            // 
            // btnRelatorioUsuario
            // 
            btnRelatorioUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            btnRelatorioUsuario.FlatAppearance.BorderSize = 0;
            btnRelatorioUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRelatorioUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnRelatorioUsuario.Image = (System.Drawing.Image)resources.GetObject("btnRelatorioUsuario.Image");
            btnRelatorioUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRelatorioUsuario.Location = new System.Drawing.Point(0, 240);
            btnRelatorioUsuario.Name = "btnRelatorioUsuario";
            btnRelatorioUsuario.Size = new System.Drawing.Size(180, 60);
            btnRelatorioUsuario.TabIndex = 9;
            btnRelatorioUsuario.Text = "Relatório";
            btnRelatorioUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRelatorioUsuario.UseVisualStyleBackColor = true;
            btnRelatorioUsuario.Click += btnRelatorioUsuario_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            ClientSize = new System.Drawing.Size(784, 461);
            Controls.Add(panelDesktopPane);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            IsMdiContainer = true;
            MinimumSize = new System.Drawing.Size(800, 500);
            Name = "FormPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "IFSP - Birigui";
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

