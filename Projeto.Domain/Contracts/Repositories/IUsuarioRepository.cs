using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario GetByLogin();
        Usuario GetByLoginAndPassword(string login, string password);
    }
}
