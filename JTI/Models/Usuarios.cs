using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace JTI.Models
{
    public class Usuarios
    {
        [TempData]
        public String ErrorMessage { get; set; }

        [Required(ErrorMessage = "Nombre de Usuario es Obligatorio")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "Contraseña es Obligatoria")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage ="El número de caracteres de {0} debe ser al menos {2}", MinimumLength =6)]
        public string Password { get; set; }
        
        /*[Key]
        public int IdUsuario { get; set; }


        [Required(ErrorMessage ="Primer Nombre es obligatorio") ]
        [Display(Name = "Primer Nombre: ")]
        public string PrimerNombreUser { get; set; }

        [Display(Name = "Segundo Nombre: ")]
        public string SegundoNombreUser { get; set; }

        [Required(ErrorMessage = "Primer Apellido es obligatorio")]
        [Display(Name = "Primer Apellido: ")]
        public string PrimerApellidoUser { get; set; }

        [Display(Name = "Segundo Apellido: ")]
        public string SegundoApellidoUser { get; set; }


        [Required(ErrorMessage = "Correo es obligatorio")]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$", ErrorMessage = "Por favor introduzca una dirección de correo valida")]
        [Display(Name = "Correo Electrónico: ")]
        public string EmailUser { get; set; }


        [Required(ErrorMessage = "Nombre de Usuario es obligatorio")]
        [Display(Name = "Nombre de Usuario: ")]
        public string NombreUsuario { get; set; }


        [Required(ErrorMessage = "Password es obligatorio")]
        [Display(Name = "Password: ")]
        [DataType(DataType.Password)]
        public string PasswordUser { get; set; }


        [Compare("Password", ErrorMessage ="Por favor confirme su password")]
        [Display(Name = "Confirme Password: ")]
        [DataType(DataType.Password)]
        public string ConfirmarPasswordUser { get; set; }*/

        

    }
}
