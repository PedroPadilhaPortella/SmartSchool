using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchoolAPI.Models;

namespace SmartSchoolAPI.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>() {
            new Aluno(1, "Marcos", "Silva", "9999"),
            new Aluno(2, "Pedro", "Portella", "5323532"),
            new Aluno(3, "Saulo", "Lima", "4432325")
        };

        public AlunoController()
        {
            
        }


    	[HttpGet]
        public IActionResult Get() {
            return Ok(Alunos);
        }


    	[HttpGet("{id}")]
        public IActionResult GetById(int id) {
            Aluno aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if(aluno == null) return BadRequest($"Aluno com Id {id} não encontrado");
            return Ok(aluno);
        }


        //https://localhost:5001/aluno/byName?nome=Pedro&sobrenome=Portella
    	[HttpGet("byName")]
        public IActionResult GetNameId(string nome, string sobrenome) {
            Aluno aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));
            if(aluno == null) return BadRequest($"Aluno com Nome {nome} e Sobrenome {sobrenome} não encontrado");
            return Ok(aluno);
        }


    	[HttpPost]
        public IActionResult Post(Aluno aluno) {
            return Ok(aluno);
        }


    	[HttpPut]
        public IActionResult Put(Aluno aluno) {
            return Ok(aluno);
        }
    }
}