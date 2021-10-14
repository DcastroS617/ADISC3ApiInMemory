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
    [Route("api/InfoAcademicaFormal")]
    [ApiController]
    public class InformacionAcademicaFormalController : ControllerBase
    {
        private readonly SQLDbContext _context;
        public InformacionAcademicaFormalController(SQLDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InformacionAcademicaFormal>>> GetInfoAcademicaFormal()
        {
            return await _context.InformacionAcademicaFormal.Select(x => x).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InformacionAcademicaFormal>> GetInfoAcademicaFormal(int id)
        {
            var info = await _context.InformacionAcademicaFormal.FindAsync(id);
            if (info == null) return NotFound();
            return info;
        }

        [HttpPost]
        public async Task<ActionResult<InformacionAcademicaFormal>> PostInformacionAcademicaFormal(InformacionAcademicaFormal informacionAcademicaFormal)
        {
            _context.InformacionAcademicaFormal.Add(informacionAcademicaFormal);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetInfoAcademicaFormal), new { id = informacionAcademicaFormal.IdInformacionAcademica }, informacionAcademicaFormal);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInformacionAcademicaFormal(int id, InformacionAcademicaFormal informacionAcademicaFormal)
        {
            if (id != informacionAcademicaFormal.IdInformacionAcademica) return BadRequest();
            _context.Entry(informacionAcademicaFormal).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!BuscarInformacionAcademicaFormal(id)) { return NotFound(); } else { throw; }
            }
            return NoContent();
        }
        private bool BuscarInformacionAcademicaFormal(int id) { return _context.InformacionAcademicaFormal.Any(info => id == info.IdInformacionAcademica); }
    }
}
