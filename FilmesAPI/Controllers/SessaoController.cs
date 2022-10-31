using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesApi.Data;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FilmesApi.Models;
using System.Linq;
using FilmesApi.Data.Dtos.Sessao;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController:ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public SessaoController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaCinema([FromBody] CreateSessaoDto sessaoDto)
        {
            Sessao sessao = _mapper.Map<Sessao>(sessaoDto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaSessaoPorId), new { Id = sessao.Id }, sessao);
        }

        [HttpGet]
        public IEnumerable<Sessao> RecuperaCinemas()
        {
            return _context.Sessoes;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessaoPorId(int id)
        {
            Sessao sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);
            if (sessao != null)
            {
                ReadSessaoDto sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);
                return Ok(sessaoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCinema(int id, [FromBody] UpdateSessaoDto sessaoDto)
        {
            Sessao sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);
            if (sessao == null)
            {
                return NotFound();
            }
            _mapper.Map(sessaoDto, sessao);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaCinema(int id)
        {
            Sessao sessao = _context.Sessoes.FirstOrDefault(cinema => cinema.Id == id);
            if (sessao == null)
            {
                return NotFound();
            }
            _context.Remove(sessao);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
