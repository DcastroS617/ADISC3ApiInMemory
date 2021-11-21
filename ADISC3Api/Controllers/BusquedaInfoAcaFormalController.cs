using ADISC3Api.Data;
using ADISC3Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ADISC3Api.Controllers
{
    [Route("api/BusquedaFormal")]
    [ApiController]
    public class BusquedaInfoAcaFormalController : ControllerBase
    {
        private readonly SQLDbContext _context;
        public BusquedaInfoAcaFormalController(SQLDbContext context)
        {
            _context = context;
        }

        [HttpGet("{InformacionPersonalId}")]
        public async Task<ActionResult<InformacionAcademicaFormal>> BusquedaInfoFormal(int InformacionPersonalId)
        {
            var prueba = from info in _context.InformacionAcademicaFormal select info;
           
            prueba = prueba.Where(p => p.InformacionPersonalId == InformacionPersonalId);
            
            await prueba.ToListAsync();
            foreach (var i in prueba)
            {
                if (InformacionPersonalId == i.InformacionPersonalId)
                {                   
                    return Ok(_context.InformacionAcademicaFormal.FromSqlRaw("SELECT * FROM [dbo].[InformacionAcademicaFormal]").Where(b => b.InformacionPersonalId == InformacionPersonalId));                    
                }
            }
            return NotFound();
        }
    }
}
