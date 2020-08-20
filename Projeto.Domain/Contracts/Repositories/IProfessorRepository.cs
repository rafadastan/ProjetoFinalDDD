using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IProfessorRepository : IBaseRepository<Professor>
    {
        Professor GetByCpf(string cpf);
    }
}
