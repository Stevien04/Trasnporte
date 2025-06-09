using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using clsEntidad;

namespace clsDatos
{
    public class clsVehiculo_DB
    {
        private clsConexion conexion = new clsConexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;
        private DataTable tabla = new DataTable();

        public DataTable mtdListarVehiculos()
        {
            tabla = new DataTable();
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "sp_ListarVehiculos";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.mtdCerrarConexion();
            return tabla;
        }

        public void mtdInsertarVehiculo(clsVehiculo_CE vehiculo)
        {
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "sp_InsertarVehiculo";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Codigo_Vehiculo", vehiculo.CodigoVehiculo);
            comando.Parameters.AddWithValue("@id_Conductor", vehiculo.IdConductor);
            comando.Parameters.AddWithValue("@N_Placa", vehiculo.NumeroPlaca);
            comando.Parameters.AddWithValue("@Tipo", vehiculo.Tipo);
            comando.Parameters.AddWithValue("@Marca", vehiculo.Marca);
            comando.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
            comando.Parameters.AddWithValue("@Color", vehiculo.Color);

            DateTime fechaRegistro;
            if (!DateTime.TryParse(vehiculo.FechaRegistro, out fechaRegistro))
            {
                throw new Exception("FechaRegistro tiene un formato inválido.");
            }
            comando.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);

            comando.Parameters.AddWithValue("@N_asientos", vehiculo.NumeroAsientos);
            comando.Parameters.AddWithValue("@Estado", vehiculo.Estado);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.mtdCerrarConexion();
        }


        public void mtdEliminarVehiculo(int idVehiculo)
        {
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "sp_EliminarVehiculo";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_Vehiculo", idVehiculo);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.mtdCerrarConexion();
        }
    }
}
