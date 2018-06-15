using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Controllers;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PizzariaTestes.Login
{
    public class LoginTestes
    {


        [Fact]
        public async Task LoginTesteSucessoAsync() {

            var login = new LoginController();

            IActionResult actionResult = await login.Login(new Usuario { Login = "lorran", Senha = "123" });

            Assert.NotNull(actionResult);

            OkObjectResult result = actionResult as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200,result.StatusCode);

        }

        [Fact]
        public async Task LoginTesteErro() {
            var login = new LoginController();

            IActionResult actionResult = await login.Login(new Usuario { Login="lorran",Senha="12345"});

            Assert.NotNull(actionResult);

            var result = actionResult as BadRequestObjectResult;

            Assert.NotNull(result);
            Assert.Equal(400,result.StatusCode);

        }

    }
}
