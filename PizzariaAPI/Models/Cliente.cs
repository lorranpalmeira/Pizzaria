using System.ComponentModel.DataAnnotations;

namespace PizzariaAPI.Models
{
    public class Cliente : Endereco
    {

        public int IdCliente { get; set; }

        [Required]
        public int IdPizzaria { get; set; }

        [MinLength(3), Required(ErrorMessage ="Nome Requerido")]
        public string Nome { get; set; }

        [Required]
        public string SobreNome { get; set; }

        [Required]
        public string Telefone { get; set; }


        [Required]
        public string Email { get; set; }

        
    }
}
