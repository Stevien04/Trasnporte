using System;
using System.Data;
using clsDatos;
using clsEntidad;

namespace clsNegocio
{
    public class clsMulta_CN
    {
        private clsMultas_DB db = new clsMultas_DB();

        public DataTable mtdObtenerMultas()
        {
            return db.mtdListarMultas();
        }

        public void mtdAgregarMulta(clsMulta_CE m)
        {
            db.mtdInsertarMulta(m);
        }

        public void mtdActualizarMulta(clsMulta_CE m)
        {
            db.mtdActualizarMulta(m);
        }

        public void mtdEliminarMulta(int idMultas)
        {
            db.mtdEliminarMulta(idMultas);
        }
        public clsMulta_CE mtdObtenerMultaPorId(int idMulta)
        {
            return db.mtdObtenerMultaPorId(idMulta);
        }

    }
}
