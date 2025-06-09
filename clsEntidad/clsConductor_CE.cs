using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEntidad
{
    public class clsConductor_CE
    {
        public int IdConductor { get; set; }
        public string Dni { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string VigenciaLicencia { get; set; }
        public string TipoLicencia { get; set; }
        public string Fotografia { get; set; }

        public clsConductor_CE() { }
    }
}
