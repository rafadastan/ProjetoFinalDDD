using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class ProfessorDomainService : BaseDomainService<Professor>, IProfessorDomainService
    {
        private readonly IProfessorRepository professorRepository;

        public ProfessorDomainService(IProfessorRepository professorRepository) : base(professorRepository)
        {
            this.professorRepository = professorRepository;
        }
    }
}
