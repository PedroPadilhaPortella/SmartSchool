using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchoolAPI.Migrations
{
    public partial class DataNascimentoUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(5806), new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(8467), new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(8605), new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(8618), new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(8628), new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(8645), new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 23, 29, 787, DateTimeKind.Local).AddTicks(8655), new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 1, 1 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 2, 2 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 3, 3 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 4, 4 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 5, 1 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 6, 3 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "AlunosCursos",
                keyColumns: new[] { "AlunoId", "CursoId" },
                keyValues: new object[] { 7, 4 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 1 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 10 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 7 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 11 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 4 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 8 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 12 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 3 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 9 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 13 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 1 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 10 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 9 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 13 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 8 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 12 },
                column: "DataInicio",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 789, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 781, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 783, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 783, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 783, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataMatricula",
                value: new DateTime(2021, 2, 22, 23, 23, 29, 783, DateTimeKind.Local).AddTicks(2055));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(904), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(3592), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(3701), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(3709), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(3715), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(3725), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataMatricula", "DataNascimento", "Matricula" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 20, 11, 878, DateTimeKind.Local).AddTicks(3730), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

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
    }
}
