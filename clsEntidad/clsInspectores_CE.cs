using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEntidad
{
    public class clsInspectores_CE
    {
        public int id_inspector {  get; set; }
        public string nombre { get; set; }
        public string Apellido { get; set; }
        public string dni {  get; set; }
        public DateTime fecha_in {  get; set; }
        public DateTime fecha_fin { get; set; }
        public string categoria { get; set; }
        public string ruc {  get; set; }
        public string Fotografia { get; set; }
        public string Estado { get; set; }

        public clsInspectores_CE() { }
    }
}
