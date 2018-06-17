using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Controllers;
using PizzariaAPI.Models;
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

            Cliente cliente = new Cliente { IdPizzaria=001 };

            IActionResult actionResult = await pedido.Listaprodutos(cliente);

            Assert.NotNull(actionResult);

            var result = actionResult as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);

            

        }
    }
}
