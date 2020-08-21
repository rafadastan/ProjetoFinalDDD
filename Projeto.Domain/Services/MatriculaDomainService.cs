using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class MatriculaDomainService : BaseDomainService<Matricula>, IMatriculaDomainService
    {
        private readonly IMatriculaRepository matriculaRepository;

        public MatriculaDomainService(IMatriculaRepository matriculaRepository) : base(matriculaRepository)
        {
            this.matriculaRepository = matriculaRepository;
        }
    }
}
