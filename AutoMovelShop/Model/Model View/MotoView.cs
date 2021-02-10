using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMovelShop.Model.Model_View
{
   public class MotoView
    {

       
        [Key]
        [Browsable(false)]
        public int CodMotoView { get; set; }

        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Preco { get; set; }
    }
}
