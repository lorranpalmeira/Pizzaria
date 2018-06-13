using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class Cesta
    {

        public int Id_Cesta { get; set; }

        public int Id_Pizzaria { get; set; }


        public IList<Produto> Produtos { get; set; }
    }
}
