using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class MatriculaApplicationService : IMatriculaApplicationService
    {
        private readonly IMatriculaDomainService matriculaDomainService;

        public MatriculaApplicationService(IMatriculaDomainService matriculaDomainService)
        {
            this.matriculaDomainService = matriculaDomainService;
        }

        public void Delete(int id)
        {
            var matricula = matriculaDomainService.GetById(id);
            matriculaDomainService.Delete(matricula);
        }

        public List<Matricula> GetAll()
        {
            return matriculaDomainService.GetAll();
        }

        public Matricula GetById(int id)
        {
            return matriculaDomainService.GetById(id);
        }

        public void Insert(MatriculaCadastroModel model)
        {
            var matricula = new Matricula();

            matricula.IdAluno = model.IdAluno;
            matricula.DataMatricula = model.DataMatricula;
            matricula.IdTurma = model.IdTurma;

            matriculaDomainService.Insert(matricula);
        }

        public void Update(MatriculaEdicaoModel model)
        {
            var matricula = new Matricula();

            matricula.IdMatricula = model.IdMatricula;
            matricula.IdAluno = model.IdAluno;
            matricula.DataMatricula = model.DataMatricula;
            matricula.IdTurma = model.IdTurma;

            matriculaDomainService.Update(matricula);
        }
    }
}
