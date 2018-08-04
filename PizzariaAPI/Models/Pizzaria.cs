using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace PizzariaAPI.Models
{

    [System.ComponentModel.DataAnnotations.Schema.Table("dbo.Pizzaria")]
    public class Pizzaria : Endereco
    {

        [ExplicitKey]
        public int IdPizzaria { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string NomeFantasia { get; set; }

        [Required]
        public string Cnpj { get; set; }

        public bool Ativo { get; set; }

        
    }
}
