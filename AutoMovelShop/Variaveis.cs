using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMovelShop
{
    public class Variaveis
    {
        private static Variaveis _valores;
        private int _operacao;
        public static Variaveis Valores
        {
            get
            {
                if (_valores == null)
                {
                    _valores = new Variaveis();
                }
                return _valores;
            }

        }

        public int Operacao
        {
            get { return _operacao; }
            set { _operacao = value; }
        }


    }
}
