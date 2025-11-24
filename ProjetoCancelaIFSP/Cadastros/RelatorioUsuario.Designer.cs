namespace CancelaIFSP.App.Cadastros
{
    partial class RelatorioUsuario
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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            btnDeletar = new CustomControls.RJControls.RJButton();
            btnEditar = new CustomControls.RJControls.RJButton();
            dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            tabPage2 = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(652, 470);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDeletar);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(dataGridViewConsulta);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(644, 442);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnDeletar.BackColor = System.Drawing.Color.Gray;
            btnDeletar.BackgroundColor = System.Drawing.Color.Gray;
            btnDeletar.BorderColor = System.Drawing.Color.Black;
            btnDeletar.BorderRadius = 5;
            btnDeletar.BorderSize = 1;
            btnDeletar.FlatAppearance.BorderSize = 0;
            btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDeletar.ForeColor = System.Drawing.Color.White;
            btnDeletar.Location = new System.Drawing.Point(450, 399);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new System.Drawing.Size(100, 40);
            btnDeletar.TabIndex = 5;
            btnDeletar.Text = "&DELETAR";
            btnDeletar.TextColor = System.Drawing.Color.White;
            btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnEditar.BackColor = System.Drawing.Color.FromArgb(57, 160, 72);
            btnEditar.BackgroundColor = System.Drawing.Color.FromArgb(57, 160, 72);
            btnEditar.BorderColor = System.Drawing.Color.FromArgb(0, 64, 0);
            btnEditar.BorderRadius = 5;
            btnEditar.BorderSize = 1;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEditar.ForeColor = System.Drawing.Color.White;
            btnEditar.Location = new System.Drawing.Point(556, 399);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(80, 40);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "&EDITAR";
            btnEditar.TextColor = System.Drawing.Color.White;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewConsulta
            // 
            dataGridViewConsulta.AllowUserToAddRows = false;
            dataGridViewConsulta.AllowUserToDeleteRows = false;
            dataGridViewConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewConsulta.BackgroundColor = System.Drawing.Color.FromArgb(192, 255, 192);
            dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsulta.Location = new System.Drawing.Point(8, 6);
            dataGridViewConsulta.MultiSelect = false;
            dataGridViewConsulta.Name = "dataGridViewConsulta";
            dataGridViewConsulta.ReadOnly = true;
            dataGridViewConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewConsulta.Size = new System.Drawing.Size(628, 387);
            dataGridViewConsulta.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(644, 442);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // RelatorioUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(652, 470);
            Controls.Add(tabControl1);
            Name = "RelatorioUsuario";
            Text = "Relatorio Usuário";
            Load += RelatorioUsuario_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        protected System.Windows.Forms.DataGridView dataGridViewConsulta;
        private CustomControls.RJControls.RJButton btnDeletar;
        private CustomControls.RJControls.RJButton btnEditar;
    }
}