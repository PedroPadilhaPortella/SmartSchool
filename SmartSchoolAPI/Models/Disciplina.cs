using System.Collections.Generic;

namespace SmartSchoolAPI.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public Curso Curso { get; set; }
        public int ProfessorId { get; set; }
        public int? PreRequisitoId { get; set; } = null;
        public Disciplina PreRequisito { get; set; }
        public int CursoId { get; set; }
        public Professor Professor { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
        
        public Disciplina() {}
        public Disciplina(int id, string nome, int professorId, int cursoId, int preRequisitoId, int cargaHoraria)  {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = professorId;
            this.CursoId = cursoId;
            this.PreRequisitoId = preRequisitoId;
            this.CargaHoraria = cargaHoraria;
        }
        public Disciplina(int id, string nome, int professorId, int cursoId, int cargaHoraria)  {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = professorId;
            this.CursoId = cursoId;
            this.CargaHoraria = cargaHoraria;
        }
    }
}