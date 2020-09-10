using Microsoft.EntityFrameworkCore;
using Projeto.Domain;
using Projeto.Domain.Entities;
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
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new MatriculaMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.HasIndex(a => a.Email).IsUnique();
            });

            modelBuilder.Entity<Professor>(entity =>
            {
                entity.HasIndex(a => a.Cpf).IsUnique();
            });

            modelBuilder.Entity<Usuario>(entity=>
            {
                entity.HasIndex(u => u.Login).IsUnique();
            });
        }
    }
}
