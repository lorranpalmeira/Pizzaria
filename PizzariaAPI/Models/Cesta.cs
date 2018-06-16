using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class Cesta
    {

        public int IdCesta { get; set; }

        public int IdPizzaria { get; set; }

        public int IdCliente { get; set; }

        public Status Status { get; set; }

        public DateTime DataPedido { get; set; }

        public decimal ValorTotal { get; set; }

        public IList<ItensCesta> ItensCesta { get; set; }
    }
}
