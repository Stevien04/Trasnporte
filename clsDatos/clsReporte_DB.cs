using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsEntidad;
using System.Security.Cryptography;

namespace clsDatos
{
    public class clsReporte_DB
    {

        private clsConexion conexion = new clsConexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;
        private DataTable tabla = new DataTable();

        public DataTable mtdListarReporte()
        {
            tabla = new DataTable();
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "ups_S_ListarReportes";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.mtdCerrarConexion();
            return tabla;
        }

        public void mtdAgregarReporteSQL(clsReporte_CE Reporte)
        {
            try
            {
                comando.Connection = conexion.mtdAbrirConexion();
                comando.CommandText = "ups_I_agregarReporte";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                // Asignar parámetros desde el objeto clsReporte_CE
                comando.Parameters.AddWithValue("@Fecha", Reporte.Fecha);
                comando.Parameters.AddWithValue("@Hora", Reporte.Hora);
                comando.Parameters.AddWithValue("@Ubicacion", Reporte.Ubicacion);
                comando.Parameters.AddWithValue("@Descripcion", Reporte.Descripcion);
                comando.Parameters.AddWithValue("@id_inspector", Reporte.Id_Inspector);
                comando.Parameters.AddWithValue("@id_vehiculo", Reporte.Id_Vehiculo);
                comando.Parameters.AddWithValue("@foto_video", (object)Reporte.Foto_Video ?? DBNull.Value);
                comando.Parameters.AddWithValue("@estado_revision", Reporte.Estado_Revision);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar reporte: " + ex.Message);
            }
            finally
            {
                conexion.mtdCerrarConexion();
            }
        }
        public void mtdModificarReporteSQl(clsReporte_CE Reporte)
        {
            try
            {
                comando.Connection = conexion.mtdAbrirConexion();
                comando.CommandText = "usp_U_ModificarReporte";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@id_Reporte", Reporte.Id_Reporte);
                comando.Parameters.AddWithValue("@Fecha", Reporte.Fecha);
                comando.Parameters.AddWithValue("@Hora", Reporte.Hora);
                comando.Parameters.AddWithValue("@Ubicacion", Reporte.Ubicacion);
                comando.Parameters.AddWithValue("@Descripcion", Reporte.Descripcion);
                comando.Parameters.AddWithValue("@id_inspector", Reporte.Id_Inspector);
                comando.Parameters.AddWithValue("@id_vehiculo", Reporte.Id_Vehiculo);
                comando.Parameters.AddWithValue("@foto_video", (object)Reporte.Foto_Video ?? DBNull.Value);
                comando.Parameters.AddWithValue("@estado_revision", Reporte.Estado_Revision);

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

        public DataTable mtdBuscarMultaPorCodigo(string codigoMulta)
        {
            DataTable tablaMulta = new DataTable();

            try
            {
                comando.Connection = conexion.mtdAbrirConexion();
                comando.CommandText = "ups_S_BuscarMultaPorCodigo";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codigo_Multa", codigoMulta);

                leer = comando.ExecuteReader();
                tablaMulta.Load(leer);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la multa: " + ex.Message);
            }
            finally
            {
                conexion.mtdCerrarConexion();
            }

            return tablaMulta;
        }

       
            
        
    }

}
