using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMovelShop.Model
{
    public class Moto
    {
        public void Updatate(Moto moto)
        {
            this.Modelo = moto.Modelo;
            this.Placa = moto.Placa;
            this.Preco = moto.Preco;
            this.Cor = moto.Cor;
        }
        [Key]
        public int CodMoto { get; set; }

        public string Modelo { get; set; }
        public string Placa { get; set; }

        public string Preco { get; set; }

        public string Cor { get; set; }


    }
}
