using ADISC3Api.Data;
using ADISC3Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ADISC3Api.Controllers
{   
    [Route("api/BusquedaCedula")]
    [ApiController]
    public class BusquedaCedulaController : ControllerBase
    {
        private readonly SQLDbContext _context;
        public BusquedaCedulaController(SQLDbContext context)
        {
            _context = context;
        }

        [HttpGet("{Cedula}")]
        public async Task<ActionResult<InformacionPersonal>> BusquedaCedula(string cedula)
        {
            var persona = from p in _context.InformacionPersonal select p;
            if (!String.IsNullOrEmpty(cedula))
            {
                persona = persona.Where(p => p.Cedula.Contains(cedula));
            }
            await persona.ToListAsync();
            foreach (var i in persona)
            {
                if (i.Cedula == cedula)
                {
                    var SendIt = await _context.InformacionPersonal.FindAsync(i.IdInfoPersonal);
                    return Ok(SendIt);
                }
            }
            return NotFound();
        }
    }
}
