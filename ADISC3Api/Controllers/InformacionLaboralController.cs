using ADISC3Api.Data;
using ADISC3Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADISC3Api
{
    [Route("api/InformacionLaboral")]
    [ApiController]
    public class InformacionLaboralController :ControllerBase
    {
        private readonly SQLDbContext _context;
        public InformacionLaboralController(SQLDbContext context)
        {
            _context = context;
        }
        //GET INFORMACION LABORAL
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InformacionLaboral>>> GetInfoLaboral()
        {
            return await _context.InformacionLaboral.Select(info => info).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InformacionLaboral>> GetInfoLaboral(int id)
        {
            var info = await _context.InformacionLaboral.FindAsync(id);
            if (info == null) return NotFound();
            return info;
        } 

        [HttpPost]
        public async Task<ActionResult<InformacionLaboral>> PostInformacionLaboral(InformacionLaboral informacionLaboral)
        {
            _context.InformacionLaboral.Add(informacionLaboral);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetInfoLaboral), new { id = informacionLaboral.IdInfoLaboral }, informacionLaboral);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInformacionLaboral(int id, InformacionLaboral informacionLaboral)
        {
            if (id != informacionLaboral.IdInfoLaboral) return BadRequest();
            _context.Entry(informacionLaboral).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuscarInfoLaboral(id)) { return NotFound(); } else { throw; }                
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteInformacionLaboral(int id)
        {
            var info = await _context.InformacionLaboral.FindAsync(id);
            if (info == null) return NotFound();
            _context.InformacionLaboral.Remove(info);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool BuscarInfoLaboral(int id) { return _context.InformacionLaboral.Any(info => id == info.IdInfoLaboral); }
    }
}
