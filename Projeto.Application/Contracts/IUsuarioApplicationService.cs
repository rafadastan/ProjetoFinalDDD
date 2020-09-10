using Projeto.Application.Models;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IUsuarioApplicationService
    {
        void Insert(UsuarioCadastroModel model);
        Usuario GetByLoginAndSenha(UsuarioAutenticacaoModel model);
    }
}
