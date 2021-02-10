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


            x.Modelo = txtModelo.Text;
            x.Cor = txtcor.Text;
            x.Placa = txtplaca.Text;
            x.Preco = txtpreco.Text;

            if (!ValidaCao())
                return;

            Controller.Salvar(x);

            MessageBox.Show("Salvo", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparTela();

        }

        private void LimparTela()
        {

            txtModelo.Text = string.Empty;
            txtcor.Text = string.Empty; ;
            txtplaca.Text = string.Empty; ;
            txtpreco.Text = string.Empty; ;
        }


        private bool ValidaCao()
        {

            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                MessageBox.Show("Campo Obrigatorio", "Campo Modelo Está Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtcor.Text))
            {
                MessageBox.Show("Campo Obrigatorio", "Campo Cor Está Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtplaca.Text))
            {
                MessageBox.Show("Campo Obrigatorio", "Campo Placa Está Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (string.IsNullOrEmpty(txtpreco.Text))
            {
                MessageBox.Show("Campo Obrigatorio", "Campo Preço Está Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
