using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Context
{
    public class FilmeDbContext:DbContext
    {
        public FilmeDbContext(DbContextOptions<FilmeDbContext> opts) : base(opts)
        {
                        
        }

        public DbSet<Filme> Filmes { get; set; }
    }
}
