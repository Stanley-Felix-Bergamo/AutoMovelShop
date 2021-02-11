﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMovelShop.Model.Model_View
{
    public class CarroView
    {
        public CarroView()
        {

        }

        [Key]
        [Browsable(false)]
        public int CodCarroView { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Preco { get; set; }
        public string Ano { get; set; }
    }
}
