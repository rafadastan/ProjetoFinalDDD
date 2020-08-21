using Microsoft.EntityFrameworkCore;
using Projeto.Domain;
using Projeto.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Turma> Turma { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new MatriculaMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());

            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.HasIndex(a => a.Email).IsUnique();
            });

            modelBuilder.Entity<Professor>(entity =>
            {
                entity.HasIndex(a => a.Cpf).IsUnique();
            });


        }
    }
}
