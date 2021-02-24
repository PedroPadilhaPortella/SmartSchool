﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchoolAPI.Data;

namespace SmartSchoolAPI.Migrations
{
    [DbContext(typeof(SmartContext))]
    [Migration("20210223022330_DataNascimentoUpdate")]
    partial class DataNascimentoUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SmartSchoolAPI.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("DataDesativacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(5806),
                            DataNascimento = new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 0,
                            Nome = "Marta",
                            Sobrenome = "Kent",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(8467),
                            DataNascimento = new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 0,
                            Nome = "Paula",
                            Sobrenome = "Isabela",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(8605),
                            DataNascimento = new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 0,
                            Nome = "Laura",
                            Sobrenome = "Antonia",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(8618),
                            DataNascimento = new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 0,
                            Nome = "Luiza",
                            Sobrenome = "Maria",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(8628),
                            DataNascimento = new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 0,
                            Nome = "Lucas",
                            Sobrenome = "Machado",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(8645),
                            DataNascimento = new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 0,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(8655),
                            DataNascimento = new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 0,
                            Nome = "Paulo",
                            Sobrenome = "José",
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchoolAPI.Models.AlunoCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunosCursos");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            CursoId = 1,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(554)
                        },
                        new
                        {
                            AlunoId = 2,
                            CursoId = 2,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(1445)
                        },
                        new
                        {
                            AlunoId = 3,
                            CursoId = 3,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(1489)
                        },
                        new
                        {
                            AlunoId = 4,
                            CursoId = 4,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(1493)
                        },
                        new
                        {
                            AlunoId = 5,
                            CursoId = 1,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(1496)
                        },
                        new
                        {
                            AlunoId = 6,
                            CursoId = 3,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(1503)
                        },
                        new
                        {
                            AlunoId = 7,
                            CursoId = 4,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(1506)
                        });
                });

            modelBuilder.Entity("SmartSchoolAPI.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("Nota")
                        .HasColumnType("double");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 1,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(3676)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4712)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 10,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4765)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 7,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4768)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 11,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4771)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4778)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 4,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4781)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 8,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4784)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 12,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4787)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 3,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4792)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 9,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4795)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 13,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4798)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 1,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4800)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4804)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 10,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4806)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4809)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 9,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4812)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 13,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4817)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4820)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4823)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 8,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4825)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 12,
                            DataInicio = new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4828)
                        });
                });

            modelBuilder.Entity("SmartSchoolAPI.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Tecnologia da Informação"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Sistemas de Informação"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Ciência da Computação"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Análise e Desenvolvimento de Sistemas"
                        });
                });

            modelBuilder.Entity("SmartSchoolAPI.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("PreRequisitoId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("PreRequisitoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CargaHoraria = 40,
                            CursoId = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CargaHoraria = 40,
                            CursoId = 3,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CargaHoraria = 40,
                            CursoId = 4,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 4,
                            CargaHoraria = 30,
                            CursoId = 3,
                            Nome = "Física",
                            PreRequisitoId = 2,
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 5,
                            CargaHoraria = 30,
                            CursoId = 1,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 6,
                            CargaHoraria = 22,
                            CursoId = 1,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 7,
                            CargaHoraria = 22,
                            CursoId = 2,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 8,
                            CargaHoraria = 22,
                            CursoId = 3,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 9,
                            CargaHoraria = 22,
                            CursoId = 4,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 10,
                            CargaHoraria = 120,
                            CursoId = 1,
                            Nome = "Programação",
                            PreRequisitoId = 1,
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 11,
                            CargaHoraria = 120,
                            CursoId = 2,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 12,
                            CargaHoraria = 120,
                            CursoId = 3,
                            Nome = "Programação",
                            PreRequisitoId = 2,
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 13,
                            CargaHoraria = 120,
                            CursoId = 4,
                            Nome = "Programação",
                            PreRequisitoId = 3,
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchoolAPI.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("DataDesativacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Registro")
                        .HasColumnType("int");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 22, 23, 23, 29, 781, DateTimeKind.Local).AddTicks(6031),
                            Nome = "Lauro",
                            Registro = 1,
                            Sobrenome = "Oliveira",
                            Telefone = "1197843-9921"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 22, 23, 23, 29, 783, DateTimeKind.Local).AddTicks(1897),
                            Nome = "Roberto",
                            Registro = 2,
                            Sobrenome = "Soares",
                            Telefone = "1197765-4532"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 22, 23, 23, 29, 783, DateTimeKind.Local).AddTicks(2046),
                            Nome = "Ronaldo",
                            Registro = 3,
                            Sobrenome = "Marconi",
                            Telefone = "1191276-3312"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 22, 23, 23, 29, 783, DateTimeKind.Local).AddTicks(2051),
                            Nome = "Rodrigo",
                            Registro = 4,
                            Sobrenome = "Carvalho",
                            Telefone = "1196752-2121"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 22, 23, 23, 29, 783, DateTimeKind.Local).AddTicks(2055),
                            Nome = "Alexandre",
                            Registro = 5,
                            Sobrenome = "Montanha",
                            Telefone = "1197903-7676"
                        });
                });

            modelBuilder.Entity("SmartSchoolAPI.Models.AlunoCurso", b =>
                {
                    b.HasOne("SmartSchoolAPI.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchoolAPI.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchoolAPI.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchoolAPI.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchoolAPI.Models.Disciplina", "Disciplina")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchoolAPI.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchoolAPI.Models.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchoolAPI.Models.Disciplina", "PreRequisito")
                        .WithMany()
                        .HasForeignKey("PreRequisitoId");

                    b.HasOne("SmartSchoolAPI.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}