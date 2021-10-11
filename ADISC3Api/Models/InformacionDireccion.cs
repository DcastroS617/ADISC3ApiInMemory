
using System;
using System.ComponentModel.DataAnnotations;

namespace ADISC3Api.Models
{
    public class InformacionDireccion
    {
        [Key]
        public int IdInformacionDireccion { get; set; }

        [Required(ErrorMessage = "Se debe introducir la provincia de procedencia")]
        [StringLength(maximumLength: 12, ErrorMessage = "Se necesita un minimo de 1 y maximo de 12 carácteres", MinimumLength = 1)]
        [Display(Name = "Provincia")]
        public string Provincia { get; set; }

        [Required(ErrorMessage = "Se debe introducir el cantón de procedencia")]
        [StringLength(maximumLength: 35, ErrorMessage = "Se necesita un minimo de 1 y maximo de 35 carácteres", MinimumLength = 1)]
        [Display(Name = "Cantón")]
        public string Canton { get; set; }

        [Required(ErrorMessage = "Se debe introducir el distrito de procedencia")]
        [StringLength(maximumLength:40, ErrorMessage = "Se necesita un minimo de 1 y maximo de 40 carácteres", MinimumLength = 1)]
        [Display(Name = "Distrito")]
        public string Distrito { get; set; }

        [Required(ErrorMessage = "Se debe introducir la dirección exacta")]
        [StringLength(maximumLength: 150, ErrorMessage = "Se necesita un minimo de 1 y maximo de 150 carácteres", MinimumLength = 1)]
        [Display(Name = "Dirección Exacta")]
        public string DireccionExacta { get; set; }

        public InformacionDireccion() { }
    }
}
