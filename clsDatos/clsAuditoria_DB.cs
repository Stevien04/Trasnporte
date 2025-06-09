using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsEntidad;

namespace clsDatos
{
    public class clsAuditoria_DB
    {
        private clsConexion conexion = new clsConexion();
        private SqlCommand comando = new SqlCommand();

        public void mtdRegistrarAuditoria(clsAuditoriaInspector_CE auditoria)
        {
            try
            {
                comando.Connection = conexion.mtdAbrirConexion();
                comando.CommandText = "usp_I_AuditoriaInspector";
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@IdInspectorUsuario", auditoria.IdInspectorUsuario);
                comando.Parameters.AddWithValue("@IdInspectorModificado", auditoria.IdInspectorModificado);
                comando.Parameters.AddWithValue("@Accion", auditoria.Accion);
                comando.Parameters.AddWithValue("@Usuario", auditoria.Usuario);
                comando.Parameters.AddWithValue("@Fecha", auditoria.Fecha);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar auditoría: " + ex.Message);
            }
            finally
            {
                conexion.mtdCerrarConexion();
            }
        }
        public clsAuditoriaInspector_CE ObtenerUltimaAuditoriaPorInspector(int idInspector)
        {
            clsAuditoriaInspector_CE auditoria = new clsAuditoriaInspector_CE();

            using (SqlConnection cn = conexion.mtdAbrirConexion())
            {
                string consulta = "SELECT TOP 1 * FROM tbAuditoriaInspectores WHERE IdInspectorModificado = @id ORDER BY Fecha DESC";
                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", idInspector);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            auditoria.IdAuditoria = Convert.ToInt32(reader["IdAuditoria"]);
                            auditoria.IdInspector = Convert.ToInt32(reader["IdInspectorModificado"]);
                            auditoria.Accion = reader["Accion"].ToString();
                            auditoria.Usuario = reader["Usuario"].ToString();
                            auditoria.Fecha = Convert.ToDateTime(reader["Fecha"]);
                        }
                    }
                }
            }

            return auditoria;
        }
    }
}
