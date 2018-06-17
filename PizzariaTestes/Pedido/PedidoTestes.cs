using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PizzariaTestes.Pedido
{
    public class PedidoTestes
    {


        [Fact]
        public async Task ListaProdutosTeste() {

            var pedido = new PedidoController();

            IActionResult actionResult = await pedido.Listaprodutos();

            Assert.NotNull(actionResult);

            var result = actionResult as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);

            

        }
    }
}
