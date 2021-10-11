
using System;
using System.ComponentModel.DataAnnotations;

namespace ADISC3Api.Models
{
    public class InformacionLaboral 
    {
        [Key]
        public int IdInfoLaboral { get; set; }

        [Required(ErrorMessage = "Se debe introducir el nombre de la institución en la que laboró")]
        [StringLength(maximumLength: 30, ErrorMessage = "Se necesita un minimo de 3 y maximo de 30 carácteres", MinimumLength = 3)]
        [Display(Name = "Idioma")]
        public string Institucion { get; set; }

        [Required(ErrorMessage = "Se debe introducir la fecha en la que inició")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de inicio")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "Se debe introducir la fecha en la que finalizó")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Final")]
        public DateTime FechaFinal { get; set; }
        public InformacionLaboral() 
        {

        }
    }
}
