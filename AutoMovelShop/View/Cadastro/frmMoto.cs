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
    public partial class frmMoto : Form
    {
        private MotoController controller;
        public frmMoto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            var x = new Moto();
            controller = new MotoController();


            x.Modelo = txtModelo.Text;
            x.Cor = txtcor.Text;
            x.Placa = txtplaca.Text;
            x.Preco = txtpreco.Text;

            if (!ValidaCao())
                return;

            controller.Salvar(x);

            MessageBox.Show("Salvo", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show( "Campo Modelo Está Vazio", "Campo Obrigatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtcor.Text))
            {
                MessageBox.Show("Campo Cor Está Vazio","Campo Obrigatorio",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtplaca.Text))
            {
                MessageBox.Show("Campo Placa Está Vazio", "Campo Obrigatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (string.IsNullOrEmpty(txtpreco.Text))
            {
                MessageBox.Show( "Campo Preço Está Vazio", "Campo Obrigatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }




    }
}
