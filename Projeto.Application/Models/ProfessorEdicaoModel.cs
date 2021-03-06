﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models
{
    public class ProfessorEdicaoModel
    {
        [Required(ErrorMessage = "Por favor, informe o id do Professor.")]
        public int IdProfessor { get; set; }

        [MinLength(3, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do Professor.")]
        public string Nome { get; set; }

        [StringLength(11, ErrorMessage = "Informe exatamente {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o cpf do Professor.")]
        public string Cpf { get; set; }
    }
}
