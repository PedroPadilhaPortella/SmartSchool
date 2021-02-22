using System.Collections.Generic;

namespace SmartSchoolAPI.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }

        public Curso() { }
        public Curso(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
    }
}