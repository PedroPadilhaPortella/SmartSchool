using System.Collections.Generic;
using System.Threading.Tasks;
using SmartSchoolAPI.Helpers;
using SmartSchoolAPI.Models;

namespace SmartSchoolAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        //Alunos
        List<Aluno> GetAllAlunos(bool includeProfessor);
        Task<PageList<Aluno>> GetAllAlunosAsync(PageParams pageParams, bool includeProfessor);
        List<Aluno> GetAllAlunosByDisciplina(int disciplinaId, bool includeProfessor);
        Aluno GetAlunoById(int alunoId, bool includeProfessor);
        Aluno GetAlunoByNome(string nome, string sobrenome, bool includeProfessor);

        //Professores
        List<Professor> GetAllProfessores(bool includeAlunos);
        List<Professor> GetAllProfessoresByDisciplina(int disciplinaId, bool includeAlunos);
        Professor GetProfessorById(int professorId, bool includeAlunos);
        List<Professor> GetProfessoresByAlunoId(int alunoId, bool includeAlunos);
        Professor GetProfessorByNome(string nome, string sobrenome, bool includeAlunos);
    }
}