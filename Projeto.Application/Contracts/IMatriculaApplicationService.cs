using Projeto.Application.Models;
using Projeto.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IMatriculaApplicationService
    {
        void Insert(MatriculaCadastroModel model);
        void Update(MatriculaEdicaoModel model);
        void Delete(int id);
        List<Matricula> GetAll();
        Matricula GetById(int id);
    }
}
