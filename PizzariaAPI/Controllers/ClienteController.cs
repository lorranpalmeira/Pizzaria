using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Models;

namespace PizzariaAPI.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [Route("CadastroCliente")]
        public async Task<IActionResult> CadastroCliente( [FromBody] Cliente cliente) {

            if (ModelState.IsValid) {
                
                return Ok("Ok");
            }
            else
            {
                return BadRequest(cliente);
            }


           
        }
    }
}