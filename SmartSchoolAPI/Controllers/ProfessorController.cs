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
        private readonly IRepository _repository;

        public ProfessorController(IRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Professor> professores = _repository.GetAllProfessores(true);
            return Ok(professores);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Professor professor = _repository.GetProfessorById(id, true);
            if (professor == null) return BadRequest($"Professor com Id {id} não encontrado");
            return Ok(professor);
        }


        [HttpGet("byDisciplina/{id}")]
        public IActionResult GetByDisciplina(int id)
        {
            List<Professor> professores = _repository.GetAllProfessoresByDisciplina(id, true);
            return Ok(professores);
        }


        //https://localhost:5001/aluno/byName?nome=Pedro
        [HttpGet("byName")]
        public IActionResult GetNameId(string nome)
        {
            Professor professor = _repository.GetProfessorByNome(nome, true);
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
            Professor professorDB = _repository.GetProfessorById(id, true);
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
            Professor professorDB = _repository.GetProfessorById(id, true);
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
            Professor professor = _repository.GetProfessorById(id, true);
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