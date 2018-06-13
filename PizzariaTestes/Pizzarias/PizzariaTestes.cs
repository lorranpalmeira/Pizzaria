using Microsoft.AspNetCore.Mvc;
using PizzariaAPI.Controllers;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace PizzariaTestes.Pizzarias
{
    public class PizzariaTestes
    {

        [Fact]
        public async Task TestGet()
        {
            // Arrange
            var controller = new PizzariaController();

            // Act
            IActionResult actionResult = await controller.Get();

            // Assert
            Assert.NotNull(actionResult);

            OkObjectResult result = actionResult as OkObjectResult;

            Assert.NotNull(result);

            List<string> messages = result.Value as List<string>;

            Assert.Equal(2, messages.Count);
            Assert.Equal("Pizzaria1", messages[0]);
            Assert.Equal("Pizzaria2", messages[1]);
        }

        [Fact]
        public async Task TestGetPizzaria()
        {
            // Arrange
            var controller = new PizzariaController();

            // Act
            IActionResult actionResult = await controller.GetPizzarias();

            // Assert
            Assert.NotNull(actionResult);
            //CreatedResult result = actionResult as CreatedResult;
            var result = actionResult as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async Task TestGet200()
        {
            // Arrange
            var controller = new PizzariaController();

            // Act
            IActionResult actionResult = await controller.Get();

            // Assert
            Assert.NotNull(actionResult);
            //CreatedResult result = actionResult as CreatedResult;
            var result = actionResult as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
        }

    }
}
