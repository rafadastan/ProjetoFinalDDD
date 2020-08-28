using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class TurmaApplicationService : ITurmaApplicationService
    {
        private readonly ITurmaDomainService turmaDomainService;

        public TurmaApplicationService(ITurmaDomainService turmaDomainService)
        {
            this.turmaDomainService = turmaDomainService;
        }

        public void Delete(int id)
        {
            var turma = turmaDomainService.GetById(id);
            turmaDomainService.Delete(turma);
        }

        public List<Turma> GetAll()
        {
            return turmaDomainService.GetAll();
        }

        public Turma GetById(int id)
        {
            return turmaDomainService.GetById(id);
        }

        public void Insert(TurmaCadastroModel model)
        {
            var turma = new Turma();

            turma.DataInicio = model.DataInicio;
            turma.DataTermino = model.DataTermino;
            turma.Ementa = model.Ementa;
            turma.IdProfessor = model.IdProfessor;
            turma.Nome = model.Nome;

            turmaDomainService.Insert(turma);
        }

        public void Update(TurmaEdicaoModel model)
        {
            var turma = new Turma();

            turma.IdTurma = model.IdTurma;
            turma.Nome = model.Nome;
            turma.DataInicio = model.DataInicio;
            turma.DataTermino = model.DataTermino;
            turma.Ementa = model.Ementa;
            turma.IdProfessor = model.IdProfessor;

            turmaDomainService.Update(turma);
        }
    }
}
