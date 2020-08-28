using Projeto.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Contracts
{
    public interface IUnitOfWork
    {
        IAlunoRepository AlunoRepository { get; }
        IMatriculaRepository MatriculaRepository { get; }
        IProfessorRepository ProfessorRepository { get; }
        ITurmaRepository TurmaRepository { get; }
        void SaveChanges();
    }
}
