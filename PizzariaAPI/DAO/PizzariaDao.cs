using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using PizzariaAPI.Models;

namespace PizzariaAPI.DAO
{
    public class PizzariaDao
    {
        private  IConfiguration _config;

        public PizzariaDao(IConfiguration config)
        {
            _config = config;
        }


        public IEnumerable<Pizzaria> ListaTodasPizzaria(){
                using (SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("PizzariaDatabase")))
            {
                return  conexao.GetAll<Pizzaria>();
            }
        }



        
    }
}