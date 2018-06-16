using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Models
{
    public class Endereco
    {
        public int IdEndereco { get; set; }

        // Pizzaria ou Cliente
        public string Tipo { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        public string Complemento { get; set; }

        public string PontoReferencia { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Pais { get; set; }

        public string Cep { get; set; }
    }
}
