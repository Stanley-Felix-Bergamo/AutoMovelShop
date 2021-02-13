using AutoMovelShop.Controller;
using AutoMovelShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AutoMovelShop.View
{
    public partial class frmCarro : Form
    {
        private CarroController Controller = new CarroController();
        private Carro x = new Carro();
        private string Endereco = String.Empty;
        byte[] imagemBytes = null;


        public frmCarro()
        {
            InitializeComponent();

        }



        private void LimparTela()
        {
            txtMarca.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            txtpreco.Text = string.Empty;
            txtAno.Text = string.Empty;
            txtColor.Text = string.Empty;
            ptbImagemAdicionada.Image = null;

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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            x.Modelo = txtMarca.Text;
            x.Placa = txtPlaca.Text;
            x.Preco = txtpreco.Text;
            x.Ano = txtAno.Text;
            x.Cor = txtColor.Text;
            x.ImagemCarro = imagemBytes;

            if (!ValidaCao())
                return;

            Controller.Salvar(x);

            MessageBox.Show("O Carro Foi Salvo", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparTela();
        }



        private void btnImporta_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Endereco = dialog.FileName.ToString();
                ptbImagemAdicionada.ImageLocation = Endereco;
               
                string caminhoCompletoImagem = Endereco;
                FileStream fs = new FileStream(caminhoCompletoImagem, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                imagemBytes = br.ReadBytes(1200000);

            }
        }





    }
}
