
namespace AutoMovelShop.View.Visualiza
{
    partial class frmVisualizaCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizaCarro));
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcbCarro = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.StripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // StripMenu
            // 
            this.StripMenu.BackColor = System.Drawing.Color.LightBlue;
            this.StripMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.StripMenu.GripMargin = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.StripMenu.Location = new System.Drawing.Point(879, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Padding = new System.Windows.Forms.Padding(1, 2, 1, 5);
            this.StripMenu.Size = new System.Drawing.Size(51, 566);
            this.StripMenu.TabIndex = 56;
            this.StripMenu.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 19);
            this.sairToolStripMenuItem.Text = "Voltar";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pcbCarro
            // 
            this.pcbCarro.BackColor = System.Drawing.Color.White;
            this.pcbCarro.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarro.Image")));
            this.pcbCarro.InitialImage = null;
            this.pcbCarro.Location = new System.Drawing.Point(242, 26);
            this.pcbCarro.Name = "pcbCarro";
            this.pcbCarro.Size = new System.Drawing.Size(433, 256);
            this.pcbCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCarro.TabIndex = 69;
            this.pcbCarro.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Placa";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(296, 381);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(379, 20);
            this.txtplaca.TabIndex = 60;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(296, 467);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(379, 20);
            this.txtAno.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Ano";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(296, 298);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(379, 20);
            this.txtMarca.TabIndex = 57;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(296, 340);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(379, 20);
            this.txtNome.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Marca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Nome";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Cor";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(296, 513);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(379, 20);
            this.txtPreco.TabIndex = 64;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(296, 422);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(379, 20);
            this.txtCor.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Preço";
            // 
            // frmVisualizaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(930, 566);
            this.Controls.Add(this.pcbCarro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.StripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVisualizaCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisualizaCarro";
            this.Shown += new System.EventHandler(this.frmVisualizaCarro_Shown);
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        public System.Windows.Forms.PictureBox pcbCarro;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtplaca;
        public System.Windows.Forms.TextBox txtAno;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtMarca;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtPreco;
        public System.Windows.Forms.TextBox txtCor;
        public System.Windows.Forms.Label label11;
    }
}