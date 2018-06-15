namespace PizzariaAPI.Models
{
    public class ItensCesta
    {
        public int IdCesta { get; set; }

        public int IdPizzaria { get; set; }

        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public int Quantidade { get; set; }

        public double ValorUnitario { get; set; }

        public double ValorTotal { get; set; }
    }
}