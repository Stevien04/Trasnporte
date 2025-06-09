using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clsEntidad;

namespace clsDatos
{
    public class clsUsuario_DB
    {
        private clsConexion conexion = new clsConexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;
        private DataTable tabla = new DataTable();
        public DataTable mtdListaUsuarios()
        {
            tabla = new DataTable();
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "ups_S_ListarTodosLosUsuarios";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.mtdCerrarConexion();
            return tabla;
        }

        public DataTable mtdAutenticarUsuario(string usuario, string password)
        {
            tabla = new DataTable();
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "usp_AutenticarUsuario";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Clear();


            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Password", password);

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.mtdCerrarConexion();

            return tabla;
        }

        public void mtdAgregarUsuarioSQL(clsUsuario_CE o)
        {
            try
            {
                comando.Connection = conexion.mtdAbrirConexion();
                comando.CommandText = "ups_I_agregarUsuarioPrograma";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@id_inspector", o.id_inspector);
                comando.Parameters.AddWithValue("@VigenciaLicencia", o.VigenciaLicencia);
                comando.Parameters.AddWithValue("@Usuario", o.Usuario);
                comando.Parameters.AddWithValue("@Password", o.Password);
                comando.Parameters.AddWithValue("@Cargo", o.Cargo);
                comando.Parameters.AddWithValue("@Correo", o.Correo);
                comando.Parameters.AddWithValue("@Estado", o.Estado);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar usuario: " + ex.Message);
            }
            finally
            {
                conexion.mtdCerrarConexion();
            }
        }
        public void mtdModificarUsuarioSQl(clsUsuario_CE o)
        {
            try
            {
                comando.Connection = conexion.mtdAbrirConexion();
                comando.CommandText = "usp_U_ModificarUsuarioPrograma";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@id_User", o.id_User);
                comando.Parameters.AddWithValue("@id_inspector", o.id_inspector);
                comando.Parameters.AddWithValue("@VigenciaLicencia", o.VigenciaLicencia);
                comando.Parameters.AddWithValue("@Usuario", o.Usuario);
                comando.Parameters.AddWithValue("@Password", o.Password);
                comando.Parameters.AddWithValue("@Cargo", o.Cargo);
                comando.Parameters.AddWithValue("@Correo", o.Correo);
                comando.Parameters.AddWithValue("@Estado", o.Estado);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar usuario: " + ex.Message);
            }
            finally
            {
                conexion.mtdCerrarConexion();
            }

        }
        public DataTable mtdObtenerUsuarioPorNombre(string usuario)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "usp_S_ObtenerUsuarioPorUsuario";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Usuario", usuario);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.mtdCerrarConexion();

            return tabla;
        }

        public bool ExisteUsuarioPorInspectorID(int idInspector)
        {
            bool existe = false;
            string consulta = "SELECT COUNT(*) FROM tbUsuariosPrograma WHERE id_inspector = @idInspector";

            using (SqlCommand cmd = new SqlCommand(consulta, conexion.mtdAbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@idInspector", idInspector);

                int count = (int)cmd.ExecuteScalar();
                existe = count > 0;

                conexion.mtdCerrarConexion();
            }

            return existe;
        }

    }

}


 


