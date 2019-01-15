using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JTIData.Models;

namespace JTIData.Models
{
    public class Conductores
    {
        public int IdConductor { get; set; }
        public int DocumentoConductor { get; set; }
        public String PrimerNombre { get; set; }
        public String SegundoNombre { get; set; }
        public String PrimerApellido { get; set; }
        public String SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int NumLicencia { get; set; }
    }
}
