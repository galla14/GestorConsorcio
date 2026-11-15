using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consorcio.BE;
using Microsoft.Data.SqlClient;

namespace Consorcio.DAL
{
    public class PagoDAL
    {
        //public List<Pago> pagos = new List<Pago>();
        Conexion conexion = new Conexion();
        public List<Pago> ConsultarPagos()
        {
            List<Pago> pagos = new List<Pago>();
            Conexion conexion = new Conexion();



            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ConsultarPagos", conn, sqlTransaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Propietario propietario = new Propietario
                                    (
                                        (Guid)reader["IdPropietario"],
                                        reader["Nombre"].ToString(),
                                        reader["Apellido"].ToString(),
                                        reader["dni"].ToString(),
                                        reader["NroCelular"].ToString()
                                    );
                                Unidad unidad = new Unidad
                                    (
                                        (Guid)reader["IdUnidad"],
                                        propietario,
                                        reader["Piso"].ToString(),
                                        reader["Departamento"].ToString(),
                                        float.Parse(reader["MedidaDpto"].ToString()),
                                        (bool)reader["AptoAlquiler"],
                                        (bool)reader["Alquilado"]
                                    );
                                Expensa expensa = new Expensa
                                    (
                                        (Guid)reader["IdExpensas"],
                                        (DateTime)reader["FechaEmision"],
                                        (DateTime)reader["FechaVto"],
                                        Convert.ToDouble(reader["MontoOrdinario"]),
                                        Convert.ToDouble(reader["MontoExtraOrd"]),
                                        Convert.ToDouble(reader["RecargoXMora"]),
                                        reader["Estado"].ToString(),
                                        unidad
                                    );
                                Pago pago = new Pago
                                    (
                                        (Guid)reader["IdPago"],
                                        expensa,
                                        (DateTime)reader["FechaPago"],
                                        Convert.ToDouble(reader["Monto"]),
                                        reader["MedioPago"].ToString(),
                                        Convert.ToInt32(reader["NroComprobante"]),
                                        reader["Observaciones"].ToString()
                                    );
                                pagos.Add(pago);
                            }

                        }
                    }
                    sqlTransaction.Commit();
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();
                }
                
                
            }
            return pagos;
        }

        public int InsertarPago(Pago pago)
        {
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using(SqlCommand cmd = new SqlCommand("sp_InsertarPago", conn, sqlTransaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id_Pago", pago.IdPago);
                        cmd.Parameters.AddWithValue("@Id_Expensas", pago.Expensa.IdExpensa);
                        cmd.Parameters.AddWithValue("@Fecha_pago", pago.FechaPago);
                        cmd.Parameters.AddWithValue("@Monto", pago.Monto);
                        cmd.Parameters.AddWithValue("@MedioPago", pago.MedioPago);
                        cmd.Parameters.AddWithValue("@NroComprobante", pago.NroComprobante);
                        cmd.Parameters.AddWithValue("@Observaciones", pago.Observaciones);

                        SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);
                        retorno.Direction = System.Data.ParameterDirection.ReturnValue;

                        cmd.ExecuteNonQuery();
                        sqlTransaction.Commit();

                        return (int)retorno.Value;
                    }
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();
                    return -10;
                }
            }
        }

        public int EliminarPago(Pago pago)
        {
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EliminarPago", conn, sqlTransaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id_Pago", pago.IdPago);

                        SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);
                        retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();
                        sqlTransaction.Commit();

                        return (int)retorno.Value;
                    }
                }
                catch (Exception ex)
                {
                    return -10;
                }
            }
        }

        public int ModificarPago(Pago pago)
        {
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using(SqlCommand cmd = new SqlCommand("sp_ModificarPago", conn, sqlTransaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id_Pago", pago.IdPago);
                        cmd.Parameters.AddWithValue("@Id_Expensa", pago.Expensa.IdExpensa);
                        cmd.Parameters.AddWithValue("@FechaPago", pago.FechaPago);
                        cmd.Parameters.AddWithValue("@Monto", pago.Monto);
                        cmd.Parameters.AddWithValue("@MedioPago", pago.MedioPago);
                        cmd.Parameters.AddWithValue("@NroComprobante", pago.NroComprobante);
                        cmd.Parameters.AddWithValue("@Observaciones", pago.Observaciones);

                        SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);
                        retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();
                        sqlTransaction.Commit();

                        return (int)retorno.Value;
                    }
                }
                catch (Exception ex)
                {
                    return -10;
                }
            }
        }
    }
}
