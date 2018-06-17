using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class Produto
    {
        public int IdPizzaria  { get; set; }

        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public string Descricao { get; set; }

        public double Valor { get; set; }

        public string Foto { get; set; }



    }
}
