
using ADISC3Api.Data;
using ADISC3Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADISC3Api.Controllers
{
    [Route("api/InfoAcademicaIdioma")]
    [ApiController]
    public class InformacionAcademicaIdiomaController : ControllerBase
    {
        private readonly SQLDbContext _context;
        public InformacionAcademicaIdiomaController(SQLDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InformacionAcademicaIdioma>>> GetInfoAcademicaIdioma()
        {
            return await _context.InformacionAcademicaIdioma.Select(info => info).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InformacionAcademicaIdioma>> GetInfoAcademicaIdioma(int id)
        {
            var info = await _context.InformacionAcademicaIdioma.FindAsync(id);
            if (info == null) return NotFound();
            return info;
        }

        [HttpPost]
        public async Task<ActionResult<InformacionAcademicaIdioma>> PostInfoAcademicaIdioma(InformacionAcademicaIdioma informacionAcademicaIdioma)
        {
            _context.InformacionAcademicaIdioma.Add(informacionAcademicaIdioma);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetInfoAcademicaIdioma), new { id = informacionAcademicaIdioma.IdInformacionAcademica }, informacionAcademicaIdioma);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInfoAcademicaIdioma(int id, InformacionAcademicaIdioma informacionAcademicaIdioma)
        {
            if (id != informacionAcademicaIdioma.IdInformacionAcademica) return BadRequest();
            _context.Entry(informacionAcademicaIdioma).State = EntityState.Modified;
            try 
            {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) 
            {
                if (!BuscarInfoAcademicaIdioma(id)){ return NotFound(); } else { throw; };
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInfoAcademicaIdioma(int id)
        {
            var info = await _context.InformacionAcademicaIdioma.FindAsync(id);
            if (info == null) return NotFound();
            _context.InformacionAcademicaIdioma.Remove(info);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool BuscarInfoAcademicaIdioma(int id) { return _context.InformacionAcademicaIdioma.Any(info => id == info.IdInformacionAcademica); }

    }
}
