using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UESAN.GESTIONTALLER.CORE.Core.Entities;
using UESAN.GESTIONTALLER.CORE.Infrastructure.Data; // Ajusta si tus entidades están en otro namespace

namespace UESAN.GESTIONTALLER.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoServiciosController : ControllerBase
    {
        private readonly TallerDbContext _context;

        public TipoServiciosController(TallerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.TipoServicio.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Post(TipoServicio tipoServicio)
        {
            _context.TipoServicio.Add(tipoServicio);
            await _context.SaveChangesAsync();
            return Ok(tipoServicio);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TipoServicio tipoServicio)
        {
            if (id != tipoServicio.Id) return BadRequest();
            _context.Entry(tipoServicio).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var tipo = await _context.TipoServicio.FindAsync(id);
            if (tipo == null) return NotFound();
            _context.TipoServicio.Remove(tipo);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
