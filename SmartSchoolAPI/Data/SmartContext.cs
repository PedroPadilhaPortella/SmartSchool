using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SmartSchoolAPI.Models;

namespace SmartSchoolAPI.Data
{
    public class SmartContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<AlunoCurso> AlunosCursos { get; set; }

        public SmartContext(DbContextOptions<SmartContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>().HasKey(ad => new { ad.AlunoId, ad.DisciplinaId });
            builder.Entity<AlunoCurso>().HasKey(ac => new { ac.AlunoId, ac.CursoId });

            builder.Entity<Professor>()
                .HasData(new List<Professor>() {
                    new Professor(1, 1,"Lauro", "Oliveira", "1197843-9921"),
                    new Professor(2, 2,"Roberto", "Soares", "1197765-4532"),
                    new Professor(3, 3,"Ronaldo", "Marconi", "1191276-3312"),
                    new Professor(4, 4,"Rodrigo", "Carvalho", "1196752-2121"),
                    new Professor(5, 5,"Alexandre", "Montanha", "1197903-7676"),
                });

            builder.Entity<Aluno>()
                .HasData(new List<Aluno>() {
                    new Aluno(1, 1, "Marta", "Kent", "33225555", DateTime.Parse("2001-10-06")),
                    new Aluno(2, 2, "Paula", "Isabela", "3354288", DateTime.Parse("2001-10-06")),
                    new Aluno(3, 3, "Laura", "Antonia", "55668899", DateTime.Parse("2001-10-06")),
                    new Aluno(4, 4, "Luiza", "Maria", "6565659", DateTime.Parse("2001-10-06")),
                    new Aluno(5, 5, "Lucas", "Machado", "565685415", DateTime.Parse("2001-10-06")),
                    new Aluno(6, 6, "Pedro", "Alvares", "456454545", DateTime.Parse("2001-10-06")),
                    new Aluno(7, 7, "Paulo", "José", "9874512", DateTime.Parse("2001-10-06")),
                });
            
            builder.Entity<Curso>()
                .HasData(new List<Curso> {
                    new Curso(1, "Tecnologia da Informação"),
                    new Curso(2, "Sistemas de Informação"),
                    new Curso(3, "Ciência da Computação"),
                    new Curso(4, "Análise e Desenvolvimento de Sistemas"),
                });
            
            builder.Entity<Disciplina>()
                .HasData(new List<Disciplina>() {
                    new Disciplina(1, "Matemática", 1, 1, 40),
                    new Disciplina(2, "Matemática", 1, 3, 40),
                    new Disciplina(3, "Matemática", 1, 4, 40),
                    new Disciplina(4, "Física", 2, 3, 2, 30),
                    new Disciplina(5, "Português", 3, 1, 30),
                    new Disciplina(6, "Inglês", 4, 1, 22),
                    new Disciplina(7, "Inglês", 4, 2, 22),
                    new Disciplina(8, "Inglês", 4, 3, 22),
                    new Disciplina(9, "Inglês", 4, 4, 22),
                    new Disciplina(10, "Programação", 5, 1, 1, 120),
                    new Disciplina(11, "Programação", 5, 2, 120),
                    new Disciplina(12, "Programação", 5, 3, 2, 120),
                    new Disciplina(13, "Programação", 5, 4, 3, 120),
                });

            builder.Entity<AlunoCurso>()
                .HasData(new List<AlunoCurso>() {
                    new AlunoCurso(1, 1),
                    new AlunoCurso(2, 2),
                    new AlunoCurso(3, 3),
                    new AlunoCurso(4, 4),
                    new AlunoCurso(5, 1),
                    new AlunoCurso(6, 3),
                    new AlunoCurso(7, 4),
                }
                );

            builder.Entity<AlunoDisciplina>()
                .HasData(new List<AlunoDisciplina>() {
                    new AlunoDisciplina(1, 1),
                    new AlunoDisciplina(1, 5),
                    new AlunoDisciplina(1, 10),
                    new AlunoDisciplina(2, 7),
                    new AlunoDisciplina(2, 11),
                    new AlunoDisciplina(3, 2),
                    new AlunoDisciplina(3, 4),
                    new AlunoDisciplina(3, 8),
                    new AlunoDisciplina(3, 12),
                    new AlunoDisciplina(4, 3),
                    new AlunoDisciplina(4, 9),
                    new AlunoDisciplina(4, 13),
                    new AlunoDisciplina(5, 1),
                    new AlunoDisciplina(5, 5),
                    new AlunoDisciplina(5, 10),
                    new AlunoDisciplina(6, 3),
                    new AlunoDisciplina(6, 9),
                    new AlunoDisciplina(6, 13),
                    new AlunoDisciplina(7, 2),
                    new AlunoDisciplina(7, 4),
                    new AlunoDisciplina(7, 8),
                    new AlunoDisciplina(7, 12),
                });
        }
    }
}