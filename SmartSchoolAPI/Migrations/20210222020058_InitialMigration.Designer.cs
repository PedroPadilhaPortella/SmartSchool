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
    [Migration("20210222020058_InitialMigration")]
    partial class InitialMigration
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
                            DataMatricula = new DateTime(2021, 2, 21, 23, 0, 57, 724, DateTimeKind.Local).AddTicks(3307),
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Marta",
                            Sobrenome = "Kent",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 21, 23, 0, 57, 724, DateTimeKind.Local).AddTicks(5687),
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 2,
                            Nome = "Paula",
                            Sobrenome = "Isabela",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 21, 23, 0, 57, 724, DateTimeKind.Local).AddTicks(5786),
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 3,
                            Nome = "Laura",
                            Sobrenome = "Antonia",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 21, 23, 0, 57, 724, DateTimeKind.Local).AddTicks(5794),
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 4,
                            Nome = "Luiza",
                            Sobrenome = "Maria",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 21, 23, 0, 57, 724, DateTimeKind.Local).AddTicks(5800),
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 5,
                            Nome = "Lucas",
                            Sobrenome = "Machado",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 21, 23, 0, 57, 724, DateTimeKind.Local).AddTicks(5809),
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 6,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 21, 23, 0, 57, 724, DateTimeKind.Local).AddTicks(5815),
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 7,
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
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(3421)
                        },
                        new
                        {
                            AlunoId = 2,
                            CursoId = 2,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(4020)
                        },
                        new
                        {
                            AlunoId = 3,
                            CursoId = 3,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(4043)
                        },
                        new
                        {
                            AlunoId = 4,
                            CursoId = 4,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(4045)
                        },
                        new
                        {
                            AlunoId = 5,
                            CursoId = 1,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(4046)
                        },
                        new
                        {
                            AlunoId = 6,
                            CursoId = 3,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(4051)
                        },
                        new
                        {
                            AlunoId = 7,
                            CursoId = 4,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(4052)
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
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5310)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5907)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 10,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5930)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 7,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5932)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 11,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5933)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5937)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 4,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5939)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 8,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5941)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 12,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5942)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 3,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5945)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 9,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5947)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 13,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5948)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 1,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5950)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5951)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 10,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5953)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5954)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 9,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5956)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 13,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5958)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5960)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5961)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 8,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5963)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 12,
                            DataInicio = new DateTime(2021, 2, 21, 23, 0, 57, 725, DateTimeKind.Local).AddTicks(5964)
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
                            DataMatricula = new DateTime(2021, 2, 21, 23, 0, 57, 719, DateTimeKind.Local).AddTicks(4812),
                            Nome = "Lauro",
                            Registro = 1,
                            Sobrenome = "Oliveira",
                            Telefone = "1197843-9921"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 21, 23, 0, 57, 720, DateTimeKind.Local).AddTicks(8698),
                            Nome = "Roberto",
                            Registro = 2,
                            Sobrenome = "Soares",
                            Telefone = "1197765-4532"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 21, 23, 0, 57, 720, DateTimeKind.Local).AddTicks(8776),
                            Nome = "Ronaldo",
                            Registro = 3,
                            Sobrenome = "Marconi",
                            Telefone = "1191276-3312"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 21, 23, 0, 57, 720, DateTimeKind.Local).AddTicks(8779),
                            Nome = "Rodrigo",
                            Registro = 4,
                            Sobrenome = "Carvalho",
                            Telefone = "1196752-2121"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataMatricula = new DateTime(2021, 2, 21, 23, 0, 57, 720, DateTimeKind.Local).AddTicks(8781),
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