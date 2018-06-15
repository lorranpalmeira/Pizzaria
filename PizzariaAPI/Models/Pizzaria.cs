using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class Pizzaria : Endereco
    {

        public int IdPizzaria { get; set; }

        public string Nome { get; set; }

        public string NomeFantasia { get; set; }

        public string Cnpj { get; set; }

        public bool Ativo { get; set; }
    }
}
