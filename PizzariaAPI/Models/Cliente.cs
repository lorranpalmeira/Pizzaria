using System.ComponentModel.DataAnnotations;

namespace PizzariaAPI.Models
{
    public class Cliente : Endereco
    {

        public int IdCliente { get; set; }

        
        public int IdPizzaria { get; set; }

        [MinLength(3), Required(ErrorMessage ="Nome Requerido")]
        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        
    }
}
