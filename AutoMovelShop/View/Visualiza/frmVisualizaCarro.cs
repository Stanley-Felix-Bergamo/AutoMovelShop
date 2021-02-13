using AutoMovelShop.Controller;
using AutoMovelShop.Model;
using AutoMovelShop.Model.Model_View;
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

namespace AutoMovelShop.View.Visualiza
{
    public partial class frmVisualizaCarro : Form
    {
        private CarroView _view = new CarroView();
        public CarroController controller = new CarroController();
        private Carro Carro = new Carro();
        public frmVisualizaCarro(CarroView x) : this()
        {
            this._view = x;
        }

        public frmVisualizaCarro()
        {
            InitializeComponent();
        }
        public void frmVisualizaCarro_Shown(object sender, EventArgs e)
        {
            Carro = (new CarroController()).BuscarDados(_view);
            
            CoverteImgagem(Carro.ImagemCarro);
            txtMarca.Text = Carro.Modelo;
            txtAno.Text = Carro.Ano;
            txtCor.Text = Carro.Cor;
            txtplaca.Text = Carro.Placa;
            txtPreco.Text = Carro.Preco;
        }
        public Image CoverteImgagem(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            pcbCarro.Image = returnImage;
            return returnImage;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
