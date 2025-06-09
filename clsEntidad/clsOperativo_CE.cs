using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsEntidad;

namespace clsEntidad
{
    public class clsOperativo_CE
    {
        public int IdOperativo { get; set; }
        public DateTime FechaOperativo { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int CantidadPolicias { get; set; }
        public int CantidadInspectores { get; set; }
        public string Direccion { get; set; }
        public string MotivoOperativo { get; set; }
        public string Resultado { get; set; }
        public string UbicacionDocumento { get; set; }

        public clsOperativo_CE() { }
    }
}
