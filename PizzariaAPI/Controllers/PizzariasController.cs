using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzariaAPI.Controllers
{
    [Route("api/[controller]")]
    public class PizzariasController : Controller
    {
        [Route("get")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<string> pizzarias = new List<string>() { "Pizzaria1", "Pizzaria2" };
            return Ok(pizzarias);
        }
    }
}