using ADISC3Api.Data;
using ADISC3Api.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADISC3Api.Controllers
{
    [Route("api/InformacionPersonal")]
    [ApiController]
    public class InformacionPersonalController : ControllerBase
    {
        private readonly SQLDbContext _context;

        public InformacionPersonalController(SQLDbContext context)
        {
            _context = context;
        }

        [Route("Login")]
        [HttpPost]
        public async Task<ActionResult<InformacionPersonal>> Login(Login login)
        {           
            var ced = await _context.Login.AnyAsync(x => x.Cedula == login.Cedula);
            var con = await _context.Login.AnyAsync(x => x.Contrasena == login.Contrasena);           
            if (ced && con) 
            {               
                return NoContent();
            }
            return NotFound();
        }

        [Route("GetLogin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Login>>> GetLogin()
        {
            return await _context.Login.Select(info => info).ToListAsync();
        }

        //GET INFORMACION PERSONAL
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InformacionPersonal>>> getInformacionPersonal()
        {
            return await _context.InformacionPersonal.Select(Info => Info).ToListAsync();
        }
        
        //POST INFORMACION PERSONAL
        [HttpPost]
        public async Task<ActionResult<InformacionPersonal>> PostInformacionPersonal(InformacionPersonal informacionPersonal)
        {
            var login = new Login() { Cedula = informacionPersonal.Cedula, Contrasena = informacionPersonal.Contrasena };
            _context.InformacionPersonal.Add(informacionPersonal);
            _context.Login.Add(login);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(getInformacionPersonal), new { id = informacionPersonal.Id }, informacionPersonal);
        }

        //GET BY ID INFORMACION PERSONAL
        [HttpGet("{id}")]
        public async Task<ActionResult<InformacionPersonal>> GetInformacionPersonal(int id)
        {
            var persona = await _context.InformacionPersonal.FindAsync(id);
            if (persona == null) return NotFound();
            return persona;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInformacionPersonal(int id, InformacionPersonal informacionPersonal)
        {
            if (id != informacionPersonal.Id) return BadRequest();
            _context.Entry(informacionPersonal).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuscaInfoPersonal(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInformacionPersonal(int id)
        {
            var Info = await _context.InformacionPersonal.FindAsync(id);
            var Login = await _context.Login.FindAsync(id);
            if (Info == null) return NotFound();
            _context.InformacionPersonal.Remove(Info);
            _context.Login.Remove(Login);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool BuscaInfoPersonal(int id) { return _context.InformacionPersonal.Any(info => id == info.Id); }
    }
}
//[Route("GetSpecific")]//Controller dentro de controller, con la routa se define
//[HttpGet]
//public IEnumerable<WeatherForecast> GetSpecific()
//{
//    int Temperature = 0;
//    Temperature = (int)(Temperature + (Temperature * 0.12));
//    foreach (var i in GetLista())
//    {
//        Temperature = i.TemperatureC;
//    }
//    return Enumerable.Range(1, GetLista().Count()).Select(Temp => new WeatherForecast
//    {
//        Date = DateTime.Now,
//        TemperatureC = Temperature,
//        Summary = "Probando cambios"
//    }).ToList();
//}