using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsEntidad;
using System.Linq.Expressions;

namespace clsDatos
{
    public class clsInspectores_DB
    {
        private clsConexion conexion = new clsConexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;
        private DataTable tabla = new DataTable();

        public DataTable mtdListarInspectores()
        {
            tabla = new DataTable();
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "ups_S_ListarTodosLosInspectores" ;
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.mtdCerrarConexion();
            return tabla;
        }

        public void mtdAgregarInspectoresSQL(clsInspectores_CE inspectores) 
        {
            try
            {
                comando.Connection = conexion.mtdAbrirConexion();
                comando.CommandText = "ups_I_agregarInspector";
                comando.CommandType = CommandType.StoredProcedure;

                // Limpiar parámetros anteriores por si acaso
                comando.Parameters.Clear();

                // Agregar parámetros con los valores del objeto 'inspectores'
                comando.Parameters.AddWithValue("@nom", inspectores.nombre);
                comando.Parameters.AddWithValue("@Ape", inspectores.Apellido);
                comando.Parameters.AddWithValue("@dni", inspectores.dni);
                comando.Parameters.AddWithValue("@fecha_in", inspectores.fecha_in);
                comando.Parameters.AddWithValue("@fecha_fin", inspectores.fecha_fin);
                comando.Parameters.AddWithValue("@cat", inspectores.categoria);
                comando.Parameters.AddWithValue("@ruc", inspectores.ruc);
                comando.Parameters.AddWithValue("@Foto", inspectores.Fotografia);
                comando.Parameters.AddWithValue("@Estado", inspectores.Estado);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Aquí podrías loguear o manejar la excepción según convenga
                throw new Exception("Error al insertar inspector: " + ex.Message);
            }
            finally
            {
                conexion.mtdCerrarConexion();
            }
        }

        public void mtdModificarInspectoresSQl(clsInspectores_CE inspectores) 
        {
            try
            {
                comando.Connection = conexion.mtdAbrirConexion();
                comando.CommandText = "usp_U_ModificarInspector";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@id_inspector", inspectores.id_inspector);
                comando.Parameters.AddWithValue("@nom", inspectores.nombre);
                comando.Parameters.AddWithValue("@Ape", inspectores.Apellido);
                comando.Parameters.AddWithValue("@dni", inspectores.dni);
                comando.Parameters.AddWithValue("@fecha_in", inspectores.fecha_in);
                comando.Parameters.AddWithValue("@fecha_fin", inspectores.fecha_fin);
                comando.Parameters.AddWithValue("@cat", inspectores.categoria);
                comando.Parameters.AddWithValue("@ruc", inspectores.ruc);
                comando.Parameters.AddWithValue("@Foto", inspectores.Fotografia);
                comando.Parameters.AddWithValue("@Estado", inspectores.Estado);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                throw new Exception("Error al actualizar inspector: " + ex.Message);
            }
            finally
            {
                conexion.mtdCerrarConexion();
    
            }
        }
        public DataTable mtdBuscarInspectoresPorIdONombre(string filtro)
        {
            DataTable tabla = new DataTable();
            try
            {
                comando.Connection = conexion.mtdAbrirConexion();
                comando.CommandText = "ups_S_BuscarInspectoresPorIdONombre";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@filtro", filtro);

                SqlDataReader leer = comando.ExecuteReader();
                tabla.Load(leer);
            }
            finally
            {
                conexion.mtdCerrarConexion();
            }
            return tabla;
        }


    }

}
