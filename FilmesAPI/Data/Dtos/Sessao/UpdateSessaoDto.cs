using FilmesAPI.Models;
using System.ComponentModel.DataAnnotations;
using System;

namespace FilmesApi.Data.Dtos.Sessao
{
    public class UpdateSessaoDto
    {
        public int CinemaId { get; set; }
        public int FilmeId { get; set; }
        public DateTime HorarioDeInicio { get; set; }
    }
}
