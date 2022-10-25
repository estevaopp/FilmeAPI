using AutoMapper;
using FilmesAPI.Models;
using FilmesAPI.Models.Dtos;

namespace FilmesAPI.Profiles
{
    public class FilmeProfile:Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<UpdateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
        }
    }
}
