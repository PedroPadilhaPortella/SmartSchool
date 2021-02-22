using System;
using System.Collections.Generic;

namespace SmartSchoolAPI.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataMatricula { get; set; } = DateTime.Now;
        public DateTime? DataDesativacao { get; set; } = null;
        public bool Ativo { get; set; } = true;
        public IEnumerable<Disciplina> Disciplinas { get; set; }

        public Professor() {}
        public Professor(int id, int registro, string nome, string sobrenome, string telefone) {
            this.Id = id;
            this.Registro = registro;
            this.Sobrenome = sobrenome;
            this.Nome = nome;
            this.Telefone = telefone;
        }
    }
}