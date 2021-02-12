
namespace AutoMovelShop.View
{
    partial class frmCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarro));
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptbImagemAdicionada = new System.Windows.Forms.PictureBox();
            this.btnImporta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagemAdicionada)).BeginInit();
            this.SuspendLayout();
            // 
            // StripMenu
            // 
            this.StripMenu.BackColor = System.Drawing.Color.LightBlue;
            this.StripMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.StripMenu.GripMargin = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.StripMenu.Location = new System.Drawing.Point(747, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Padding = new System.Windows.Forms.Padding(1, 2, 1, 5);
            this.StripMenu.Size = new System.Drawing.Size(51, 566);
            this.StripMenu.TabIndex = 57;
            this.StripMenu.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 19);
            this.sairToolStripMenuItem.Text = "Voltar";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ptbImagemAdicionada
            // 
            this.ptbImagemAdicionada.BackColor = System.Drawing.Color.White;
            this.ptbImagemAdicionada.Image = ((System.Drawing.Image)(resources.GetObject("ptbImagemAdicionada.Image")));
            this.ptbImagemAdicionada.InitialImage = null;
            this.ptbImagemAdicionada.Location = new System.Drawing.Point(340, 26);
            this.ptbImagemAdicionada.Name = "ptbImagemAdicionada";
            this.ptbImagemAdicionada.Size = new System.Drawing.Size(375, 235);
            this.ptbImagemAdicionada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImagemAdicionada.TabIndex = 72;
            this.ptbImagemAdicionada.TabStop = false;
            // 
            // btnImporta
            // 
            this.btnImporta.Location = new System.Drawing.Point(451, 267);
            this.btnImporta.Name = "btnImporta";
            this.btnImporta.Size = new System.Drawing.Size(141, 34);
            this.btnImporta.TabIndex = 71;
            this.btnImporta.Text = "Importar Imagem";
            this.btnImporta.UseVisualStyleBackColor = true;
            this.btnImporta.Click += new System.EventHandler(this.btnImporta_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(82, 109);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(216, 20);
            this.txtPlaca.TabIndex = 61;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(82, 195);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(216, 20);
            this.txtAno.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Ano";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(82, 26);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(216, 20);
            this.txtMarca.TabIndex = 58;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(280, 459);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(173, 38);
            this.btnSalvar.TabIndex = 67;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 20);
            this.txtNome.TabIndex = 59;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(25, 33);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 60;
            this.lblMarca.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Cor";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(82, 241);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(216, 20);
            this.txtpreco.TabIndex = 65;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(82, 150);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(216, 20);
            this.txtColor.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Preço";
            // 
            // frmCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(798, 566);
            this.Controls.Add(this.ptbImagemAdicionada);
            this.Controls.Add(this.btnImporta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Carros";
            this.TopMost = true;
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagemAdicionada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        public System.Windows.Forms.PictureBox ptbImagemAdicionada;
        private System.Windows.Forms.Button btnImporta;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtPlaca;
        public System.Windows.Forms.TextBox txtAno;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtMarca;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label lblMarca;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtpreco;
        public System.Windows.Forms.TextBox txtColor;
        public System.Windows.Forms.Label label2;
    }
}