using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace clsDatos
{
    class clsConexion
    {
        private SqlConnection conexion = new SqlConnection("server=161.132.37.95; database=upt_TrabajoInspectores; user id=usuarioMultas; password=equisde34@@");

        public SqlConnection mtdAbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection mtdCerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}