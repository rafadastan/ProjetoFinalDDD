using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class TurmaMap : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.ToTable("Turma");

            builder.HasKey(t => t.IdTurma);

            builder.Property(t => t.IdTurma)
                .HasColumnName("IdTurma");

            builder.Property(t => t.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.Ementa)
                .HasColumnName("Ementa")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.DataInicio)
                .HasColumnName("DataInicio")
                .IsRequired();

            builder.Property(t => t.DataTermino)
                .HasColumnName("DataTermino")
                .IsRequired();

            builder.Property(t => t.IdProfessor)
                .HasColumnName("IdProfessor")
                .IsRequired();

            builder.HasOne(p => p.Professor)
            .WithMany(t => t.Turmas)
            .HasForeignKey(p => p.IdProfessor);
        }
    }
}
