using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Controllers;
using PizzariaAPI.Models;
using System.Threading.Tasks;
using Xunit;

namespace PizzariaTestes.Clientes
{
    public class ClienteTestes
    {

        [Fact]
        public async Task TesteCadastroClienteSucesso()
        {
            // Arrange
            var controller = new ClienteController();

            var cliente = new Cliente {
                Nome="Joao",Telefone="33333333"
            };

            // Act
            IActionResult actionResult = await controller.CadastroCliente(cliente);

            // Assert
            Assert.NotNull(actionResult);
            //CreatedResult result = actionResult as CreatedResult;
            var result = actionResult as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
        }

        /*
        [Fact]
        public async Task TesteCadastroClienteErro()
        {
            // Arrange
            var controller = new ClienteController();

            var cliente = new Cliente { Telefone = "333", Nome = null };
           
            
            IActionResult actionResult = await controller.CadastroCliente(cliente);

            
            // Assert
            Assert.NotNull(actionResult);
            var result = actionResult as ObjectResult; //OkObjectResult;

            Assert.NotNull(result);
            Assert.NotEqual(200, result.StatusCode);
        }
        */
        


    }


}
