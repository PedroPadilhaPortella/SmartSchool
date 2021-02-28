using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSchoolAPI.Helpers;
using SmartSchoolAPI.Models;

namespace SmartSchoolAPI.Data
{
    public class Repository : IRepository
    {
        private readonly SmartContext _database;
        public Repository(SmartContext database)
        {
            this._database = database;
        }


        public void Add<T>(T entity) where T : class
        {
            _database.Add(entity);
        }


        public void Update<T>(T entity) where T : class
        {
            _database.Update(entity);
        }


        public void Delete<T>(T entity) where T : class
        {
            _database.Remove(entity);
        }


        public bool SaveChanges()
        {
            return (_database.SaveChanges() > 0);
        }


        public List<Aluno> GetAllAlunos(bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _database.Alunos;
            
            if(includeProfessor) {
                query = query.Include(a => a.AlunosDisciplinas)
                    .ThenInclude(al => al.Disciplina)
                    .ThenInclude(d => d.Professor);
            }
            
            query = query.AsNoTracking().OrderBy(a => a.Id);
            return query.ToList();
        }

        public async Task<PageList<Aluno>> GetAllAlunosAsync(PageParams pageParams, bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _database.Alunos;
            
            if(includeProfessor) {
                query = query.Include(a => a.AlunosDisciplinas)
                    .ThenInclude(al => al.Disciplina)
                    .ThenInclude(d => d.Professor);
            }
            
            query = query.AsNoTracking().OrderBy(a => a.Id);
            return await PageList<Aluno>.CreateAsync(query, pageParams.PageNumber, pageParams.PageSize);
        }


        public List<Aluno> GetAllAlunosByDisciplina(int disciplinaId, bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _database.Alunos;
            
            if(includeProfessor) {
                query = query.Include(a => a.AlunosDisciplinas) 
                    .ThenInclude(al => al.Disciplina)
                    .ThenInclude(d => d.Professor);
            }
            
            query = query.AsNoTracking().OrderBy(a => a.Id)
                .Where(a => a.AlunosDisciplinas.Any(ad => ad.DisciplinaId == disciplinaId));
            return query.ToList();
        }

        public Aluno GetAlunoById(int alunoId, bool includeProfessor = false)
        {
            IQueryable<Aluno> query = _database.Alunos;
            
            if(includeProfessor) {
                query = query.Include(a => a.AlunosDisciplinas)
                    .ThenInclude(al => al.Disciplina)
                    .ThenInclude(d => d.Professor);
            }
            
            query = query.AsNoTracking().OrderBy(a => a.Id).Where(a => a.Id == alunoId);
            return query.FirstOrDefault();
        }


        public Aluno GetAlunoByNome(string nome, string sobrenome, bool includeProfessor)
        {
            IQueryable<Aluno> query = _database.Alunos;
            
            if(includeProfessor) {
                query = query.Include(a => a.AlunosDisciplinas)
                    .ThenInclude(al => al.Disciplina)
                    .ThenInclude(d => d.Professor);
            }
            
            return query.AsNoTracking()
                .FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));
        }


        public List<Professor> GetAllProfessores(bool includeAlunos = false)
        {
            IQueryable<Professor> query = _database.Professores;
            
            if(includeAlunos) {
                query = query.Include(p => p.Disciplinas)
                    .ThenInclude(d => d.AlunosDisciplinas)
                    .ThenInclude(ad => ad.Aluno);
            }
            
            query = query.AsNoTracking().OrderBy(p => p.Id);
            return query.ToList();
        }

        public List<Professor> GetAllProfessoresByDisciplina(int disciplinaId, bool includeAlunos = false)
        {
            IQueryable<Professor> query = _database.Professores;
            
            if(includeAlunos) {
                query = query.Include(p => p.Disciplinas)
                    .ThenInclude(d => d.AlunosDisciplinas)
                    .ThenInclude(ad => ad.Aluno);
            }
            
            query = query.AsNoTracking().OrderBy(p => p.Id)
                .Where(p => p.Disciplinas.Any(d => d.AlunosDisciplinas
                    .Any(ad => ad.DisciplinaId == disciplinaId)));
            return query.ToList();
        }

        public Professor GetProfessorById(int professorId, bool includeAlunos = false)
        {
            IQueryable<Professor> query = _database.Professores;
            
            if(includeAlunos) {
                query = query.Include(p => p.Disciplinas)
                    .ThenInclude(d => d.AlunosDisciplinas)
                    .ThenInclude(ad => ad.Aluno);
            }
            
            query = query.AsNoTracking().OrderBy(p => p.Id).Where(p => p.Id == professorId);
            return query.FirstOrDefault();
        }

        public Professor GetProfessorByNome(string nome, string sobrenome, bool includeAlunos)
        {
            IQueryable<Professor> query = _database.Professores;
            
            if(includeAlunos) {
                query = query.Include(p => p.Disciplinas)
                    .ThenInclude(d => d.AlunosDisciplinas)
                    .ThenInclude(ad => ad.Aluno);
            }
            
            return query.AsNoTracking()
                .FirstOrDefault(p => p.Nome.Contains(nome) && p.Sobrenome.Contains(sobrenome));
        }
    }
}