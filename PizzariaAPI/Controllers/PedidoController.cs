using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzariaAPI.Controllers
{

    [Route("api/[controller]")]
    public class PedidoController : Controller
    {

        [HttpGet]
        [Route("Listaprodutos")]
        public async Task<IActionResult> Listaprodutos()
        {


            return Ok("Test");
        }

    }
}