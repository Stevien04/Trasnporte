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
    public class clsOperativo_CN
    {
        private clsOperativo_DB db = new clsOperativo_DB();

        public DataTable mtdObtenerOperativos()
        {
            return db.mtdListarOperativos();
        }

        public void mtdAgregarOperativo(clsOperativo_CE o)
        {
            db.mtdInsertarOperativo(o);
        }

        public void mtdActualizarOperativo(clsOperativo_CE o)
        {
            db.mtdActualizarOperativo(o);
        }
    }
}
