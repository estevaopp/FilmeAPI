using Microsoft.AspNetCore.Authorization;

namespace FilmesApi.Authorization
{
    public class IdadeMinimaRequirement : IAuthorizationRequirement
    {
        public int IdadeMinima { get; set; }
        public IdadeMinimaRequirement(int idadeMinima)
        {
            this.IdadeMinima = idadeMinima;
        }
    }
}
