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
    public class clsConductor_DB
    {
        private clsConexion conexion = new clsConexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;
        private DataTable tabla = new DataTable();

        public DataTable mtdListarConductores()
        {
            tabla = new DataTable();
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "ups_S_ListarTodosLosConductores";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.mtdCerrarConexion();
            return tabla;
        }

        public void mtdInsertarConductor(clsConductor_CE conductor)
        {
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "ups_I_agregarConductor";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@dni", conductor.Dni);
            comando.Parameters.AddWithValue("@Codigo", conductor.Codigo);
            comando.Parameters.AddWithValue("@nombre", conductor.Nombre);
            comando.Parameters.AddWithValue("@Apellido", conductor.Apellido);
            comando.Parameters.AddWithValue("@VigenciaLicencia", conductor.VigenciaLicencia);
            comando.Parameters.AddWithValue("@TipoLicencia", conductor.TipoLicencia);
            comando.Parameters.AddWithValue("@Fotografia", (object)conductor.Fotografia ?? DBNull.Value);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.mtdCerrarConexion();
        }

        public void mtdActualizarConductor(clsConductor_CE conductor)
        {
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "usp_U_ModificarConductor";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_Conductor", conductor.IdConductor);
            comando.Parameters.AddWithValue("@dni", conductor.Dni);
            comando.Parameters.AddWithValue("@Codigo", conductor.Codigo);
            comando.Parameters.AddWithValue("@nombre", conductor.Nombre);
            comando.Parameters.AddWithValue("@Apellido", conductor.Apellido);
            comando.Parameters.AddWithValue("@VigenciaLicencia", conductor.VigenciaLicencia);
            comando.Parameters.AddWithValue("@TipoLicencia", conductor.TipoLicencia);
            comando.Parameters.AddWithValue("@Fotografia", (object)conductor.Fotografia ?? DBNull.Value);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.mtdCerrarConexion();
        }
    }
}
