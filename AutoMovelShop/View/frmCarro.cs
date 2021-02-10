using AutoMovelShop.Controller;
using AutoMovelShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMovelShop.View
{
    public partial class frmCarro : Form
    {
        CarroController Controller;
        public frmCarro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var x = new Carro();

            Controller = new CarroController();


            x.Modelo = txtcarro.Text;



            Controller.Salvar(x);



           
        }
    }
}
