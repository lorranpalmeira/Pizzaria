using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Controllers;
using PizzariaAPI.Models;
using System.Threading.Tasks;
using Xunit;

namespace PizzariaTestes.Pedido
{
    public class PedidoTestes
    {

        private PedidoController _pedido;
        
        

        public PedidoTestes()
        {
            _pedido = new PedidoController();
        }


        [Fact]
        public async Task ListaProdutosTeste() {

            Cliente cliente = new Cliente { IdPizzaria=001 };

            IActionResult actionResult = await _pedido.Listaprodutos(cliente);

            Assert.NotNull(actionResult);

            var result = actionResult as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);

        }

        [Fact]
        public async Task CriaPedidoTeste()
        {
            PizzariaAPI.Models.Pedido ped = new PizzariaAPI.Models.Pedido();
            ItensPedido itens = new ItensPedido { IdPizzaria = 001 };
            

            IActionResult actionResult = await _pedido.CriaPedido(ped,itens);

            Assert.NotNull(actionResult);

            var result = actionResult as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);

        }

        [Fact]
        public async Task PedidoEmAbertoTeste()
        {
            
            Pizzaria pizzaria = new Pizzaria { IdPizzaria = 001 };


            IActionResult actionResult = await _pedido.PedidosEmAberto(pizzaria);

            Assert.NotNull(actionResult);

            var result = actionResult as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);

        }

    }
}
