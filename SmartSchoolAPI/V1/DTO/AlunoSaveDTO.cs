using System;

namespace SmartSchoolAPI.V1.DTO
{
    public class AlunoSaveDTO
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataMatricula { get; set; } = DateTime.Now;
        public DateTime? DataDesativacao { get; set; } = null;
        public bool Ativo { get; set; } = true;
    }
}