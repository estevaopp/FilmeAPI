using AutoMapper;
using FilmesApi.Data.Dtos.Gerente;
using FilmesApi.Models;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesApi.Profiles
{
    public class GerenteProfile:Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>();
            CreateMap<UpdateGerenteDto, Gerente>();
        }
    }
}
