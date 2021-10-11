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
    [Route("api/InfoContacto")]
    [ApiController]
    public class InformacionContactoController : ControllerBase
    {
        public readonly InMemoryContext _context;
        public InformacionContactoController(InMemoryContext context)
        {
            _context = context;
        }

        //GET INFORMACION CONTACTO
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InformacionContacto>>> GetInformacionContacto()
        {
            return await _context.InformacionContacto.Select(info => info).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InformacionContacto>> GetInformacionContacto(int id)
        {
            var info = await _context.InformacionContacto.FindAsync(id);
            if (info == null) return NotFound();
            return info;
        }

        //POST INFORMACION CONTACTO
        [HttpPost]
        public async Task<ActionResult<InformacionContacto>> PostInformacionContacto(InformacionContacto informacionContacto)
        {
            //informacionContacto.Email = "PerroKreisi@gmail.com"; si funciona!!!!!!bhdjhjosadjihasdipojbsafojunjer
            _context.InformacionContacto.Add(informacionContacto);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetInformacionContacto), new { id = informacionContacto.IdInfoContacto }, informacionContacto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInformacionContacto(int id, InformacionContacto informacionContacto)
        {
            if (id != informacionContacto.IdInfoContacto) return BadRequest();
            _context.Entry(informacionContacto).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException) 
            {
                if (!BuscarInfoContacto(id)) { return NotFound(); } else { throw; }
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInfoContacto(int id)
        {
            var info = await _context.InformacionContacto.FindAsync(id);
            if (info == null) return NotFound();
            _context.InformacionContacto.Remove(info);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool BuscarInfoContacto(int id) { return _context.InformacionContacto.Any(info => id == info.IdInfoContacto); }
    }
}
