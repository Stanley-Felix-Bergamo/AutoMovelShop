using AutoMovelShop.View;
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
            x.ShowDialog();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void motoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = new frmMoto();
            x.ShowDialog();
        }
    }
}
