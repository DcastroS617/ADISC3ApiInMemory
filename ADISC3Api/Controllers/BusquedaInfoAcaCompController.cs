using ADISC3Api.Data;
using ADISC3Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ADISC3Api
{
    [Route("api/BuscarComp")]
    [ApiController]
    public class BusquedaInfoAcaComp :ControllerBase
    {
        private readonly SQLDbContext _context;
        public BusquedaInfoAcaComp(SQLDbContext context)
        {
            _context = context;
        }

        [HttpGet("{InformacionPersonalId}")]
        public async Task<ActionResult<InformacionAcademicaComplementaria>> BuscarComplementaria(int InformacionPersonalId)
        {

            var prueba = from info in _context.InformacionAcademicaComplementaria select info;

            prueba = prueba.Where(p => p.InformacionPersonalId == InformacionPersonalId);

            await prueba.ToListAsync();
            foreach (var i in prueba)
            {
                if (InformacionPersonalId == i.InformacionPersonalId)
                {
                    return Ok(_context.InformacionAcademicaComplementaria.FromSqlRaw("Select * from [dbo].[InformacionAcademicaComplementaria]").Where(p => p.InformacionPersonalId == InformacionPersonalId));
                }
            }
            return NotFound();
        }
    }
}
