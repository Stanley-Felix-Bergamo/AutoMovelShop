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



        private void LimparTela()
        {
            txtNome.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            txtpreco.Text = string.Empty;
            txtAno.Text = string.Empty;
            txtColor.Text = string.Empty;

        }


        private bool ValidaCao()
        {

            if (string.IsNullOrEmpty(txtAno.Text))
            {
                MessageBox.Show("Campo Ano Está Vazio", "Campo Obrigatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                MessageBox.Show("Campo Placa Está Vazio", "Campo Obrigatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                MessageBox.Show("Campo Marca Está Vazio", "Campo Obrigatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Campo Cor Está Vazio", "Campo Obrigatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtColor.Text))
            {
                MessageBox.Show("Campo Placa Está Vazio", "Campo Obrigatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (string.IsNullOrEmpty(txtpreco.Text))
            {
                MessageBox.Show("Campo Preço Está Vazio", "Campo Obrigatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            var x = new Carro();
            Controller = new CarroController();

            x.Nome = txtNome.Text;
            x.Modelo = txtMarca.Text;
            x.Placa = txtPlaca.Text;
            x.Preco = txtpreco.Text;
            x.Ano = txtAno.Text;
            x.Cor = txtColor.Text;


            if (!ValidaCao())
                return;

            Controller.Salvar(x);

            MessageBox.Show("Salvo", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparTela();
        }
    }
}
