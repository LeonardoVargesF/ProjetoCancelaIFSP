namespace CancelaIFSP.App.Outros
{
    partial class CaixadeCadastros
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblNomeUsuario = new System.Windows.Forms.Label();
            lblCPFUsuario = new System.Windows.Forms.Label();
            lblCategoriaUsuario = new System.Windows.Forms.Label();
            lblModeloCarro = new System.Windows.Forms.Label();
            lblPlacaCarro = new System.Windows.Forms.Label();
            lblCorCarro = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            lblNomeUsuario.Location = new System.Drawing.Point(3, 30);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new System.Drawing.Size(41, 15);
            lblNomeUsuario.TabIndex = 0;
            lblNomeUsuario.Text = "label1";
            // 
            // lblCPFUsuario
            // 
            lblCPFUsuario.AutoSize = true;
            lblCPFUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            lblCPFUsuario.Location = new System.Drawing.Point(3, 58);
            lblCPFUsuario.Name = "lblCPFUsuario";
            lblCPFUsuario.Size = new System.Drawing.Size(41, 15);
            lblCPFUsuario.TabIndex = 1;
            lblCPFUsuario.Text = "label2";
            lblCPFUsuario.Click += lblCPFUsuario_Click;
            // 
            // lblCategoriaUsuario
            // 
            lblCategoriaUsuario.AutoSize = true;
            lblCategoriaUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            lblCategoriaUsuario.Location = new System.Drawing.Point(3, 87);
            lblCategoriaUsuario.Name = "lblCategoriaUsuario";
            lblCategoriaUsuario.Size = new System.Drawing.Size(41, 15);
            lblCategoriaUsuario.TabIndex = 2;
            lblCategoriaUsuario.Text = "label3";
            // 
            // lblModeloCarro
            // 
            lblModeloCarro.AutoSize = true;
            lblModeloCarro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblModeloCarro.Location = new System.Drawing.Point(191, 30);
            lblModeloCarro.Name = "lblModeloCarro";
            lblModeloCarro.Size = new System.Drawing.Size(41, 15);
            lblModeloCarro.TabIndex = 3;
            lblModeloCarro.Text = "label1";
            // 
            // lblPlacaCarro
            // 
            lblPlacaCarro.AutoSize = true;
            lblPlacaCarro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            lblPlacaCarro.Location = new System.Drawing.Point(191, 58);
            lblPlacaCarro.Name = "lblPlacaCarro";
            lblPlacaCarro.Size = new System.Drawing.Size(41, 15);
            lblPlacaCarro.TabIndex = 4;
            lblPlacaCarro.Text = "label2";
            // 
            // lblCorCarro
            // 
            lblCorCarro.AutoSize = true;
            lblCorCarro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            lblCorCarro.Location = new System.Drawing.Point(191, 87);
            lblCorCarro.Name = "lblCorCarro";
            lblCorCarro.Size = new System.Drawing.Size(41, 15);
            lblCorCarro.TabIndex = 5;
            lblCorCarro.Text = "label3";
            // 
            // CaixadeCadastros
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(lblCorCarro);
            Controls.Add(lblPlacaCarro);
            Controls.Add(lblModeloCarro);
            Controls.Add(lblCategoriaUsuario);
            Controls.Add(lblCPFUsuario);
            Controls.Add(lblNomeUsuario);
            Name = "CaixadeCadastros";
            Size = new System.Drawing.Size(330, 119);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Label lblNomeUsuario;
        public System.Windows.Forms.Label lblCPFUsuario;
        public System.Windows.Forms.Label lblCategoriaUsuario;
        public System.Windows.Forms.Label lblModeloCarro;
        public System.Windows.Forms.Label lblPlacaCarro;
        public System.Windows.Forms.Label lblCorCarro;
    }
}
