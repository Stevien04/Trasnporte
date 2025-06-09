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
    public class clsVehiculo_CN
    {
        private clsVehiculo_DB db = new clsVehiculo_DB();

        public DataTable mtdObtenerVehiculos()
        {
            return db.mtdListarVehiculos();
        }

        public void mtdAgregarVehiculo(clsVehiculo_CE vehiculo)
        {
            db.mtdInsertarVehiculo(vehiculo);
        }

        public void mtdEliminarVehiculo(int idVehiculo)
        {
            db.mtdEliminarVehiculo(idVehiculo);
        }
    }
}
