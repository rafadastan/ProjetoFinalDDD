using Projeto.Domain;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        private readonly DataContext dataContext;

        public ProfessorRepository(DataContext dataContext) : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public Professor GetByCpf(string cpf)
        {
            return dataContext.Professor
                .FirstOrDefault(p => p.Cpf.Equals(cpf));
        }
    }
}
