using ADISC3Api.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADISC3Api.Data
{
    public class SQLDbContext : DbContext
    {
        public SQLDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<InformacionPersonal> InformacionPersonal { get; set; }
        public DbSet<InformacionContacto> InformacionContacto { get; set; }
        public DbSet<InformacionDireccion> InformacionDireccion { get; set; }
        public DbSet<InformacionLaboral> InformacionLaboral { get; set; }
        public DbSet<InformacionAcademicaFormal> InformacionAcademicaFormal { get; set; }
        public DbSet<InformacionAcademicaComplementaria> InformacionAcademicaComplementaria { get; set; }
        public DbSet<InformacionAcademicaIdioma> InformacionAcademicaIdioma { get; set; }
    }
}
