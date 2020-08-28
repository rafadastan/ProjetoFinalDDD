using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class AlunoApplicationService : IAlunoApplicationService
    {
        private readonly IAlunoDomainService alunoDomainService;

        public AlunoApplicationService(IAlunoDomainService alunoDomainService)
        {
            this.alunoDomainService = alunoDomainService;
        }

        public void Delete(int id)
        {
            var aluno = alunoDomainService.GetById(id);
            alunoDomainService.Delete(aluno);
        }   

        public List<Aluno> GetAll()
        {
            return alunoDomainService.GetAll();
        }

        public Aluno GetById(int id)
        {
            return alunoDomainService.GetById(id);
        }

        public void Insert(AlunoCadastroModel model)
        {
            var aluno = new Aluno();

            aluno.Nome = model.Nome;
            aluno.Email = model.Email;
            aluno.DataNascimento = model.DataDeNascimento;

            alunoDomainService.Insert(aluno);
        }

        public void Update(AlunoEdicaoModel model)
        {
            var aluno = new Aluno();

            aluno.IdAluno = model.IdAluno;
            aluno.Nome = model.Nome;
            aluno.Email = model.Email;
            aluno.DataNascimento = model.DataDeNascimento;
            
            alunoDomainService.Update(aluno);
        }
    }
}
