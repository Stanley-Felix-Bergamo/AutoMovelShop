﻿using AutoMovelShop.Controller;
using AutoMovelShop.Model.Model_View;
using AutoMovelShop.View.Visualiza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMovelShop.View.Consulta
{
    public partial class frmConsultaCarro : Form
    {
       
        public frmConsultaCarro()
        {
            InitializeComponent();
          
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaCarro_Shown(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch
            {
                MessageBox.Show("Ops...", "Erro Ao Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar()
        {
            var ListaView = new List<CarroView>();
            var Controller = new CarroController();

            ListaView = Controller.Listando();
            Grid(ListaView);
        }


        private void Grid(List<CarroView> Lista)
        {

            dwgCarro.DataSource = true;
            dwgCarro.DataSource = Lista;

            dwgCarro.Columns[nameof(CarroView.Modelo)].DisplayIndex = 0;
            dwgCarro.Columns[nameof(CarroView.Modelo)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dwgCarro.Columns[nameof(CarroView.Cor)].DisplayIndex = 1;
            dwgCarro.Columns[nameof(CarroView.Cor)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dwgCarro.Columns[nameof(CarroView.Placa)].DisplayIndex = 2;
            dwgCarro.Columns[nameof(CarroView.Placa)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dwgCarro.Columns[nameof(CarroView.Ano)].DisplayIndex = 3;
            dwgCarro.Columns[nameof(CarroView.Ano)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dwgCarro.Columns[nameof(CarroView.Preco)].DisplayIndex = 4;
            dwgCarro.Columns[nameof(CarroView.Preco)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Seleciona = (CarroView)dwgCarro.CurrentRow.DataBoundItem;
            var x = new frmVisualizaCarro(Seleciona);
            x.ShowDialog();
        }
    }
}
