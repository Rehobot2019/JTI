using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace JTI.Models
{
    public class ModeloLogin
    {
        [Required(ErrorMessage ="Nombre de Usuario es Obligatorio")]
        [Display(Name = "Nombre de Usuario: ")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "Contraseña es Obligatoria")]
        [Display(Name = "Contraseña: ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Recordarme ")]
        public bool Recordarme { get; set; }

    }
}
