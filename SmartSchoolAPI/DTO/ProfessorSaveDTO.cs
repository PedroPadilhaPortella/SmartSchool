using System;
using System.Collections.Generic;

namespace SmartSchoolAPI.Models
{
    public class ProfessorSaveDTO
    {
        public int Id { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataMatricula { get; set; } = DateTime.Now;
        public DateTime? DataDesativacao { get; set; } = null;
        public bool Ativo { get; set; } = true;
    }
}