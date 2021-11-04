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
    [Route("api/InfoAcademicaComp")]
    [ApiController]
    public class InformacionAcademicaCompController : ControllerBase
    {
        private readonly SQLDbContext _context;
        public InformacionAcademicaCompController(SQLDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InformacionAcademicaComplementaria>>> GetInformacionAcademicaComplementaria()
        {
            return await _context.InformacionAcademicaComplementaria.Select(x => x).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InformacionAcademicaComplementaria>> GetInformacionAcademicaComplementaria(int id)
        {
            var info = await _context.InformacionAcademicaComplementaria.FindAsync(id);
            if (info == null) return NotFound();
            return info;
        }

        [HttpPost]
        public async Task<ActionResult<InformacionAcademicaComplementaria>> PostInformacionAcademicaComplementaria(InformacionAcademicaComplementaria informacionAcademicaComplementaria)
        {
            _context.InformacionAcademicaComplementaria.Add(informacionAcademicaComplementaria);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetInformacionAcademicaComplementaria), new { id = informacionAcademicaComplementaria.IdInformacionAcademicaComplementaria }, informacionAcademicaComplementaria);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInformacionAcademicaComplementaria(int id, InformacionAcademicaComplementaria informacionAcademicaComplementaria)
        {
            if (id != informacionAcademicaComplementaria.IdInformacionAcademicaComplementaria) return BadRequest();
            _context.Entry(informacionAcademicaComplementaria).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!BuscarInfoAcademicaComp(id)) { return NotFound(); }else { throw; }
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInformacionAcademicaComplementaria(int id)
        {
            var info = await _context.InformacionAcademicaComplementaria.FindAsync(id);
            if (info == null) return NotFound();
            _context.InformacionAcademicaComplementaria.Remove(info);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool BuscarInfoAcademicaComp(int id) { return _context.InformacionAcademicaComplementaria.Any(info => id == info.IdInformacionAcademicaComplementaria); }
    }
}
