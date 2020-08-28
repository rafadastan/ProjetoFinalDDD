using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class ProfessorApplicationService : IProfessorApplicationService
    {
        private readonly IProfessorDomainService professorDomainService;

        public ProfessorApplicationService(IProfessorDomainService professorDomainService)
        {
            this.professorDomainService = professorDomainService;
        }

        public void Delete(int id)
        {
            var professor = professorDomainService.GetById(id);
            professorDomainService.Delete(professor);
        }

        public List<Professor> GetAll()
        {
            return professorDomainService.GetAll();
        }

        public Professor GetById(int id)
        {
            return professorDomainService.GetById(id);
        }

        public void Insert(ProfessorCadastroModel model)
        {
            var professor = new Professor();

            professor.Cpf = model.Cpf;
            professor.Nome = model.Nome;

            professorDomainService.Insert(professor);
        }

        public void Update(ProfessorEdicaoModel model)
        {
            var professor = new Professor();

            professor.IdProfessor = model.IdProfessor;
            professor.Cpf = model.Cpf;
            professor.Nome = model.Nome;

            professorDomainService.Update(professor);
        }
    }
}
