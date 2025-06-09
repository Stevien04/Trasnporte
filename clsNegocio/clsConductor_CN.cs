using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using clsDatos;
using clsEntidad;

namespace clsNegocio
{
    public class clsConductor_CN
    {
        private clsConductor_DB db = new clsConductor_DB();

        public DataTable mtdObtenerConductores()
        {
            return db.mtdListarConductores();
        }

        public void mtdAgregarConductor(clsConductor_CE conductor)
        {
            db.mtdInsertarConductor(conductor);
        }

        public void mtdActualizarConductor(clsConductor_CE conductor)
        {
            db.mtdActualizarConductor(conductor);
        }
    }
}
