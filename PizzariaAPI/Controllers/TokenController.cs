using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Models;
using PizzariaAPI.ProviderJWT;

namespace PizzariaAPI.Controllers
{

    [Route("api/[controller]")]
    public class TokenController : Controller
    {

        [Route("CreateToken")]
        [AllowAnonymous]
        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> CreateToken([FromBody] Usuario usuario)
        {
            if (usuario.Login != "lorran" || usuario.Senha != "1234")
                return Unauthorized();

            var token = new TokenJWTBuilder()
                .AddSecurityKey(ProviderJWT.JwtSecurityKey.Create("Secret_Key-12345678"))
                .AddSubject(usuario.Login)
                .AddIssuer("Teste.Securiry.Bearer")
                .AddAudience("Teste.Securiry.Bearer")
                .AddClaim("UsuarioAPINumero", "1")
                .AddExpiry(5)
                .Builder();

            return Ok(token.value);
        }
        
    }
}