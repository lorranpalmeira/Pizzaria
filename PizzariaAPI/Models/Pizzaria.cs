using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class Pizzaria : Endereco
    {

        public int IdPizzaria { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string NomeFantasia { get; set; }

        [Required]
        public string Cnpj { get; set; }

        public bool Ativo { get; set; }

        public DateTime UltimoLogin { get; set; }
    }
}
