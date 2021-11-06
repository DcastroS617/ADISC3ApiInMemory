using Microsoft.AspNetCore.Builder;

using System;
using System.ComponentModel.DataAnnotations;

namespace ADISC3Api.Models
{
    public class InformacionAcademicaIdioma
    {
        public InformacionAcademicaIdioma() { }
        [Key]
        public int IdInformacionAcademicaIdioma { get; set; }

        [Required(ErrorMessage = "Se debe introducir el nombre del idioma")]
        [StringLength(maximumLength: 30, ErrorMessage = "Se necesita un minimo de 3 y maximo de 30 carácteres", MinimumLength = 3)]
        [Display(Name = "Idioma")]
        public string Idioma { get; set; }

        [Required(ErrorMessage = "Se debe introducir el nivel")]
        [StringLength(maximumLength: 20, ErrorMessage = "Se necesita un minimo de 3 y maximo de 20 carácteres", MinimumLength = 3)]
        [Display(Name = "Nivel Academico")]
        public string Nivel { get; set; }
        
    }
}
