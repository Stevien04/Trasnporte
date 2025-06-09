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
    public class clsOperativo_DB
    {
        private clsConexion conexion = new clsConexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;
        private DataTable tabla = new DataTable();

        public DataTable mtdListarOperativos()
        {
            tabla = new DataTable();
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "ups_S_ListarOperativos";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.mtdCerrarConexion();
            return tabla;
        }

        public void mtdInsertarOperativo(clsOperativo_CE o)
        {
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "ups_I_agregarOperativo";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Fecha_operativo", o.FechaOperativo);
            comando.Parameters.AddWithValue("@hora_ini", o.HoraInicio);
            comando.Parameters.AddWithValue("@hora_fin", o.HoraFin);
            comando.Parameters.AddWithValue("@cantidad_policias", o.CantidadPolicias);
            comando.Parameters.AddWithValue("@cant_inspectores", o.CantidadInspectores);
            comando.Parameters.AddWithValue("@direccion", o.Direccion);
            comando.Parameters.AddWithValue("@Motivo_Operativo", o.MotivoOperativo);
            comando.Parameters.AddWithValue("@Resultado", o.Resultado);
            comando.Parameters.AddWithValue("@Ubicacion_Documento", o.UbicacionDocumento);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.mtdCerrarConexion();
        }

        public void mtdActualizarOperativo(clsOperativo_CE o)
        {
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "usp_U_ModificarOperativo";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_Operativo", o.IdOperativo);
            comando.Parameters.AddWithValue("@Fecha_operativo", o.FechaOperativo);
            comando.Parameters.AddWithValue("@hora_ini", o.HoraInicio);
            comando.Parameters.AddWithValue("@hora_fin", o.HoraFin);
            comando.Parameters.AddWithValue("@cantidad_policias", o.CantidadPolicias);
            comando.Parameters.AddWithValue("@cant_inspectores", o.CantidadInspectores);
            comando.Parameters.AddWithValue("@direccion", o.Direccion);
            comando.Parameters.AddWithValue("@Motivo_Operativo", o.MotivoOperativo);
            comando.Parameters.AddWithValue("@Resultado", o.Resultado);
            comando.Parameters.AddWithValue("@Ubicacion_Documento", o.UbicacionDocumento);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.mtdCerrarConexion();
        }
    }
}
