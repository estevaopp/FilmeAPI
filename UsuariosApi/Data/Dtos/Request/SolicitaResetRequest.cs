using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Data.Dtos.Request
{
    public class SolicitaResetRequest
    {
        [Required]
        public string Email { get; set; }
    }
}
