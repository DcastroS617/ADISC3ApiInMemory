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
    [Route("api/InfoDireccion")]
    [ApiController]
    public class InformacionDireccionController : ControllerBase
    {
        private readonly InMemoryContext _context;
        public InformacionDireccionController(InMemoryContext context)
        {
            _context = context;
        }
        //GET INFORMACION DIRECCION
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InformacionDireccion>>> GetInfoDireccion()
        {
            return await _context.InformacionDireccion.Select(info => info).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InformacionDireccion>> GetInfoDireccion(int id) 
        {
            var info = await _context.InformacionDireccion.FindAsync(id);
            if (info == null) return NotFound();
            return info;
        }

        //POST INFORMACION DIRECCION
        [HttpPost]
        public async Task<ActionResult<InformacionDireccion>> PostInfoDireccion(InformacionDireccion informacionDireccion)
        {
            _context.InformacionDireccion.Add(informacionDireccion);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetInfoDireccion), new { id = informacionDireccion.IdInformacionDireccion }, informacionDireccion);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInfoDireccion(int id, InformacionDireccion informacionDireccion)
        {
            if (id != informacionDireccion.IdInformacionDireccion) return BadRequest();
            _context.Entry(informacionDireccion).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuscarInfoDireccion(id)) { return NotFound(); } else { throw; }
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInfoDireccion(int id)
        {
            var info = await _context.InformacionDireccion.FindAsync(id);
            if (info == null) return NotFound();
            _context.InformacionDireccion.Remove(info);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool BuscarInfoDireccion(int id) { return _context.InformacionDireccion.Any(info => id == info.IdInformacionDireccion); }
    }
}
