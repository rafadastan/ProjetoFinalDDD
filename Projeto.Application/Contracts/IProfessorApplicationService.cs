using Projeto.Application.Models;
using Projeto.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IProfessorApplicationService
    {
        void Insert(ProfessorCadastroModel model);
        void Update(ProfessorEdicaoModel model);
        void Delete(int id);
        List<Professor> GetAll();
        Professor GetById(int id);
    }
}
