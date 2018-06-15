using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzariaAPI.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] string login, string senha)
        {

            if (login=="lorran" && senha=="123")
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