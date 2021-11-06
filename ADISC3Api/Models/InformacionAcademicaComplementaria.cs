using Microsoft.AspNetCore.Builder;

using System;
using System.ComponentModel.DataAnnotations;

namespace ADISC3Api.Models
{
    public class InformacionAcademicaComplementaria
    {
        public InformacionAcademicaComplementaria() { }
        [Key]
        public int IdInformacionAcademicaComp { get; set; }

        [Required(ErrorMessage = "Se debe introducir el nombre de la institución")]
        [StringLength(maximumLength: 30, ErrorMessage = "Se necesita un minimo de 3 y maximo de 30 carácteres", MinimumLength = 3)]
        [Display(Name = "Institución")]
        public string Institucion { get; set; }

        [Required(ErrorMessage = "Se debe introducir el nombre de la acreditación")]
        [StringLength(maximumLength: 15, ErrorMessage = "Se necesita un minimo de 3 y maximo de 15 carácteres", MinimumLength = 3)]
        [Display(Name = "Idioma")]
        public string Acreditacion { get; set; }

        [Required(ErrorMessage = "Se debe introducir la fecha en la que finalizó la acreditación")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Graduación")]
        public DateTime FechaGraduacion { get; set; }


        
        
    }
}
