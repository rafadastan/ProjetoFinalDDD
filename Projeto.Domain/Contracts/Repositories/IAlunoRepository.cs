﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IAlunoRepository : IBaseRepository<Aluno>
    {
        Aluno GetEmail(string email);
    }
}
