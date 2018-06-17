namespace PizzariaAPI.Models
{
    public class ItensPedido
    {
        public int IdPedido { get; set; }

        public int IdPizzaria { get; set; }

        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public int Quantidade { get; set; }

        public double ValorUnitario { get; set; }

        public double ValorTotal { get; set; }
    }
}