    using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain
{
    public class Professor
    {
        public int IdProfessor { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public List<Turma> Turmas { get; set; }

        public Professor()
        {
        }

        public Professor(int idProfessor, string nome, string cpf, List<Turma> turmas)
        {
            IdProfessor = idProfessor;
            Nome = nome;
            Cpf = cpf;
            Turmas = turmas;
        }
    }
}
