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
        private readonly SmartContext _database;

        public AlunoController(SmartContext database) {
            this._database = database;
        }


    	[HttpGet]
        public IActionResult Get() {
            return Ok(_database.Alunos);
        }


    	[HttpGet("{id}")]
        public IActionResult GetById(int id) {
            Aluno aluno = _database.Alunos.FirstOrDefault(a => a.Id == id);
            if(aluno == null) return BadRequest($"Aluno com Id {id} não encontrado");
            return Ok(aluno);
        }


        //https://localhost:5001/aluno/byName?nome=Pedro&sobrenome=Portella
    	[HttpGet("byName")]
        public IActionResult GetNameId(string nome, string sobrenome) {
            Aluno aluno = _database.Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));
            if(aluno == null) return BadRequest($"Aluno com Nome {nome} {sobrenome} não encontrado");
            return Ok(aluno);
        }


    	[HttpPost]
        public IActionResult Post(Aluno aluno) {
            _database.Add(aluno);
            _database.SaveChanges();
            return Ok(aluno);
        }


    	[HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno) {
            Aluno alunoDB = _database.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if(alunoDB == null) return BadRequest($"Aluno com Id {id} não encontrado");
            _database.Update(aluno);
            _database.SaveChanges();
            return Ok(aluno);
        }


        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno) {
            Aluno alunoDB = _database.Alunos.AsNoTracking().FirstOrDefault(a => a.Id.Equals(id));
            if(alunoDB == null) return BadRequest($"Aluno com Id {id} não encontrado");
            _database.Update(aluno);
            _database.SaveChanges();
            return Ok(aluno);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            Aluno aluno = _database.Alunos.FirstOrDefault(a => a.Id.Equals(id));
            if(aluno == null) return BadRequest($"Aluno com Id {id} não encontrado");
            _database.Remove(aluno);
            _database.SaveChanges();
            return Ok("Aluno excluído com Sucesso!");
        }
    }
}