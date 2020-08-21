using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class MatriculaMap : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.ToTable("Matricula");

            builder.HasKey(m=> m.IdMatricula);

            builder.Property(m => m.IdMatricula)
                .HasColumnName("IdMatricula");           

            builder.Property(m => m.DataMatricula)
                .HasColumnName("DataMatricula")
                .IsRequired();

            builder.Property(m => m.IdAluno)
                .HasColumnName("IdAluno")
                .IsRequired();

            builder.Property(m => m.IdTurma)
                .HasColumnName("IdTurma")
                .IsRequired();

            
            builder.HasOne(c => c.Aluno) 
            .WithMany(p => p.Matriculas) 
            .HasForeignKey(c => c.IdAluno);

            builder.HasOne(c => c.Turma)
            .WithMany(p => p.Matriculas)
            .HasForeignKey(c => c.IdTurma);
        }
    }
}
