using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class ProfessorMap : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professor");

            builder.HasKey(p => p.IdProfessor);

            builder.Property(p => p.IdProfessor)
                .HasColumnName("IdProfessor");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.Cpf)
                .HasColumnName("Cpf")
                .HasMaxLength(15)
                .IsRequired();

        }
    }
}
