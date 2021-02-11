using AutoMovelShop.View;
using AutoMovelShop.View.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMovelShop
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = new frmCarro();
            CarregaFormulario(x,pnlPrincipal);
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        



        public static void CarregaFormulario(Form frm, Panel pnl)
        {
            try
            {
                pnl.Controls.Clear();

                frm.TopLevel = false;

                frm.Visible = true;

                frm.FormBorderStyle = FormBorderStyle.None;

                frm.Dock = DockStyle.Fill;


                pnl.Controls.Add(frm);
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void carroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var x = new frmConsultaCarro();
            CarregaFormulario(x, pnlPrincipal);
        }
    }
}
