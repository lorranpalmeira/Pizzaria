using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Models;

namespace PizzariaAPI.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] Usuario usuario)
        {

            if (usuario.Login=="lorran" && usuario.Senha=="123")
            {

                return Ok("Autenticado");
            }
            else
            {
                return BadRequest("Login ou senha Errado");
            }

        }
    }
}