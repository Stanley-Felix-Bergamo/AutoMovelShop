
namespace AutoMovelShop
{
    partial class frmMenu
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.motoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carroToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.motoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(862, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carroToolStripMenuItem,
            this.motoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // carroToolStripMenuItem
            // 
            this.carroToolStripMenuItem.Name = "carroToolStripMenuItem";
            this.carroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carroToolStripMenuItem.Text = "Carro";
            this.carroToolStripMenuItem.Click += new System.EventHandler(this.carroToolStripMenuItem_Click);
            // 
            // motoToolStripMenuItem
            // 
            this.motoToolStripMenuItem.Name = "motoToolStripMenuItem";
            this.motoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.motoToolStripMenuItem.Text = "Moto";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carroToolStripMenuItem1,
            this.motoToolStripMenuItem1});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // carroToolStripMenuItem1
            // 
            this.carroToolStripMenuItem1.Name = "carroToolStripMenuItem1";
            this.carroToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.carroToolStripMenuItem1.Text = "Carro";
            // 
            // motoToolStripMenuItem1
            // 
            this.motoToolStripMenuItem1.Name = "motoToolStripMenuItem1";
            this.motoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.motoToolStripMenuItem1.Text = "Moto";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carroToolStripMenuItem2,
            this.motoToolStripMenuItem2});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // carroToolStripMenuItem2
            // 
            this.carroToolStripMenuItem2.Name = "carroToolStripMenuItem2";
            this.carroToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.carroToolStripMenuItem2.Text = "Carro";
            // 
            // motoToolStripMenuItem2
            // 
            this.motoToolStripMenuItem2.Name = "motoToolStripMenuItem2";
            this.motoToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.motoToolStripMenuItem2.Text = "Moto";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(862, 561);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.Menu;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem motoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carroToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem motoToolStripMenuItem2;
    }
}

