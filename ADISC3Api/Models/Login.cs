using System;
using System.ComponentModel.DataAnnotations;

namespace ADISC3Api.Models
{
    public class Login
    {
        public Login() { }
        [Key]
        public int IdLogin { get; set; }
        [Required(ErrorMessage = "Se debe introducir para iniciar sesi�n")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un minimo de 3 y maximo de 50 car�cteres", MinimumLength = 3)]
        [Display(Name = "Cedula Empleado")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Se debe introducir la contrase�a para iniciar sesi�n")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un minimo de 3 y maximo de 50 car�cteres", MinimumLength = 3)]
        [Display(Name = "Contrase�a Empleado")]
        public string Contrasena { get; set; }
    }
}
