using AutoMovelShop.Model;
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
        public CarroController()=> Contexto = new DataBase.DBcars();

        public void Salvar(Carro x)
        {

            Contexto.Carros.Add(x);
            Contexto.SaveChanges();

        }
    }
}
