using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly DataContext dataContext;

        public UsuarioRepository(DataContext dataContext) : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public Usuario GetByLogin()
        {
            throw new NotImplementedException();
        }

        public Usuario GetByLoginAndPassword(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
