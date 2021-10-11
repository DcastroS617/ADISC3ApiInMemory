using Microsoft.AspNetCore.Builder;

using System;
using System.ComponentModel.DataAnnotations;

namespace ADISC3Api.Models
{
    public class InformacionAcademicaFormal
    {
        public InformacionAcademicaFormal() { }
        [Key]
        public int IdInformacionAcademica { get; set; }

        [Required(ErrorMessage = "Se debe introducir el nombre de la instituci�n")]
        [StringLength(maximumLength: 25, ErrorMessage = "Se necesita un minimo de 3 y maximo de 25 car�cteres", MinimumLength = 3)]
        [Display(Name = "Instituci�n")]
        public string Institucion { get; set; }

        [Required(ErrorMessage = "Se debe introducir el nombre de la acreditaci�n")]
        [StringLength(maximumLength: 60, ErrorMessage = "Se necesita un minimo de 3 y maximo de 60 car�cteres", MinimumLength = 3)]
        [Display(Name = "Acreditaci�n")]
        public string Acreditacion { get; set; }

        [Required(ErrorMessage = "Se debe introducir la fecha en la que finaliz�")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Graduaci�n")]
        public DateTime FechaGraduacion { get; set; }
        
    }
}
