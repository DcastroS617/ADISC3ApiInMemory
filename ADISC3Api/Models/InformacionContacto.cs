
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADISC3Api.Models
{
    public class InformacionContacto 
    {
        [Key]
        public int IdInfoContacto { get; set; }

        [Required(ErrorMessage = "Se debe introducir el teléfono celular")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono celular")]
        public string TelefonoCelular { get; set; }

        [Required(ErrorMessage = "Se debe introducir el teléfono del lugar donde trabaja")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono Oficina")]
        public string TelefonoOficina { get; set; }
       
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono Casa")]
        public string TelefonoCasa { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono extra")]
        public string TelefonoExtra { get; set; }

        [Required(ErrorMessage = "Se debe introducir el email correspondiente")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Se debe introducir el apartado postal")]
        [StringLength(maximumLength: 6, ErrorMessage = "Se necesita un minimo de 1 y maximo de 6 carácteres", MinimumLength = 1)]
        [Display(Name = "Apartado Postal")]
        public string ZIP { get; set; }

        [Required(ErrorMessage = "Se debe introducir el contacto de emergencia")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono Emergencia")]
        public string ContactoEmergencia { get; set; }

        [Required(ErrorMessage = "Se debe introducir el teléfono del lugar donde trabaja")]
        [StringLength(maximumLength: 25, ErrorMessage = "Se necesita un minimo de 3 y maximo de 25 carácteres", MinimumLength = 1)]
        [Display(Name = "Contacto Emergencia")]
        public string ContactoEmergenciaNombre { get; set; }

        public InformacionContacto() 
        {

        }
    }
}
