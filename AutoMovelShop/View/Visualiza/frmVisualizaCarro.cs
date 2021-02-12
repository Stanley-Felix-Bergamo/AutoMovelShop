using AutoMovelShop.Controller;
using AutoMovelShop.Model.Model_View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMovelShop.View.Visualiza
{
    public partial class frmVisualizaCarro : Form
    {
        public CarroController controller = new CarroController();

        public List<CarroView> View = new List<CarroView>();
        public frmVisualizaCarro()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbCarro_Click(object sender, EventArgs e)
        {

            View = controller.BuscandoImagem();

        }
    }
}
