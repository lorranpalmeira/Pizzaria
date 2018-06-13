using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class Pizzaria : Endereco
    {

        public int Id_Pizzaria { get; set; }

        public string Nome { get; set; }

        public string Nome_Fantasia { get; set; }

        public string Cnpj { get; set; }

        public bool Ativo { get; set; }
    }
}
