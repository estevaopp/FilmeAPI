using AutoMapper;
using FilmesApi.Data.Dtos.Sessao;
using FilmesAPI.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class SessaoProfile:Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>()
                .ForMember(dto => dto.HorarioDeEncerramento, opts => opts
                .MapFrom(dto => 
                dto.HorarioDeInicio.AddMinutes(dto.Filme.Duracao)));
            CreateMap<UpdateSessaoDto, Sessao>();
        }
    }
}
