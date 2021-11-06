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

        [Required(ErrorMessage = "Se debe introducir el nombre de la instituci�n")]
        [StringLength(maximumLength: 30, ErrorMessage = "Se necesita un minimo de 3 y maximo de 30 car�cteres", MinimumLength = 3)]
        [Display(Name = "Instituci�n")]
        public string Institucion { get; set; }

        [Required(ErrorMessage = "Se debe introducir el nombre de la acreditaci�n")]
        [StringLength(maximumLength: 15, ErrorMessage = "Se necesita un minimo de 3 y maximo de 15 car�cteres", MinimumLength = 3)]
        [Display(Name = "Idioma")]
        public string Acreditacion { get; set; }

        [Required(ErrorMessage = "Se debe introducir la fecha en la que finaliz� la acreditaci�n")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Graduaci�n")]
        public DateTime FechaGraduacion { get; set; }


        
        
    }
}
