using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PizzariaAPI.DAO;
using PizzariaAPI.Models;

namespace PizzariaAPI.Controllers
{

    [Authorize(Policy = "UsuarioAPI")]
    [Route("api/[controller]")]
    public class PizzariaController : Controller
    {

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        
        
        private  IConfiguration _config;

        public PizzariaController(IConfiguration config)
        {
            _config = config;
        }
      
        public static List<Pizzaria> listaPizzaria = new List<Pizzaria>
        {
            new Pizzaria(){ IdPizzaria=01, Nome="1 Amigo" },
            new Pizzaria(){ IdPizzaria=02, Nome="2 Amigos" },
            new Pizzaria(){ IdPizzaria=03, Nome="3 Amigos" },
            new Pizzaria(){ IdPizzaria=04, Nome="4 Amigos" },
            new Pizzaria(){ IdPizzaria=02, Nome="5 Amigos" }
        };

        [Route("get")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<string> lista = new List<string>() { "Pizzaria1", "Pizzaria2" };
            return Ok(lista);
        }

        // "http://localhost:51830/api/Pizzaria/GetPizzarias"
        [Route("GetPizzarias")]
        [HttpGet]
        public async Task<IActionResult> GetPizzarias()
        { 
            using (SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("PizzariaDatabase")))
            {
                logger.Debug("Teste");
                logger.Fatal("Errrrrrrrrrrr");
                return Json(conexao.GetAll<Pizzaria>());
            }

           
            
        }
    }
}