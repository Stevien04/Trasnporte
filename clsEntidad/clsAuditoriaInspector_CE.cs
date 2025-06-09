using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEntidad
{
    public class clsAuditoriaInspector_CE
    {
        public int IdAuditoria { get; set; }
        public int IdInspector { get; set; }
        public int IdInspectorUsuario { get; set; } // ← Inspector que hizo la acción (logueado)
        public int IdInspectorModificado { get; set; } // ← Inspector que fue modificado
        public string Accion { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public clsAuditoriaInspector_CE() { }
    }
}
