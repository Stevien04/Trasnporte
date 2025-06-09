using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsDatos;
using clsEntidad;

namespace clsNegocio
{
    public class clsAuditoria_CN
    {
        private clsAuditoria_DB datos = new clsAuditoria_DB();

        public void mtdRegistrarAuditoria(clsAuditoriaInspector_CE auditoria)
        {
            datos.mtdRegistrarAuditoria(auditoria);
        }

        public clsAuditoriaInspector_CE ObtenerUltimaAuditoriaPorInspector(int idInspector)
        {
            return datos.ObtenerUltimaAuditoriaPorInspector(idInspector);
        }
    }
}
