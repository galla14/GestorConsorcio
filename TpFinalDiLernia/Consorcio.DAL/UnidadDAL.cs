using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consorcio.BE;
using Microsoft.Data.SqlClient;

namespace Consorcio.DAL
{
    public class UnidadDAL
    {
        public List<Unidad> ConsultarUnidades()
        {
            List<Unidad> unidades = new List<Unidad>();
            Conexion conexion = new Conexion();
            using(SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UnidadConsultar", conn, sqlTransaction))
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
                                unidades.Add(unidad);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();
                }
            }
            return unidades;
        }

        public int InsertarUnidad(Unidad unidad)
        {

            Conexion conexion = new Conexion();
            using(SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using(SqlCommand cmd = new SqlCommand("sp_UnidadInsertar", conn, sqlTransaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id_Unidad", unidad.idUnidad);
                        cmd.Parameters.AddWithValue("@Id_Propietario", unidad.Propietario.IdPropietario);
                        cmd.Parameters.AddWithValue("@Piso", unidad.Piso);
                        cmd.Parameters.AddWithValue("@Departamento", unidad.Departamento);
                        cmd.Parameters.AddWithValue("@MedidaDpto", unidad.MedidaDpto);
                        cmd.Parameters.AddWithValue("@AptoAlquiler", unidad.AptoAlquiler);
                        cmd.Parameters.AddWithValue("@Alquilado", unidad.Alquilado);

                        SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);
                        retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();
                        sqlTransaction.Commit();

                        return (int) retorno.Value;
                        

                    }
                } catch (Exception ex) 
                {
                    sqlTransaction.Rollback();
                    return -10;
                }
                
            }
        }

        public int EliminarUnidad(Guid idUnidad)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UnidadEliminar", conn, sqlTransaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Unidad", idUnidad);

                        SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);

                        retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                        sqlTransaction.Commit();
                        cmd.ExecuteNonQuery();

                        return (int)retorno.Value;
                    }
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();
                    return -10;
                }
                
            }
            return 0;
        }

        public int ModificarUnidad(Unidad unidad)
        {
            Conexion conexion = new Conexion();
            using(SqlConnection con = new SqlConnection(conexion.ObtenerCadenas()))
            {
                con.Open();
                SqlTransaction sqlTransaction = con.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UnidadModificar", con, sqlTransaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id_Unidad", unidad.idUnidad);
                        cmd.Parameters.AddWithValue("@Id_Propietario", unidad.Propietario.IdPropietario);
                        cmd.Parameters.AddWithValue("@Piso", unidad.Piso);
                        cmd.Parameters.AddWithValue("@Departamento", unidad.Departamento);
                        cmd.Parameters.AddWithValue("@MedidaDpto", unidad.MedidaDpto);
                        cmd.Parameters.AddWithValue("@AptoAlquiler", unidad.AptoAlquiler);
                        cmd.Parameters.AddWithValue("@Alquilado", unidad.Alquilado);

                        SqlParameter retorno = cmd.Parameters.Add("RETURN_VALUE", System.Data.SqlDbType.Int);
                        retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();
                        sqlTransaction.Commit();
                        return (int)retorno.Value;
                    }
                }
                catch(Exception ex)
                {
                    sqlTransaction.Rollback();
                    return -10;
                }
                
            }
        }
    }
}
