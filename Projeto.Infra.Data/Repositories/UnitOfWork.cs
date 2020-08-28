using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Contexts;
using Projeto.Infra.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext dataContext;
        public IAlunoRepository AlunoRepository
        {
            get
            {
                return new AlunoRepository(dataContext);
            }
        }


        public IMatriculaRepository MatriculaRepository
        {
            get
            {
                return new MatriculaRepository(dataContext);
            }
        } 

        public IProfessorRepository ProfessorRepository
        {
            get
            {
                return new ProfessorRepository(dataContext);
            }
        }

        public ITurmaRepository TurmaRepository
        {
            get
            {
                return new TurmaRepository(dataContext);
            }
        }


        public void SaveChanges()
        {
            dataContext.SaveChanges();
        }
    }
}
