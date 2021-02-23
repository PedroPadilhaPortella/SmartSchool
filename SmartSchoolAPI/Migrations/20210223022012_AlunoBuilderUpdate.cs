using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchoolAPI.Migrations
{
    public partial class AlunoBuilderUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 1, 1 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 2, 2 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 3, 3 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 4, 4 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 5, 1 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 6, 3 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 7, 4 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 1 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 10 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 7 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 11 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 4 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 8 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 12 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 3 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 9 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 13 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 1 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 10 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 9 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 13 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 8 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 12 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 879, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 873, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 875, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 875, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 875, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 20, 11, 875, DateTimeKind.Local).AddTicks(701));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 782, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 1, 1 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 2, 2 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 3, 3 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 4, 4 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 5, 1 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 6, 3 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 7, 4 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 1 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 10 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 7 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 11 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 4 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 8 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 12 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 3 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 9 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 13 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 1 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 10 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 9 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 13 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 8 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 12 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 784, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 753, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 755, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 755, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 755, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 16, 19, 755, DateTimeKind.Local).AddTicks(2320));
        }
    }
}
