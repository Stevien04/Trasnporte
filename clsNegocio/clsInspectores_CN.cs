using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsDatos;
using clsEntidad;

namespace clsNegocio
{
    public class clsInspectores_CN
    {
        private clsInspectores_DB db = new clsInspectores_DB();

        public DataTable mtdObtenerInspectores()
        {
            return db.mtdListarInspectores();
        }

        public void mtdAgregarInspector(clsInspectores_CE inspectores)
        {
            db.mtdAgregarInspectoresSQL(inspectores);
        }

        public void mtdModificarInspectores(clsInspectores_CE inspectores)
        {
            db.mtdModificarInspectoresSQl(inspectores);
        }

        public DataTable mtdBuscarInspectoresPorIdONombre(string filtro)
        {
            return db.mtdBuscarInspectoresPorIdONombre(filtro);
        }
    }
}
