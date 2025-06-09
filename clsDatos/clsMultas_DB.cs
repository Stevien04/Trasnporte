using System;
using System.Data;
using System.Data.SqlClient;
using clsEntidad;

namespace clsDatos
{
    public class clsMultas_DB
    {
        private clsConexion conexion = new clsConexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;
        private DataTable tabla = new DataTable();

        public DataTable mtdListarMultas()
        {
            tabla = new DataTable();
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "SELECT * FROM tbMultas";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.mtdCerrarConexion();
            return tabla;
        }

        public void mtdInsertarMulta(clsMulta_CE m)
        {
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = @"INSERT INTO tbMultas 
        (id_Conductor, codigo_Multa, fecha_multa, monto, valor_uit, Vehi_Deposito, Estado_Multa, Observaciones, id_inspector_responsable)
        VALUES 
        (@id_Conductor, @codigo_Multa, @fecha_multa, @monto, @valor_uit, @Vehi_Deposito, @Estado_Multa, @Observaciones, @id_inspector_responsable)";
            comando.CommandType = CommandType.Text;

            comando.Parameters.AddWithValue("@id_Conductor", m.IdConductor);
            comando.Parameters.AddWithValue("@codigo_Multa", m.CodigoMulta);
            comando.Parameters.AddWithValue("@fecha_multa", m.FechaMulta);
            comando.Parameters.AddWithValue("@monto", m.Monto);
            comando.Parameters.AddWithValue("@valor_uit", (object)m.ValorUIT ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Vehi_Deposito", m.VehiDeposito);
            comando.Parameters.AddWithValue("@Estado_Multa", m.EstadoMulta);
            comando.Parameters.AddWithValue("@Observaciones", (object)m.Observaciones ?? DBNull.Value);
            comando.Parameters.AddWithValue("@id_inspector_responsable", m.IdInspectorResponsable); // Nuevo

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.mtdCerrarConexion();
        }

        public void mtdActualizarMulta(clsMulta_CE m)
        {
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = @"UPDATE tbMultas SET 
            id_Conductor = @id_Conductor,
            codigo_Multa = @codigo_Multa,
            fecha_multa = @fecha_multa,
            monto = @monto,
            valor_uit = @valor_uit,
            Vehi_Deposito = @Vehi_Deposito,
            Estado_Multa = @Estado_Multa,
            Observaciones = @Observaciones,
            id_inspector_responsable = @id_inspector_responsable
            WHERE id_Multas = @id_Multas";
            comando.CommandType = CommandType.Text;

            comando.Parameters.AddWithValue("@id_Multas", m.IdMultas);
            comando.Parameters.AddWithValue("@id_Conductor", m.IdConductor);
            comando.Parameters.AddWithValue("@codigo_Multa", m.CodigoMulta);
            comando.Parameters.AddWithValue("@fecha_multa", m.FechaMulta);
            comando.Parameters.AddWithValue("@monto", m.Monto);
            comando.Parameters.AddWithValue("@valor_uit", (object)m.ValorUIT ?? DBNull.Value);
            comando.Parameters.AddWithValue("@Vehi_Deposito", m.VehiDeposito);
            comando.Parameters.AddWithValue("@Estado_Multa", m.EstadoMulta);
            comando.Parameters.AddWithValue("@Observaciones", (object)m.Observaciones ?? DBNull.Value);
            comando.Parameters.AddWithValue("@id_inspector_responsable", m.IdInspectorResponsable); // Nuevo

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.mtdCerrarConexion();
        }

        public void mtdEliminarMulta(int idMultas)
        {
            comando.Connection = conexion.mtdAbrirConexion();
            comando.CommandText = "DELETE FROM tbMultas WHERE id_Multas = @id_Multas";
            comando.CommandType = CommandType.Text;

            comando.Parameters.AddWithValue("@id_Multas", idMultas);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.mtdCerrarConexion();
        }

        public clsMulta_CE mtdObtenerMultaPorId(int idMulta)
        {
            clsMulta_CE multa = null;

            try
            {
                comando.Connection = conexion.mtdAbrirConexion();
                comando.CommandText = "SELECT * FROM tbMultas WHERE id_Multas = @id_Multas";
                comando.CommandType = CommandType.Text;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id_Multas", idMulta);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    multa = new clsMulta_CE
                    {
                        IdMultas = Convert.ToInt32(reader["id_Multas"]),
                        IdConductor = Convert.ToInt32(reader["id_Conductor"]),
                        CodigoMulta = reader["codigo_Multa"].ToString(),
                        FechaMulta = Convert.ToDateTime(reader["fecha_multa"]),
                        Monto = reader["monto"].ToString(),
                        ValorUIT = reader["valor_uit"] as decimal?,
                        VehiDeposito = reader["Vehi_Deposito"].ToString(),
                        EstadoMulta = reader["Estado_Multa"].ToString(),
                        Observaciones = reader["Observaciones"] as string,
                        IdInspectorResponsable = Convert.ToInt32(reader["id_inspector_responsable"])
                    };
                }

                comando.Parameters.Clear();
                conexion.mtdCerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos de la multa: " + ex.Message);
            }

            return multa;
        }
    }
}
