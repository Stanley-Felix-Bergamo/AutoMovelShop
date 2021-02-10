
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDadosCarro = new System.Windows.Forms.Panel();
            this.pnlDadosCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(199, 275);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(68, 28);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(71, 74);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(130, 74);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(216, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(130, 166);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(216, 20);
            this.txtplaca.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Placa";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(130, 119);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(216, 20);
            this.txtpreco.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço";
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(130, 215);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(216, 20);
            this.txtcor.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dados do Carro";
            // 
            // pnlDadosCarro
            // 
            this.pnlDadosCarro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlDadosCarro.Controls.Add(this.txtModelo);
            this.pnlDadosCarro.Controls.Add(this.label4);
            this.pnlDadosCarro.Controls.Add(this.btnSalvar);
            this.pnlDadosCarro.Controls.Add(this.txtcor);
            this.pnlDadosCarro.Controls.Add(this.lblMarca);
            this.pnlDadosCarro.Controls.Add(this.label3);
            this.pnlDadosCarro.Controls.Add(this.label1);
            this.pnlDadosCarro.Controls.Add(this.txtpreco);
            this.pnlDadosCarro.Controls.Add(this.txtplaca);
            this.pnlDadosCarro.Controls.Add(this.label2);
            this.pnlDadosCarro.Location = new System.Drawing.Point(253, 77);
            this.pnlDadosCarro.Name = "pnlDadosCarro";
            this.pnlDadosCarro.Size = new System.Drawing.Size(393, 323);
            this.pnlDadosCarro.TabIndex = 22;
            // 
            // frmCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(940, 547);
            this.Controls.Add(this.pnlDadosCarro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCarro";
            this.Text = "Cadastro de Carros";
            this.TopMost = true;
            this.pnlDadosCarro.ResumeLayout(false);
            this.pnlDadosCarro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtModelo;
        public System.Windows.Forms.TextBox txtplaca;
        public System.Windows.Forms.TextBox txtpreco;
        public System.Windows.Forms.TextBox txtcor;
        public System.Windows.Forms.Label lblMarca;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDadosCarro;
    }
}