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

        public ProfessorController(SmartContext database) {
            this._database = database;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(_database.Professores);
        }


    	[HttpGet("{id}")]
        public IActionResult GetById(int id) {
            Professor professor = _database.Professores.FirstOrDefault(p => p.Id == id);
            if(professor == null) return BadRequest($"Professor com Id {id} não encontrado");
            return Ok(professor);
        }


        //https://localhost:5001/aluno/byName?nome=Pedro
    	[HttpGet("byName")]
        public IActionResult GetNameId(string nome) {
            Professor professor = _database.Professores.FirstOrDefault(p => p.Nome.Contains(nome));
            if(professor == null) return BadRequest($"Professor com Nome {nome} não encontrado");
            return Ok(professor);
        }


    	[HttpPost]
        public IActionResult Post(Professor professor) {
            _database.Add(professor);
            _database.SaveChanges();
            return Ok(professor);
        }


    	[HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor) {
            Professor professorDB = _database.Professores.AsNoTracking().FirstOrDefault(p => p.Id == id);
            if(professorDB == null) return BadRequest($"Professor com Id {id} não encontrado");
            _database.Update(professor);
            _database.SaveChanges();
            return Ok(professor);
        }


        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor) {
            Professor professorDB = _database.Professores.AsNoTracking().FirstOrDefault(p => p.Id.Equals(id));
            if(professorDB == null) return BadRequest($"Professor com Id {id} não encontrado");
            _database.Update(professor);
            _database.SaveChanges();
            return Ok(professor);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            Professor professor = _database.Professores.FirstOrDefault(p => p.Id.Equals(id));
            if(professor == null) return BadRequest($"Professor com Id {id} não encontrado");
            _database.Remove(professor);
            _database.SaveChanges();
            return Ok("Professor excluído com Sucesso!");
        }
    }
}