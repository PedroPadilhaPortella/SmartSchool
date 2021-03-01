using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartSchoolAPI.Data;
using SmartSchoolAPI.Models;
using SmartSchoolAPI.V1.DTO;

namespace SmartSchoolAPI.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("/v{version:apiVersion}/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public ProfessorController(IRepository repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }


        [HttpGet]
        public IActionResult Get()
        {
            List<Professor> professores = _repository.GetAllProfessores(true);
            List<ProfessorDTO> professoresDTO = _mapper.Map<List<ProfessorDTO>>(professores);
            return Ok(professoresDTO);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Professor professor = _repository.GetProfessorById(id, true);
            if (professor == null) return BadRequest($"Professor com Id {id} não encontrado");
            ProfessorDTO professorDTO = _mapper.Map<ProfessorDTO>(professor);
            return Ok(professorDTO);
        }


        [HttpGet("byAluno/{alunoId}")]
        public IActionResult GetByAlunoId(int alunoId)
        {
            List<Professor> professores = _repository.GetProfessoresByAlunoId(alunoId, true);
            if (professores == null) return BadRequest($"Professores do Aluno com Id {alunoId} não encontrado");
            List<ProfessorDTO> professoresDTO = _mapper.Map<List<ProfessorDTO>>(professores);
            return Ok(professoresDTO);
        }


        [HttpGet("byDisciplina/{id}")]
        public IActionResult GetByDisciplina(int id)
        {
            List<Professor> professores = _repository.GetAllProfessoresByDisciplina(id, true);
            List<ProfessorDTO> professoresDTO = _mapper.Map<List<ProfessorDTO>>(professores);
            return Ok(professoresDTO);
        }


        //https://localhost:5001/aluno/byName?nome=Pedro
        [HttpGet("byName")]
        public IActionResult GetNameId(string nome, string sobrenome)
        {
            Professor professor = _repository.GetProfessorByNome(nome, sobrenome, true);
            if (professor == null) return BadRequest($"Professor com Nome {nome} não encontrado");
            ProfessorDTO professorDTO = _mapper.Map<ProfessorDTO>(professor);
            return Ok(professorDTO);
        }


        [HttpPost] //validar se todos os campos requeridos estão sendo enviados
        public IActionResult Post(ProfessorSaveDTO professorSave)
        {
            Professor professor = _mapper.Map<Professor>(professorSave);
            _repository.Add(professor);
            if (_repository.SaveChanges())
                return Created($"http://localhost/professor/{professor.Id}", _mapper.Map<ProfessorDTO>(professor));
            
            return BadRequest("Erro ao Cadastrar Professor");
        }


        [HttpPut("{id}")] //validar se todos os campos requeridos estão sendo enviados
        public IActionResult Put(int id, ProfessorSaveDTO professorSave)
        {
            Professor professorDB = _repository.GetProfessorById(id, true);
            if (professorDB == null) return BadRequest($"Professor com Id {id} não encontrado");

            _mapper.Map(professorSave, professorDB);
            _repository.Update(professorDB);

            if (_repository.SaveChanges())
                return Created($"http://localhost/professor/{professorDB.Id}", _mapper.Map<ProfessorDTO>(professorDB));
            
            return BadRequest("Erro ao Atualizar Professor");
        }


        [HttpPatch("{id}")]
        public IActionResult Patch(int id, ProfessorSaveDTO professorSave)
        {
            Professor professorDB = _repository.GetProfessorById(id, true);
            if (professorDB == null) return BadRequest($"Professor com Id {id} não encontrado");

            _mapper.Map(professorSave, professorDB);
            _repository.Update(professorDB);

            if (_repository.SaveChanges())
                return Created($"http://localhost/professor/{professorDB.Id}", _mapper.Map<ProfessorDTO>(professorDB));
            
            return BadRequest("Erro ao Atualizar Professor");
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Professor professor = _repository.GetProfessorById(id, true);
            if (professor == null) return BadRequest($"Professor com Id {id} não encontrado");

            _repository.Delete(professor);
            if (_repository.SaveChanges())
                return Ok($"Professor com id {id} removido");
            
            return BadRequest($"Erro ao Remover Professor com id {id}");
        }
    }
}