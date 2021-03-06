using System;
using System.Collections.Generic;

namespace SmartSchoolAPI.V1.DTO
{
    public class ProfessorDTO
    {
        public int Id { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataMatricula { get; set; } = DateTime.Now;
        public bool Ativo { get; set; } = true;
    }
}