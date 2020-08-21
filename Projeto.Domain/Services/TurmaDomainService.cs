using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class TurmaDomainService : BaseDomainService<Turma>, ITurmaDomainService
    {
        private readonly ITurmaRepository turmaRepository;

        public TurmaDomainService(ITurmaRepository turmaRepository) : base(turmaRepository)
        {
            this.turmaRepository = turmaRepository;
        }
    }
}
