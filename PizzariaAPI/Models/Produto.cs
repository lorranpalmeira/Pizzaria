using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class Produto
    {
        public int Id_Pizzaria  { get; set; }

        public int Id_Produto { get; set; }

        public string Nome_Pizza { get; set; }

        public string Descricao { get; set; }

        public double Valor { get; set; }

        public string Foto { get; set; }



    }
}
