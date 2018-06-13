namespace PizzariaAPI.Models
{
    public class ItensCesta
    {
        public int Id_Cesta { get; set; }

        public int Id_Produto { get; set; }

        public string Nome_Produto { get; set; }

        public int Quantidade { get; set; }

        public double Valor_Unitario { get; set; }

        public double Valor_Total { get; set; }
    }
}