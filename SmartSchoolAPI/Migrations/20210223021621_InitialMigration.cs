﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchoolAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Matricula = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    DataMatricula = table.Column<DateTime>(nullable: false),
                    DataDesativacao = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Registro = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    DataMatricula = table.Column<DateTime>(nullable: false),
                    DataDesativacao = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlunosCursos",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosCursos", x => new { x.AlunoId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_AlunosCursos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosCursos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CargaHoraria = table.Column<int>(nullable: false),
                    ProfessorId = table.Column<int>(nullable: false),
                    PreRequisitoId = table.Column<int>(nullable: true),
                    CursoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Disciplinas_PreRequisitoId",
                        column: x => x.PreRequisitoId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunosDisciplinas",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Nota = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosDisciplinas", x => new { x.AlunoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Ativo", "DataDesativacao", "DataMatricula", "DataNascimento", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[,]
                {
                    { 1, true, null, new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(4438), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Marta", "Kent", "33225555" },
                    { 2, true, null, new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(8624), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Paula", "Isabela", "3354288" },
                    { 3, true, null, new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(8804), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Laura", "Antonia", "55668899" },
                    { 4, true, null, new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(8820), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Luiza", "Maria", "6565659" },
                    { 5, true, null, new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(8835), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Lucas", "Machado", "565685415" },
                    { 6, true, null, new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(8857), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Pedro", "Alvares", "456454545" },
                    { 7, true, null, new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(8871), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Paulo", "José", "9874512" }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Tecnologia da Informação" },
                    { 2, "Sistemas de Informação" },
                    { 3, "Ciência da Computação" },
                    { 4, "Análise e Desenvolvimento de Sistemas" }
                });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Ativo", "DataDesativacao", "DataMatricula", "Nome", "Registro", "Sobrenome", "Telefone" },
                values: new object[,]
                {
                    { 1, true, null, new DateTime(2021, 2, 22, 23, 16, 19, 753, DateTimeKind.Local).AddTicks(6832), "Lauro", 1, "Oliveira", "1197843-9921" },
                    { 2, true, null, new DateTime(2021, 2, 22, 23, 16, 19, 755, DateTimeKind.Local).AddTicks(2138), "Roberto", 2, "Soares", "1197765-4532" },
                    { 3, true, null, new DateTime(2021, 2, 22, 23, 16, 19, 755, DateTimeKind.Local).AddTicks(2309), "Ronaldo", 3, "Marconi", "1191276-3312" },
                    { 4, true, null, new DateTime(2021, 2, 22, 23, 16, 19, 755, DateTimeKind.Local).AddTicks(2317), "Rodrigo", 4, "Carvalho", "1196752-2121" },
                    { 5, true, null, new DateTime(2021, 2, 22, 23, 16, 19, 755, DateTimeKind.Local).AddTicks(2320), "Alexandre", 5, "Montanha", "1197903-7676" }
                });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId", "DataFim", "DataInicio" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(2999) },
                    { 5, 1, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(4105) },
                    { 2, 2, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(4042) },
                    { 3, 3, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(4097) },
                    { 6, 3, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(4112) },
                    { 4, 4, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(4101) },
                    { 7, 4, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(4116) }
                });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PreRequisitoId", "ProfessorId" },
                values: new object[,]
                {
                    { 1, 40, 1, "Matemática", null, 1 },
                    { 2, 40, 3, "Matemática", null, 1 },
                    { 3, 40, 4, "Matemática", null, 1 },
                    { 5, 30, 1, "Português", null, 3 },
                    { 6, 22, 1, "Inglês", null, 4 },
                    { 7, 22, 2, "Inglês", null, 4 },
                    { 8, 22, 3, "Inglês", null, 4 },
                    { 9, 22, 4, "Inglês", null, 4 },
                    { 11, 120, 2, "Programação", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataInicio", "Nota" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(6586), null },
                    { 4, 9, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7696), null },
                    { 7, 8, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7733), null },
                    { 3, 8, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7684), null },
                    { 2, 7, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7666), null },
                    { 5, 5, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7707), null },
                    { 1, 5, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7615), null },
                    { 6, 9, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7716), null },
                    { 6, 3, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7713), null },
                    { 7, 2, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7727), null },
                    { 3, 2, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7678), null },
                    { 5, 1, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7703), null },
                    { 4, 3, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7693), null },
                    { 2, 11, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7670), null }
                });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PreRequisitoId", "ProfessorId" },
                values: new object[,]
                {
                    { 13, 120, 4, "Programação", 3, 5 },
                    { 12, 120, 3, "Programação", 2, 5 },
                    { 4, 30, 3, "Física", 2, 2 },
                    { 10, 120, 1, "Programação", 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId", "DataFim", "DataInicio", "Nota" },
                values: new object[,]
                {
                    { 1, 10, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7663), null },
                    { 5, 10, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7710), null },
                    { 3, 4, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7681), null },
                    { 7, 4, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7730), null },
                    { 3, 12, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7687), null },
                    { 7, 12, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7737), null },
                    { 4, 13, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7700), null },
                    { 6, 13, null, new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7723), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunosCursos_CursoId",
                table: "AlunosCursos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosDisciplinas_DisciplinaId",
                table: "AlunosDisciplinas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_PreRequisitoId",
                table: "Disciplinas",
                column: "PreRequisitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunosCursos");

            migrationBuilder.DropTable(
                name: "AlunosDisciplinas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
