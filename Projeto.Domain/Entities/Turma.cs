using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain
{
    public class Turma
    {
        public int IdTurma { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public string Ementa { get; set; }
        public int IdProfessor { get; set; }
        public Professor Professor { get; set; }
        public List<Matricula> Matriculas { get; set; }

        public Turma()
        {

        }

        public Turma(int idTurma, string nome, DateTime dataInicio,
            DateTime dataTermino, string ementa, int idProfessor,
            Professor professor, List<Matricula> matriculas)
        {
            IdTurma = idTurma;
            Nome = nome;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            Ementa = ementa;
            IdProfessor = idProfessor;
            Professor = professor;
            Matriculas = matriculas;
        }
    }
}
