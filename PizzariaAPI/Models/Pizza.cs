using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class Pizza
    {
        public Pizzaria Id_Pizzaria  { get; set; }

        public string Nome_Pizza { get; set; }

        public double Valor { get; set; }



    }
}
