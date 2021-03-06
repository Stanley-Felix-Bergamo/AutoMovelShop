﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMovelShop.Model
{
    public class Carro
    {
        public void Updatate(Carro carro)
        {
            this.Modelo = carro.Modelo;
            this.Placa = carro.Placa;
            this.Preco = carro.Preco;
            this.Cor = carro.Cor;
            this.Ano = carro.Ano;
            this.ImagemCarro = carro.ImagemCarro;
        }
        [Key]
        public int CodCarro { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Ano { get; set; }
        public string Preco { get; set; }

        public string Cor { get; set; }


        [Browsable(false)]
        public byte[] ImagemCarro { get; set; }

    }
}
