﻿using FluentAssertions;
using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;
using Projeto.Application.Models;
using Projeto.Presentation.Api.Tests.Contexts;
using Projeto.Presentation.Api.Tests.Factories;
using Projeto.Presentation.Api.Tests.Utils;
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
        private readonly TestContext testContext;
        private readonly string endpoint;
        private readonly string createUserMessage;
        private readonly string errorLoginMessage;

        public UsuarioTest()
        {
            testContext = new TestContext();
            endpoint = "api/usuario";

            createUserMessage = "Usuário cadastrado com sucesso.";
            errorLoginMessage = "Erro. O login informado já encontra - se cadastrado.";
        }

        [Fact]
        public async Task Usuario_Post_ReturnsOk()
        {
            var request = ServicesUtil.CreateRequestContent(UsuarioFactory.CreateUsuario);

            var response = await testContext.Client.PostAsync(endpoint, request);

            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var message = ServicesUtil.ReadResponseMessage(response);
            message.Should().Be(createUserMessage);
        }

        [Fact]
        public async Task Usuario_Post_BadRequest()
        {
            var request = ServicesUtil.CreateRequestContent(UsuarioFactory.CreateUsuarioEmpty);

            var response = await testContext.Client.PostAsync(endpoint, request);

            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Usuario_Internal_Server_Error()
        {
            #region Status OK 200
          
            var request = ServicesUtil.CreateRequestContent(UsuarioFactory.CreateUsuario);

            var responseSuccess = await testContext.Client.PostAsync(endpoint, request);

            responseSuccess.StatusCode.Should().Be(HttpStatusCode.OK);

            #endregion

            #region Status Internal server error 500

            var messageSuccess = ServicesUtil.ReadResponseMessage(responseSuccess);

            messageSuccess.Should().Be(createUserMessage);

            var responseError = await testContext.Client.PostAsync(endpoint, request);

            responseError.StatusCode.Should().Be(HttpStatusCode.InternalServerError);

            var messageError = ServicesUtil.ReadResponseMessage(responseError);

            messageError.Should().Be(errorLoginMessage);

            #endregion
        }
    }
}
