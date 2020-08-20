using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public List<Matricula> Matriculas { get; set; }

        public Aluno()
        {

        }

        public Aluno(int idAluno, string nome, DateTime dataNascimento, string email, List<Matricula> matriculas)
        {
            IdAluno = idAluno;
            Nome = nome;
            DataNascimento = dataNascimento;
            Email = email;
            Matriculas = matriculas;
        }
    }
}
