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
            menuStrip2 = new System.Windows.Forms.MenuStrip();
            cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            carrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { cadastrosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip2.Location = new System.Drawing.Point(3, 64);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new System.Drawing.Size(794, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { carrosToolStripMenuItem, usuariosToolStripMenuItem, tagsToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // carrosToolStripMenuItem
            // 
            carrosToolStripMenuItem.Name = "carrosToolStripMenuItem";
            carrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            carrosToolStripMenuItem.Text = "Carros";
            carrosToolStripMenuItem.Click += carrosToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // tagsToolStripMenuItem
            // 
            tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            tagsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            tagsToolStripMenuItem.Text = "Tags";
            tagsToolStripMenuItem.Click += tagsToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            sairToolStripMenuItem.Text = "&Sair";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip2);
            IsMdiContainer = true;
            Name = "FormPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "IFSP - Birigui";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

