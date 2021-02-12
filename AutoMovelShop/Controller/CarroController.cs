﻿using AutoMovelShop.Model;
using AutoMovelShop.Model.Model_View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMovelShop.Controller
{
    public class CarroController : DataBase.DBcars
    {

        private DataBase.DBcars Contexto;
        public CarroController() => Contexto = new DataBase.DBcars();

        public void Salvar(Carro x)
        {

            Contexto.Carros.Add(x);
            Contexto.SaveChanges();

        }



        public List<CarroView> Listando()
        {
            var List = Contexto.Carros.ToList().Select(obj => new CarroView()
            {
                CodCarroView = obj.CodCarro,
                Cor = obj.Cor,
                Ano = obj.Ano,
                Modelo = obj.Modelo,
                Nome = obj.Nome,
                Placa = obj.Placa,
                Preco = obj.Preco,
            }).ToList();

            return List;
        }

        public List<CarroView> BuscandoImagem()
        {
            var List = Contexto.Carros.ToList().Select(obj => new CarroView()
            {

                CodCarroView=obj.CodCarro,
                ImagemCarro=obj.ImagemCarro,

            }).ToList();
            return List;
        }
    }
}
