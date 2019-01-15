using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace JTIData.Models
{
    public class Conductor
    {
        [Key]
        public int ConductorId { get; set; }
        public int DocumentoConductor { get; set; }
        public String PrimerNombre { get; set; }
        public String SegundoNombre { get; set; }
        public String PrimerApellido { get; set; }
        public String SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int NumLicencia { get; set; }

        //public virtual TarjetaConductor TarjetaConductor { get; set; } 

    }
}
