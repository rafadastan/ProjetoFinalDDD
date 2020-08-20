    using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain
{
    public class Matricula
    {
        public int IdMatricula { get; set; }
        public DateTime DataMatricula { get; set; }
        public int IdTurma { get; set; }
        public int IdAluno { get; set; }
        public Turma Turma { get; set; }
        public Aluno Aluno { get; set; }

        public Matricula()
        {

        }

        public Matricula(int idMatricula, DateTime dataMatricula, int idTurma,
            int idAluno, Turma turma, Aluno aluno)
        {
            IdMatricula = idMatricula;
            DataMatricula = dataMatricula;
            IdTurma = idTurma;
            IdAluno = idAluno;
            Turma = turma;
            Aluno = aluno;
        }
    }
}
