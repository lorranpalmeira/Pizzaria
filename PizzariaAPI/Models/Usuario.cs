using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class Usuario
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Senha { get; set; }

        public string Role { get; set; }

        public int IdPizzaria { get; set; }
    }
}
