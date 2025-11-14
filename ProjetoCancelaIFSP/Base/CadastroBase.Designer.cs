namespace CancelaIFSP.App.Base
{
    partial class CadastroBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBase));
            imageList1 = new System.Windows.Forms.ImageList(components);
            panel1 = new System.Windows.Forms.Panel();
            btnSalvar = new CustomControls.RJControls.RJButton();
            btnCancelar = new CustomControls.RJControls.RJButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 270);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(494, 57);
            panel1.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnSalvar.BackColor = System.Drawing.Color.FromArgb(57, 160, 72);
            btnSalvar.BackgroundColor = System.Drawing.Color.FromArgb(57, 160, 72);
            btnSalvar.BorderColor = System.Drawing.Color.FromArgb(0, 64, 0);
            btnSalvar.BorderRadius = 5;
            btnSalvar.BorderSize = 1;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = System.Drawing.Color.White;
            btnSalvar.Location = new System.Drawing.Point(403, 12);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(80, 40);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "&SALVAR";
            btnSalvar.TextColor = System.Drawing.Color.White;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnCancelar.BackColor = System.Drawing.Color.Gray;
            btnCancelar.BackgroundColor = System.Drawing.Color.Gray;
            btnCancelar.BorderColor = System.Drawing.Color.Black;
            btnCancelar.BorderRadius = 5;
            btnCancelar.BorderSize = 1;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = System.Drawing.Color.White;
            btnCancelar.Location = new System.Drawing.Point(297, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "&CANCELAR";
            btnCancelar.TextColor = System.Drawing.Color.White;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Menu;
            ClientSize = new System.Drawing.Size(494, 327);
            Controls.Add(panel1);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Name = "CadastroBase";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CadastroBase";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton btnSalvar;
        private CustomControls.RJControls.RJButton btnCancelar;
    }
}