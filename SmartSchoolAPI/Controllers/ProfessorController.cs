using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchoolAPI.Data;
using SmartSchoolAPI.Models;

namespace SmartSchoolAPI.Controllers
{
    [Route("/professor")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly SmartContext _database;
        private readonly IRepository _repository;

        public ProfessorController(IRepository repository, SmartContext database)
        {
            this._database = database;
            this._repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_database.Professores);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Professor professor = _database.Professores.FirstOrDefault(p => p.Id == id);
            if (professor == null) return BadRequest($"Professor com Id {id} não encontrado");
            return Ok(professor);
        }


        //https://localhost:5001/aluno/byName?nome=Pedro
        [HttpGet("byName")]
        public IActionResult GetNameId(string nome)
        {
            Professor professor = _database.Professores.FirstOrDefault(p => p.Nome.Contains(nome));
            if (professor == null) return BadRequest($"Professor com Nome {nome} não encontrado");
            return Ok(professor);
        }


        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _repository.Add(professor);
            if (_repository.SaveChanges())
            {
                return Ok(professor);
            }
            return BadRequest("Erro ao Cadastrar Professor");
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            Professor professorDB = _database.Professores.AsNoTracking().FirstOrDefault(p => p.Id == id);
            if (professorDB == null) return BadRequest($"Professor com Id {id} não encontrado");

            _repository.Update(professor);
            if (_repository.SaveChanges())
            {
                return Ok(professor);
            }
            return BadRequest("Erro ao Atualizar Professor");
        }


        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            Professor professorDB = _database.Professores.AsNoTracking().FirstOrDefault(p => p.Id.Equals(id));
            if (professorDB == null) return BadRequest($"Professor com Id {id} não encontrado");

            _repository.Update(professor);
            if (_repository.SaveChanges())
            {
                return Ok(professor);
            }
            return BadRequest("Erro ao Atualizar Professor");
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Professor professor = _database.Professores.FirstOrDefault(p => p.Id.Equals(id));
            if (professor == null) return BadRequest($"Professor com Id {id} não encontrado");

            _repository.Delete(professor);
            if (_repository.SaveChanges())
            {
                return Ok($"Professor com id {id} removido");
            }
            return BadRequest($"Erro ao Remover Professor com id {id}");
        }
    }
}