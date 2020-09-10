using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class UsuarioApplicationService : IUsuarioApplicationService
    {
        private IUsuarioDomainService usuarioDomainService;

        public UsuarioApplicationService(IUsuarioDomainService usuarioDomainService)
        {
            this.usuarioDomainService = usuarioDomainService;
        }

        public Usuario GetByLoginAndSenha(UsuarioAutenticacaoModel model)
        {
            return usuarioDomainService
                    .GetByLoginAndSenha(model.Login, model.Senha);
        }

        public void Insert(UsuarioCadastroModel model)
        {
            var usuario = new Usuario();

            usuario.Nome = model.Nome;
            usuario.Login = model.Login;
            usuario.Senha = model.Senha;
            usuario.DataCriacao = DateTime.Now;
            usuarioDomainService.Insert(usuario);   
        }
    }
}
