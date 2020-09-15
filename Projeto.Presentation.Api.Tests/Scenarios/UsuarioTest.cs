using FluentAssertions;
using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;
using Projeto.Application.Models;
using Projeto.Presentation.Api.Tests.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Projeto.Presentation.Api.Tests.Scenarios
{
    public class UsuarioTest
    {
        private TestContext testContext;
        private string endpoint;

        public UsuarioTest()
        {
            testContext = new TestContext();
            endpoint = "api/usuario";
        }

        [Fact]
        public async Task Usuario_Post_ReturnsOk()
        {
            var random = new Random();
            var login = "raphael" + random.Next(999999);

            var model = new UsuarioCadastroModel
            {
                Nome = "Raphael Augusto Pereira de Assis",
                Login = login,
                Senha = "adminadmin",
                SenhaConfirmacao = "adminadmin"
            };

            var json = JsonConvert.SerializeObject(model);
            var request = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await testContext.Client.PostAsync(endpoint, request);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Usuario_Post_BadRequest()
        {
            var model = new UsuarioCadastroModel
            {
                Nome = string.Empty,
                Login = string.Empty,
                Senha = string.Empty,
                SenhaConfirmacao = string.Empty
            };

            var json = JsonConvert.SerializeObject(model);
            var request = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await testContext.Client.PostAsync(endpoint, request);

            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}
