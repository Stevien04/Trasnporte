using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEntidad
{
    public class clsReporte_CE
    {
        public int Id_Reporte { get; set; }               // id_Reporte
        public DateTime Fecha { get; set; }               // Fecha
        public TimeSpan Hora { get; set; }                // Hora
        public string Ubicacion { get; set; }             // Ubicacion
        public string Descripcion { get; set; }           // Descripcion
        public int Id_Inspector { get; set; }             // id_inspector
        public int Id_Vehiculo { get; set; }              // id_vehiculo
        public string Foto_Video { get; set; }            // foto_video (nullable)
        public string Estado_Revision { get; set; }       // estado_revision

        
       
    }
}
