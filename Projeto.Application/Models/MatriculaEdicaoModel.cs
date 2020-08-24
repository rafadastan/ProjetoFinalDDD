using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models
{
    public class MatriculaEdicaoModel
    {
        [Required(ErrorMessage = "Por favor, informe o id da Matricula.")]
        public int IdMatricula { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data da matricula.")]
        public DateTime DataMatricula { get; set; }

        [Required(ErrorMessage = "Por favor, informe o id da Turma.")]
        public int IdTurma { get; set; }

        [Required(ErrorMessage = "Por favor, informe o id do Aluno.")]
        public int IdAluno { get; set; }
    }
}
