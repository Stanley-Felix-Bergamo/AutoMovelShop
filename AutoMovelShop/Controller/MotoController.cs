﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMovelShop.Controller
{
   public  class MotoController :DataBase.DBcars
    {
        private DataBase.DBcars Contexto;
        public MotoController() => Contexto = new DataBase.DBcars();

    }
}
