using FilmesAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos.Gerente
{
    public class UpdateGerenteDto
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
    }
}
