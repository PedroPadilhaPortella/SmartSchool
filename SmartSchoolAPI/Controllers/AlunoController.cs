using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchoolAPI.Data;
using SmartSchoolAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace SmartSchoolAPI.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IRepository _repository;

        public AlunoController(IRepository repository)
        {
            this._repository = repository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            List<Aluno> alunos = _repository.GetAllAlunos(true);
            return Ok(alunos);
        }

        [HttpGet("byDisciplina/{id}")]
        public IActionResult GetByDisciplina(int id)
        {
            List<Aluno> alunos = _repository.GetAllAlunosByDisciplina(id, true);
            return Ok(alunos);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Aluno aluno = _repository.GetAlunoById(id, true);
            if (aluno == null) return BadRequest($"Aluno com Id {id} não encontrado");
            return Ok(aluno);
        }


        //https://localhost:5001/aluno/byName?nome=Pedro&sobrenome=Portella
        [HttpGet("byName")]
        public IActionResult GetNameId(string nome, string sobrenome)
        {
            Aluno aluno = _repository.GetAlunoByNome(nome, sobrenome, true);
            if (aluno == null) return BadRequest($"Aluno com Nome {nome} {sobrenome} não encontrado");
            return Ok(aluno);
        }


        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _repository.Add(aluno);
            if (_repository.SaveChanges())
            {
                return Ok(aluno);
            }
            return BadRequest("Erro ao Cadastrar Aluno");
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            Aluno alunoDB = _repository.GetAlunoById(id, true);
            if (alunoDB == null) return BadRequest($"Aluno com Id {id} não encontrado");

            _repository.Update(aluno);
            if (_repository.SaveChanges())
            {
                return Ok(aluno);
            }
            return BadRequest("Erro ao Atualizar Professor");
        }


        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            Aluno alunoDB = _repository.GetAlunoById(id, true);
            if (alunoDB == null) return BadRequest($"Aluno com Id {id} não encontrado");

            _repository.Update(aluno);
            if (_repository.SaveChanges())
            {
                return Ok(aluno);
            }
            return BadRequest("Erro ao Atualizar Aluno");
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Aluno aluno = _repository.GetAlunoById(id, true);
            if (aluno == null) return BadRequest($"Aluno com Id {id} não encontrado");

            _repository.Delete(aluno);
            if (_repository.SaveChanges())
            {
                return Ok($"Aluno com id {id} removido");
            }
            return BadRequest($"Erro ao Remover Aluno com id {id}");
        }
    }
}