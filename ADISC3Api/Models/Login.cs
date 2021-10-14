using System;
using System.ComponentModel.DataAnnotations;

namespace ADISC3Api.Models
{
    public class Login
    {
        public Login() { }
        [Key]
        public int IdLogin { get; set; }
        [Required(ErrorMessage = "Se debe introducir para iniciar sesión")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un minimo de 3 y maximo de 50 carácteres", MinimumLength = 3)]
        [Display(Name = "Cedula Empleado")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Se debe introducir la contraseña para iniciar sesión")]
        [StringLength(maximumLength: 50, ErrorMessage = "Se necesita un minimo de 3 y maximo de 50 carácteres", MinimumLength = 3)]
        [Display(Name = "Contraseña Empleado")]
        public string Contrasena { get; set; }
    }
}
