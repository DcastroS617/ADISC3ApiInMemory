
using ADISC3Api.Data;
using ADISC3Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ADISC3Api.Controllers
{
    [Route("api/BuscarIdioma")]
    [ApiController]
    public class BusquedaInfoAcaIdiomaController :ControllerBase
    {
        private readonly SQLDbContext _context;
        public BusquedaInfoAcaIdiomaController(SQLDbContext context)
        {
            _context = context;
        }

        [HttpGet("{InformacionPersonalId}")]
        public async Task<ActionResult<InformacionAcademicaIdioma>> BuscarComplementaria(int InformacionPersonalId)
        {

            var prueba = from info in _context.InformacionAcademicaIdioma select info;

            prueba = prueba.Where(p => p.InformacionPersonalId == InformacionPersonalId);

            await prueba.ToListAsync();
            foreach (var i in prueba)
            {
                if (InformacionPersonalId == i.InformacionPersonalId)
                {
                    return Ok(_context.InformacionAcademicaIdioma.FromSqlRaw("Select * from [dbo].[InformacionAcademicaIdioma]").Where(p => p.InformacionPersonalId == InformacionPersonalId));
                }
            }
            return NotFound();
            //;

        }
    }
}
