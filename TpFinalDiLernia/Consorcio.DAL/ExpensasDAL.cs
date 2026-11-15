using Consorcio.BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consorcio.DAL
{
    public class ExpensasDAL
    {
        
        public List<Expensa> expensas = new List<Expensa>();

        public List<Expensa> ConsultarExpensas()
        {
            List<Expensa> expensas = new List<Expensa>();
            Conexion conexion = new Conexion();

            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.sp_ConsultarExpensas", conn, sqlTransaction))
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
                                        reader["Dni"].ToString(),
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
                                expensas.Add(expensa);
                            }
                        }
                    }

                    sqlTransaction.Commit();
                }
                catch (Exception)
                {
                    sqlTransaction.Rollback();
                    throw;   
                }
            }
            return expensas;
        }

        public int InsertarExpensa(Expensa expensa)
        {
            Conexion conexion = new Conexion();

            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarExpensa", conn, sqlTransaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id_Expensa", expensa.IdExpensa);
                        cmd.Parameters.AddWithValue("@Id_Unidad", expensa.Unidad.idUnidad);
                        cmd.Parameters.AddWithValue("@FechaEmision", expensa.FechaEmision);
                        cmd.Parameters.AddWithValue("@FechaVto", expensa.FechaVto);
                        cmd.Parameters.AddWithValue("@MontoOrdinario", expensa.MontoOrdinario);
                        cmd.Parameters.AddWithValue("@MontoExtraOrd", expensa.MontoExtraOrd);
                        cmd.Parameters.AddWithValue("@RecargoXMora", expensa.RecargoXMora);
                        cmd.Parameters.AddWithValue("@Estado", expensa.Estado);

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

        public int ModificarExpensa(Expensa expensa)
        {
            Conexion conexion = new Conexion();
            using(SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using(SqlCommand cmd = new SqlCommand("sp_ModificarExpensa", conn, sqlTransaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id_Expensa", expensa.IdExpensa);
                        cmd.Parameters.AddWithValue("@Id_Unidad", expensa.Unidad.idUnidad);
                        cmd.Parameters.AddWithValue("@FechaEmision", expensa.FechaEmision);
                        cmd.Parameters.AddWithValue("@FechaVto", expensa.FechaVto);
                        cmd.Parameters.AddWithValue("@MontoOrdinario", expensa.MontoOrdinario);
                        cmd.Parameters.AddWithValue("@MontoExtraordinario", expensa.MontoExtraOrd);
                        cmd.Parameters.AddWithValue("@RecargoXMora", expensa.RecargoXMora);
                        cmd.Parameters.AddWithValue("@Estado", expensa.Estado);

                        SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);
                        retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();
                        sqlTransaction.Commit();

                        return (int)retorno.Value;
                    }
                }catch ( Exception ex)
                {
                    sqlTransaction.Rollback();
                    return -10;
                }
            }
            return 0;
        }

        public int EliminarExpensa(Expensa expensa)
        {
            Conexion conexion = new Conexion();
            using(SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using(SqlCommand cmd = new SqlCommand("sp_EliminarExpensa", conn, sqlTransaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id_Expensa", expensa.IdExpensa);

                        SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);
                        retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();
                        sqlTransaction.Commit();
                    }
                    return 1;
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();
                    return -10;
                }
            }
            
        }
    }
}
