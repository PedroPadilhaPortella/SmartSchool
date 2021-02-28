using AutoMapper;
using SmartSchoolAPI.Models;
using SmartSchoolAPI.Helpers;
using SmartSchoolAPI.V2.DTO;

namespace SmartSchoolAPI.V2.Helpers
{
    public class SmartSchoolProfile : Profile
    {
        public SmartSchoolProfile()
        {
            CreateMap<Aluno, AlunoSaveDTO>().ReverseMap();
            CreateMap<AlunoDTO, Aluno>();
            CreateMap<Aluno, AlunoDTO>()
                .ForMember(destiny => destiny.Nome, source => source.MapFrom(aluno => $"{aluno.Nome} {aluno.Sobrenome}"))
                .ForMember(destiny => destiny.Idade, source => source.MapFrom(aluno => aluno.DataNascimento.GetCurrentAge()));
            
            CreateMap<Professor, ProfessorSaveDTO>().ReverseMap();
            CreateMap<ProfessorDTO, Professor>();
            CreateMap<Professor, ProfessorDTO>()
                .ForMember(destiny => destiny.Nome, source => source.MapFrom(prof => $"{prof.Nome} {prof.Sobrenome}"));
        }
    }
}