using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADISC3Api.Models
{
    public class InformacionPersonal
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se debe introducir el nombre")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un minimo de 3 y maximo de 50 carácteres", MinimumLength = 3)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Se debe introducir el Primer Apellido")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un minimo de 3 y maximo de 50 carácteres", MinimumLength = 3)]
        [Display(Name = "Primer Apellido")]
        public string PrimerApellido { get; set; }

        [Required(ErrorMessage = "Se debe introducir el Segundo Apellido")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un minimo de 3 y maximo de 50 carácteres", MinimumLength = 3)]
        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }

        [Required(ErrorMessage = "Se debe introducir la cédula")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un minimo de 3 y maximo de 50 carácteres", MinimumLength = 3)]
        [Display(Name = "Cédula")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Se debe introducir la fecha de nacimiento")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Se debe introducir el número de Asegurado")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un mínimo de 3 y máximo de 50 carácteres", MinimumLength = 3)]
        [Display(Name = "Número Asegurado")]
        public string NumeroAsegurado { get; set; }

        [Required(ErrorMessage = "Se debe introducir el estado civil")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un minimo de 3 y maximo de 50 carácteres", MinimumLength = 3)]
        [Display(Name = "Estado Civil")]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = "Se debe introducir El tipo de sangre")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un minimo de 3 y maximo de 50 carácteres", MinimumLength = 1)]
        [Display(Name = "Tipo de Sangre")]
        public string TipoSangre { get; set; }

        [Required(ErrorMessage = "Se debe introducir la cuenta bancaria")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un minimo de 3 y maximo de 50 carácteres", MinimumLength = 3)]
        [Display(Name = "Cuenta Bancaria")]
        public string CuentaBancaria { get; set; }

        [Required(ErrorMessage = "Se debe introducir el banco especifico de la cuenta bancaria")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un minimo de 3 y maximo de 50 carácteres", MinimumLength = 3)]
        [Display(Name = "Banco")]
        public string BancoEspecifico { get; set; }

        [Required(ErrorMessage = "Se debe introducir la contraseña")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un minimo de 3 y maximo de 50 carácteres", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; }

        public virtual ICollection<InformacionAcademicaIdioma> InformacionAcademicaIdioma { get; set; }
        public virtual ICollection<InformacionAcademicaFormal> InformacionAcademicaFormal { get; set; }
        public virtual ICollection<InformacionAcademicaComplementaria> AcademicaComplementaria { get; set; }
        public virtual ICollection<InformacionLaboral> InformacionLaboral { get; set; }
        public InformacionPersonal() { }
    }
}
