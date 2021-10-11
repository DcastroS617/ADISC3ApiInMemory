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

        [Required(ErrorMessage = "Se debe introducir el nombre de la institución")]
        [StringLength(maximumLength: 25, ErrorMessage = "Se necesita un minimo de 3 y maximo de 25 carácteres", MinimumLength = 3)]
        [Display(Name = "Institución")]
        public string Institucion { get; set; }

        [Required(ErrorMessage = "Se debe introducir el nombre de la acreditación")]
        [StringLength(maximumLength: 60, ErrorMessage = "Se necesita un minimo de 3 y maximo de 60 carácteres", MinimumLength = 3)]
        [Display(Name = "Acreditación")]
        public string Acreditacion { get; set; }

        [Required(ErrorMessage = "Se debe introducir la fecha en la que finalizó")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Graduación")]
        public DateTime FechaGraduacion { get; set; }
        
    }
}
