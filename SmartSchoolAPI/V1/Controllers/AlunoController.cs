using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchoolAPI.Data;
using SmartSchoolAPI.Models;
using SmartSchoolAPI.V1.DTO;
using AutoMapper;
using System.Threading.Tasks;
using SmartSchoolAPI.Helpers;

namespace SmartSchoolAPI.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("/v{version:apiVersion}/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public AlunoController(IRepository repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }


        ///<summary>
        ///Retorna todos os usuários
        ///http://localhost:5000/v1/aluno?pageNumber=2pageSize=3
        ///</summary>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PageParams pageParams)
        {
            List<Aluno> alunos = await _repository.GetAllAlunosAsync(pageParams, true);
            List<AlunoDTO> alunosDTO = _mapper.Map<List<AlunoDTO>>(alunos);
            return Ok(alunosDTO);
        }


        [HttpGet("byDisciplina/{id}")]
        public IActionResult GetByDisciplina(int id)
        {
            List<Aluno> alunos = _repository.GetAllAlunosByDisciplina(id, true);
            IEnumerable<AlunoDTO> alunosDTO = _mapper.Map<IEnumerable<AlunoDTO>>(alunos);
            return Ok(alunosDTO);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Aluno aluno = _repository.GetAlunoById(id, true);
            if (aluno == null) return BadRequest($"Aluno com Id {id} não encontrado");
            var alunoDTO = _mapper.Map<AlunoDTO>(aluno);
            return Ok(alunoDTO);
        }


        //https://localhost:5001/aluno/byName?nome=Pedro&sobrenome=Portella
        [HttpGet("byName")]
        public IActionResult GetNameId(string nome, string sobrenome)
        {
            Aluno aluno = _repository.GetAlunoByNome(nome, sobrenome, true);
            if (aluno == null) return BadRequest($"Aluno com Nome {nome} {sobrenome} não encontrado");
            var alunoDTO = _mapper.Map<AlunoDTO>(aluno);
            return Ok(alunoDTO);
        }


        [HttpPost] //validar se todos os campos requeridos estão sendo enviados
        public IActionResult Post(AlunoSaveDTO alunoSave)
        {
            Aluno aluno = _mapper.Map<Aluno>(alunoSave);
            _repository.Add(aluno);
            if (_repository.SaveChanges())
                return Created($"http://localhost/aluno/{aluno.Id}", _mapper.Map<AlunoDTO>(aluno));
            
            return BadRequest("Erro ao Cadastrar Aluno");
        }


        [HttpPut("{id}")] //validar se todos os campos requeridos estão sendo enviados
        public IActionResult Put(int id, AlunoSaveDTO alunoSave)
        {
            Aluno alunoDB = _repository.GetAlunoById(id, true);
            if (alunoDB == null) return BadRequest($"Aluno com Id {id} não encontrado");

            _mapper.Map(alunoSave, alunoDB);
            _repository.Update(alunoDB);

            if (_repository.SaveChanges())
                return Created($"http://localhost/aluno/{alunoDB.Id}", _mapper.Map<AlunoDTO>(alunoDB));
            
            return BadRequest("Erro ao Atualizar Aluno");
        }


        [HttpPatch("{id}")] //permitir a atualização de dados individualmente
        public IActionResult Patch(int id, AlunoSaveDTO alunoSave)
        {
            Aluno alunoDB = _repository.GetAlunoById(id, true);
            if (alunoDB == null) return BadRequest($"Aluno com Id {id} não encontrado");

            _mapper.Map(alunoSave, alunoDB);
            _repository.Update(alunoDB);

            if (_repository.SaveChanges())
                return Created($"http://localhost/aluno/{alunoDB.Id}", _mapper.Map<AlunoDTO>(alunoDB));

            return BadRequest("Erro ao Atualizar Aluno");
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Aluno aluno = _repository.GetAlunoById(id, true);
            if (aluno == null) return BadRequest($"Aluno com Id {id} não encontrado");

            _repository.Delete(aluno);
            if (_repository.SaveChanges())
                return Ok($"Aluno com id {id} removido");
            
            return BadRequest($"Erro ao Remover Aluno com id {id}");
        }
    }
}