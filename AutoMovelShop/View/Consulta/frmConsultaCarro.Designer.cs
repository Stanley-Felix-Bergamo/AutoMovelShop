
namespace AutoMovelShop.View.Consulta
{
    partial class frmConsultaCarro
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
            this.dwgCarro = new System.Windows.Forms.DataGridView();
            this.StripEdit = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dwgCarro)).BeginInit();
            this.StripEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dwgCarro
            // 
            this.dwgCarro.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dwgCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwgCarro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dwgCarro.Location = new System.Drawing.Point(0, 0);
            this.dwgCarro.Name = "dwgCarro";
            this.dwgCarro.Size = new System.Drawing.Size(801, 498);
            this.dwgCarro.TabIndex = 1;
            // 
            // StripEdit
            // 
            this.StripEdit.BackColor = System.Drawing.Color.LightBlue;
            this.StripEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.StripEdit.GripMargin = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.StripEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.apagarToolStripMenuItem});
            this.StripEdit.Location = new System.Drawing.Point(679, 0);
            this.StripEdit.Name = "StripEdit";
            this.StripEdit.Padding = new System.Windows.Forms.Padding(1, 2, 1, 5);
            this.StripEdit.Size = new System.Drawing.Size(122, 498);
            this.StripEdit.TabIndex = 2;
            this.StripEdit.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(117, 19);
            this.sairToolStripMenuItem.Text = "Voltar";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(117, 19);
            this.alterarToolStripMenuItem.Text = "Editar";
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(117, 19);
            this.apagarToolStripMenuItem.Text = "Apagar";
            // 
            // frmConsultaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 498);
            this.Controls.Add(this.StripEdit);
            this.Controls.Add(this.dwgCarro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaCarro";
            this.Shown += new System.EventHandler(this.frmConsultaCarro_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dwgCarro)).EndInit();
            this.StripEdit.ResumeLayout(false);
            this.StripEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dwgCarro;
        private System.Windows.Forms.MenuStrip StripEdit;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
    }
}