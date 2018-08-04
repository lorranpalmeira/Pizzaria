using Microsoft.Extensions.Configuration;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.DAO
{
    public class ClienteDAO
    {
        private IConfiguration _config;

        public ClienteDAO(IConfiguration configuration)
        {
            _config = configuration;
        }

        public void CadastroCliente(Cliente cliente) {

          
        }
    }
}
