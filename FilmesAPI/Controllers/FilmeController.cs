using AutoMapper;
using FilmesAPI.Context;
using FilmesAPI.Models;
using FilmesAPI.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private FilmeDbContext _context;
        private IMapper _mapper;

        public FilmeController(FilmeDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
        {
            Filme filme = _mapper.Map<Filme>(filmeDto);         
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaFilmePorId), new {Id = filme.Id}, filme);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes()
        {
            return _context.Filmes;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmePorId(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(x => x.Id == id);
            if (filme==null)
            {
                return NotFound();
            }
            ReadFilmeDto filmeDto = _mapper.Map<ReadFilmeDto>(filme);
            filmeDto.HoraDaConsulta = DateTime.Now;
            return Ok(filmeDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
        {
            Filme filme = _context.Filmes.FirstOrDefault(x => x.Id == id);
            if (filme==null)
            {
                return NotFound();
            }
            _mapper.Map(filmeDto, filme);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluiFilmePorId(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(x => x.Id == id);
            if (filme == null)
            {
                return NotFound();
            }  
            _context.Filmes.Remove(filme);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
