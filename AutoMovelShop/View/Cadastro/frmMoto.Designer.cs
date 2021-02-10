
namespace AutoMovelShop.View
{
    partial class frmMoto
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
            this.txtcor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDadosMoto = new System.Windows.Forms.Panel();
            this.pnlDadosMoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(95, 209);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(216, 20);
            this.txtcor.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cor";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(95, 113);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(216, 20);
            this.txtpreco.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Preço";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(95, 160);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(216, 20);
            this.txtplaca.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Placa";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(95, 68);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(216, 20);
            this.txtModelo.TabIndex = 12;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(36, 68);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(165, 269);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(68, 28);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Dados da Moto";
            // 
            // pnlDadosMoto
            // 
            this.pnlDadosMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlDadosMoto.Controls.Add(this.lblMarca);
            this.pnlDadosMoto.Controls.Add(this.label4);
            this.pnlDadosMoto.Controls.Add(this.btnSalvar);
            this.pnlDadosMoto.Controls.Add(this.txtcor);
            this.pnlDadosMoto.Controls.Add(this.txtModelo);
            this.pnlDadosMoto.Controls.Add(this.label3);
            this.pnlDadosMoto.Controls.Add(this.label1);
            this.pnlDadosMoto.Controls.Add(this.txtpreco);
            this.pnlDadosMoto.Controls.Add(this.txtplaca);
            this.pnlDadosMoto.Controls.Add(this.label2);
            this.pnlDadosMoto.Location = new System.Drawing.Point(253, 77);
            this.pnlDadosMoto.Name = "pnlDadosMoto";
            this.pnlDadosMoto.Size = new System.Drawing.Size(393, 323);
            this.pnlDadosMoto.TabIndex = 21;
            // 
            // frmMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(940, 547);
            this.Controls.Add(this.pnlDadosMoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMoto";
            this.pnlDadosMoto.ResumeLayout(false);
            this.pnlDadosMoto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox txtcor;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtpreco;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtplaca;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtModelo;
        public System.Windows.Forms.Label lblMarca;
        public System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDadosMoto;
    }
}