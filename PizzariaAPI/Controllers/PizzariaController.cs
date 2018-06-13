using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Models;

namespace PizzariaAPI.Controllers
{
    [Route("api/[controller]")]
    public class PizzariaController : Controller
    {

        public static List<Pizzaria> listaPizzaria = new List<Pizzaria>
        {
            new Pizzaria(){ Id_Pizzaria=01, Nome="1 Amigo" },
            new Pizzaria(){ Id_Pizzaria=02, Nome="2 Amigos" },
            new Pizzaria(){ Id_Pizzaria=03, Nome="3 Amigos" },
            new Pizzaria(){ Id_Pizzaria=04, Nome="4 Amigos" },
            new Pizzaria(){ Id_Pizzaria=02, Nome="5 Amigos" }
        };

        [Route("get")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<string> lista = new List<string>() { "Pizzaria1", "Pizzaria2" };
            return Ok(lista);
        }


        [Route("GetPizzarias")]
        [HttpGet]
        public async Task<IActionResult> GetPizzarias()
        {
            //List<string> pizzarias = new List<string>() { "Pizzaria1", "Pizzaria2" };

            var pizzarias = listaPizzaria.ToList();
            return Ok(pizzarias);
        }
    }
}