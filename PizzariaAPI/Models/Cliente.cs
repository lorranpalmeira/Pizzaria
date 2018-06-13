namespace PizzariaAPI.Models
{
    public class Cliente : Endereco
    {

        public int Id_Cliente { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        
    }
}
