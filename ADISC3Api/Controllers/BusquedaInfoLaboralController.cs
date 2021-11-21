using ADISC3Api.Data;
using ADISC3Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ADISC3Api.Controllers
{
    [Route("api/BuscarLaboral")]
    [ApiController]
    public class BusquedaInfoLaboralController :ControllerBase
    {
        private readonly SQLDbContext _context;
        public BusquedaInfoLaboralController(SQLDbContext context)
        {
            _context = context;
        }

        [HttpGet("{InformacionPersonalId}")]
        public async Task<ActionResult<InformacionLaboral>> BuscarComplementaria(int InformacionPersonalId)
        {

            var prueba = from info in _context.InformacionLaboral select info;

            prueba = prueba.Where(p => p.InformacionPersonalId == InformacionPersonalId);

            await prueba.ToListAsync();
            foreach (var i in prueba)
            {
                if (InformacionPersonalId == i.InformacionPersonalId)
                {
                    return Ok(_context.InformacionLaboral.FromSqlRaw("Select * from [dbo].[InformacionLaboral]").Where(p => p.InformacionPersonalId == InformacionPersonalId));
                }
            }
            return NotFound();
        }
    }
}
