using AutoMovelShop.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMovelShop.DataBase
{
    public class DBcars : DbContext
    {
        public DBcars() : base("DbAuto") { }


        public DbSet<Carro> Carros { get; set; }


    }
}
