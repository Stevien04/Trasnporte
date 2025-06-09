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
    public class clsReporte_CN
    {
        private clsReporte_DB objReporteDB = new clsReporte_DB();

        public DataTable mtdListarReportes()
        {
            return objReporteDB.mtdListarReporte();
        }

        public void mtdAgregarReporte(clsReporte_CE reporte)
        {
            objReporteDB.mtdAgregarReporteSQL(reporte);
        }

        public void mtdModificarReporte(clsReporte_CE reporte)
        {
            objReporteDB.mtdModificarReporteSQl(reporte);
        }

       

     

    }
}
