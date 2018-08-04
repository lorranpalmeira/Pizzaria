using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Models;

namespace PizzariaAPI.Controllers
{

    [Authorize(Policy = "UsuarioAPI")]
    [Route("api/[controller]")]
    public class PizzariaController : Controller
    {

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
            var pizzarias = listaPizzaria.ToList();
            return Ok(pizzarias);
        }
    }
}