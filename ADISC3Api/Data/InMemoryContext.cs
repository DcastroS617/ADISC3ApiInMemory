using ADISC3Api.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ADISC3Api.Data
{
    public class InMemoryContext : DbContext
    {
        public InMemoryContext(DbContextOptions op) : base(op) { }
        public DbSet<InformacionPersonal> InformacionPersonal { get; set; }
        public DbSet<InformacionContacto> InformacionContacto { get; set; }
        public DbSet<InformacionDireccion> InformacionDireccion { get; set; }
        public DbSet<InformacionLaboral> InformacionLaboral { get; set; }
        public DbSet<InformacionAcademicaFormal> InformacionAcademicaFormal { get; set; }
        public DbSet<InformacionAcademicaComplementaria> InformacionAcademicaComplementaria { get; set; }
        public DbSet<InformacionAcademicaIdioma> InformacionAcademicaIdioma { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}
