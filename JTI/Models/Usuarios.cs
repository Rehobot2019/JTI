using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JTI.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required(ErrorMessage ="Primer Nombre es obligatorio") ]
        public string PrimerNombreUser { get; set; }

        public string SegundoNombreUser { get; set; }

        [Required(ErrorMessage = "Primer Apellido es obligatorio")]
        public string PrimerApellidoUser { get; set; }

        public string SegundoApellidoUser { get; set; }


        [Required(ErrorMessage = "Correo es obligatorio")]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$", ErrorMessage = "Por favor introduzca una dirección de correo valida")]
        public string EmailUser { get; set; }


        [Required(ErrorMessage = "Nombre de Usuario es obligatorio")]
        public string NombreUsuario { get; set; }


        [Required(ErrorMessage = "Password es obligatorio")]
        [DataType(DataType.Password)]
        public string PasswordUser { get; set; }


        [Compare("Password", ErrorMessage ="Por favor confirme su password")]
        [DataType(DataType.Password)]
        public string ConfirmarPasswordUser { get; set; }

    }
}
