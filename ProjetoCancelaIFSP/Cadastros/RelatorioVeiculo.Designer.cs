using System;
using System.Windows.Forms;

namespace CancelaIFSP.App.Cadastros
{
    partial class RelatorioVeiculo
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
            dataGridViewConsulta = new DataGridView();
            btnEditar = new CustomControls.RJControls.RJButton();
            btnDeletar = new CustomControls.RJControls.RJButton();
            tabControl = new TabControl();
            tabPageRelatorio = new TabPage();
            tabPageCadastro = new TabPage();
            panel1 = new Panel();
            btnSalvar2 = new CustomControls.RJControls.RJButton();
            btnCancelar2 = new CustomControls.RJControls.RJButton();
            btnSalvar = new CustomControls.RJControls.RJButton();
            btnCancelar = new CustomControls.RJControls.RJButton();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAno = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPlaca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCor = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtModelo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).BeginInit();
            tabControl.SuspendLayout();
            tabPageRelatorio.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewConsulta
            // 
            dataGridViewConsulta.AllowUserToAddRows = false;
            dataGridViewConsulta.AllowUserToDeleteRows = false;
            dataGridViewConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewConsulta.BackgroundColor = System.Drawing.Color.FromArgb(192, 255, 192);
            dataGridViewConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsulta.Location = new System.Drawing.Point(8, 6);
            dataGridViewConsulta.MultiSelect = false;
            dataGridViewConsulta.Name = "dataGridViewConsulta";
            dataGridViewConsulta.ReadOnly = true;
            dataGridViewConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewConsulta.Size = new System.Drawing.Size(619, 374);
            dataGridViewConsulta.TabIndex = 0;
            dataGridViewConsulta.CellContentClick += dataGridViewConsulta_CellDoubleClick;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.BackColor = System.Drawing.Color.FromArgb(57, 160, 72);
            btnEditar.BackgroundColor = System.Drawing.Color.FromArgb(57, 160, 72);
            btnEditar.BorderColor = System.Drawing.Color.FromArgb(0, 64, 0);
            btnEditar.BorderRadius = 5;
            btnEditar.BorderSize = 1;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEditar.ForeColor = System.Drawing.Color.White;
            btnEditar.Location = new System.Drawing.Point(547, 386);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(80, 40);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "&EDITAR";
            btnEditar.TextColor = System.Drawing.Color.White;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeletar.BackColor = System.Drawing.Color.Gray;
            btnDeletar.BackgroundColor = System.Drawing.Color.Gray;
            btnDeletar.BorderColor = System.Drawing.Color.Black;
            btnDeletar.BorderRadius = 5;
            btnDeletar.BorderSize = 1;
            btnDeletar.FlatAppearance.BorderSize = 0;
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDeletar.ForeColor = System.Drawing.Color.White;
            btnDeletar.Location = new System.Drawing.Point(441, 386);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new System.Drawing.Size(100, 40);
            btnDeletar.TabIndex = 3;
            btnDeletar.Text = "&DELETAR";
            btnDeletar.TextColor = System.Drawing.Color.White;
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // tabControl
            // 
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.Controls.Add(tabPageRelatorio);
            tabControl.Controls.Add(tabPageCadastro);
            tabControl.Dock = DockStyle.Fill;
            tabControl.ItemSize = new System.Drawing.Size(0, 1);
            tabControl.Location = new System.Drawing.Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(643, 438);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 5;
            // 
            // tabPageRelatorio
            // 
            tabPageRelatorio.Controls.Add(dataGridViewConsulta);
            tabPageRelatorio.Controls.Add(btnDeletar);
            tabPageRelatorio.Controls.Add(btnEditar);
            tabPageRelatorio.Location = new System.Drawing.Point(4, 5);
            tabPageRelatorio.Name = "tabPageRelatorio";
            tabPageRelatorio.Padding = new Padding(3);
            tabPageRelatorio.Size = new System.Drawing.Size(635, 429);
            tabPageRelatorio.TabIndex = 0;
            tabPageRelatorio.Text = "tabPage1";
            tabPageRelatorio.UseVisualStyleBackColor = true;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(panel1);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtAno);
            tabPageCadastro.Controls.Add(txtPlaca);
            tabPageCadastro.Controls.Add(txtCor);
            tabPageCadastro.Controls.Add(txtModelo);
            tabPageCadastro.Location = new System.Drawing.Point(4, 5);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new System.Drawing.Size(459, 424);
            tabPageCadastro.TabIndex = 1;
            tabPageCadastro.Text = "tabPage2";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalvar2);
            panel1.Controls.Add(btnCancelar2);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(3, 364);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(453, 57);
            panel1.TabIndex = 11;
            // 
            // btnSalvar2
            // 
            btnSalvar2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar2.BackColor = System.Drawing.Color.FromArgb(57, 160, 72);
            btnSalvar2.BackgroundColor = System.Drawing.Color.FromArgb(57, 160, 72);
            btnSalvar2.BorderColor = System.Drawing.Color.FromArgb(0, 64, 0);
            btnSalvar2.BorderRadius = 5;
            btnSalvar2.BorderSize = 1;
            btnSalvar2.FlatAppearance.BorderSize = 0;
            btnSalvar2.FlatStyle = FlatStyle.Flat;
            btnSalvar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSalvar2.ForeColor = System.Drawing.Color.White;
            btnSalvar2.Location = new System.Drawing.Point(368, 17);
            btnSalvar2.Name = "btnSalvar2";
            btnSalvar2.Size = new System.Drawing.Size(80, 40);
            btnSalvar2.TabIndex = 2;
            btnSalvar2.Text = "&SALVAR";
            btnSalvar2.TextColor = System.Drawing.Color.White;
            btnSalvar2.UseVisualStyleBackColor = false;
            btnSalvar2.Click += btnSalvar2_Click_1;
            // 
            // btnCancelar2
            // 
            btnCancelar2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar2.BackColor = System.Drawing.Color.Gray;
            btnCancelar2.BackgroundColor = System.Drawing.Color.Gray;
            btnCancelar2.BorderColor = System.Drawing.Color.Black;
            btnCancelar2.BorderRadius = 5;
            btnCancelar2.BorderSize = 1;
            btnCancelar2.FlatAppearance.BorderSize = 0;
            btnCancelar2.FlatStyle = FlatStyle.Flat;
            btnCancelar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancelar2.ForeColor = System.Drawing.Color.White;
            btnCancelar2.Location = new System.Drawing.Point(262, 17);
            btnCancelar2.Name = "btnCancelar2";
            btnCancelar2.Size = new System.Drawing.Size(100, 40);
            btnCancelar2.TabIndex = 3;
            btnCancelar2.Text = "&CANCELAR";
            btnCancelar2.TextColor = System.Drawing.Color.White;
            btnCancelar2.UseVisualStyleBackColor = false;
            btnCancelar2.Click += btnCancelar2_Click_1;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.BackColor = System.Drawing.Color.FromArgb(57, 160, 72);
            btnSalvar.BackgroundColor = System.Drawing.Color.FromArgb(57, 160, 72);
            btnSalvar.BorderColor = System.Drawing.Color.FromArgb(0, 64, 0);
            btnSalvar.BorderRadius = 5;
            btnSalvar.BorderSize = 1;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = System.Drawing.Color.White;
            btnSalvar.Location = new System.Drawing.Point(656, -31);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(80, 40);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "&SALVAR";
            btnSalvar.TextColor = System.Drawing.Color.White;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = System.Drawing.Color.Gray;
            btnCancelar.BackgroundColor = System.Drawing.Color.Gray;
            btnCancelar.BorderColor = System.Drawing.Color.Black;
            btnCancelar.BorderRadius = 5;
            btnCancelar.BorderSize = 1;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = System.Drawing.Color.White;
            btnCancelar.Location = new System.Drawing.Point(550, -31);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "&CANCELAR";
            btnCancelar.TextColor = System.Drawing.Color.White;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new System.Drawing.Point(204, 166);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new System.Drawing.Size(50, 48);
            txtId.TabIndex = 10;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtAno
            // 
            txtAno.AnimateReadOnly = false;
            txtAno.AutoCompleteMode = AutoCompleteMode.None;
            txtAno.AutoCompleteSource = AutoCompleteSource.None;
            txtAno.BackgroundImageLayout = ImageLayout.None;
            txtAno.CharacterCasing = CharacterCasing.Normal;
            txtAno.Depth = 0;
            txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtAno.HideSelection = true;
            txtAno.Hint = "Ano";
            txtAno.LeadingIcon = null;
            txtAno.Location = new System.Drawing.Point(20, 246);
            txtAno.MaxLength = 32767;
            txtAno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAno.Name = "txtAno";
            txtAno.PasswordChar = '\0';
            txtAno.PrefixSuffixText = null;
            txtAno.ReadOnly = false;
            txtAno.RightToLeft = RightToLeft.No;
            txtAno.SelectedText = "";
            txtAno.SelectionLength = 0;
            txtAno.SelectionStart = 0;
            txtAno.ShortcutsEnabled = true;
            txtAno.Size = new System.Drawing.Size(234, 48);
            txtAno.TabIndex = 9;
            txtAno.TabStop = false;
            txtAno.TextAlign = HorizontalAlignment.Left;
            txtAno.TrailingIcon = null;
            txtAno.UseSystemPasswordChar = false;
            // 
            // txtPlaca
            // 
            txtPlaca.AnimateReadOnly = false;
            txtPlaca.AutoCompleteMode = AutoCompleteMode.None;
            txtPlaca.AutoCompleteSource = AutoCompleteSource.None;
            txtPlaca.BackgroundImageLayout = ImageLayout.None;
            txtPlaca.CharacterCasing = CharacterCasing.Normal;
            txtPlaca.Depth = 0;
            txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtPlaca.HideSelection = true;
            txtPlaca.Hint = "Placa";
            txtPlaca.LeadingIcon = null;
            txtPlaca.Location = new System.Drawing.Point(20, 96);
            txtPlaca.MaxLength = 32767;
            txtPlaca.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.PasswordChar = '\0';
            txtPlaca.PrefixSuffixText = null;
            txtPlaca.ReadOnly = false;
            txtPlaca.RightToLeft = RightToLeft.No;
            txtPlaca.SelectedText = "";
            txtPlaca.SelectionLength = 0;
            txtPlaca.SelectionStart = 0;
            txtPlaca.ShortcutsEnabled = true;
            txtPlaca.Size = new System.Drawing.Size(234, 48);
            txtPlaca.TabIndex = 7;
            txtPlaca.TabStop = false;
            txtPlaca.TextAlign = HorizontalAlignment.Left;
            txtPlaca.TrailingIcon = null;
            txtPlaca.UseSystemPasswordChar = false;
            // 
            // txtCor
            // 
            txtCor.AnimateReadOnly = false;
            txtCor.AutoCompleteMode = AutoCompleteMode.None;
            txtCor.AutoCompleteSource = AutoCompleteSource.None;
            txtCor.BackgroundImageLayout = ImageLayout.None;
            txtCor.CharacterCasing = CharacterCasing.Normal;
            txtCor.Depth = 0;
            txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtCor.HideSelection = true;
            txtCor.Hint = "Cor";
            txtCor.LeadingIcon = null;
            txtCor.Location = new System.Drawing.Point(20, 166);
            txtCor.MaxLength = 32767;
            txtCor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCor.Name = "txtCor";
            txtCor.PasswordChar = '\0';
            txtCor.PrefixSuffixText = null;
            txtCor.ReadOnly = false;
            txtCor.RightToLeft = RightToLeft.No;
            txtCor.SelectedText = "";
            txtCor.SelectionLength = 0;
            txtCor.SelectionStart = 0;
            txtCor.ShortcutsEnabled = true;
            txtCor.Size = new System.Drawing.Size(178, 48);
            txtCor.TabIndex = 8;
            txtCor.TabStop = false;
            txtCor.TextAlign = HorizontalAlignment.Left;
            txtCor.TrailingIcon = null;
            txtCor.UseSystemPasswordChar = false;
            // 
            // txtModelo
            // 
            txtModelo.AnimateReadOnly = false;
            txtModelo.AutoCompleteMode = AutoCompleteMode.None;
            txtModelo.AutoCompleteSource = AutoCompleteSource.None;
            txtModelo.BackgroundImageLayout = ImageLayout.None;
            txtModelo.CharacterCasing = CharacterCasing.Normal;
            txtModelo.Depth = 0;
            txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtModelo.HideSelection = true;
            txtModelo.Hint = "Modelo do Veiculo";
            txtModelo.LeadingIcon = null;
            txtModelo.Location = new System.Drawing.Point(20, 26);
            txtModelo.MaxLength = 32767;
            txtModelo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtModelo.Name = "txtModelo";
            txtModelo.PasswordChar = '\0';
            txtModelo.PrefixSuffixText = null;
            txtModelo.ReadOnly = false;
            txtModelo.RightToLeft = RightToLeft.No;
            txtModelo.SelectedText = "";
            txtModelo.SelectionLength = 0;
            txtModelo.SelectionStart = 0;
            txtModelo.ShortcutsEnabled = true;
            txtModelo.Size = new System.Drawing.Size(234, 48);
            txtModelo.TabIndex = 6;
            txtModelo.TabStop = false;
            txtModelo.TextAlign = HorizontalAlignment.Left;
            txtModelo.TrailingIcon = null;
            txtModelo.UseSystemPasswordChar = false;
            // 
            // RelatorioVeiculo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(643, 438);
            Controls.Add(tabControl);
            Name = "RelatorioVeiculo";
            Text = "Relatorio";
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).EndInit();
            tabControl.ResumeLayout(false);
            tabPageRelatorio.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        protected System.Windows.Forms.DataGridView dataGridViewConsulta;
        private CustomControls.RJControls.RJButton btnEditar;
        private CustomControls.RJControls.RJButton btnDeletar;
        private TabControl tabControl;
        private TabPage tabPageRelatorio;
        private TabPage tabPageCadastro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAno;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPlaca;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCor;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtModelo;
        private Panel panel1;
        private CustomControls.RJControls.RJButton btnSalvar;
        private CustomControls.RJControls.RJButton btnCancelar;
        private CustomControls.RJControls.RJButton btnSalvar2;
        private CustomControls.RJControls.RJButton btnCancelar2;
    }
}