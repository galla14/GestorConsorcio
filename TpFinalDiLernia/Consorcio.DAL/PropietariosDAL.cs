using Consorcio.BE;
using Microsoft.Data.SqlClient;
using System.Configuration;


namespace Consorcio.DAL
{
    public class PropietariosDAL
    {
        public List<Propietario> ConsultarPropietarios()
        {
            List<Propietario> Propietarios = new List<Propietario>();
            Conexion conexion = new Conexion();
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.sp_ConsultarPropietarios", conn, sqlTransaction))
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
                                Propietarios.Add(propietario);
                            }
                        }
                    }
                    sqlTransaction.Commit();
                    return Propietarios;
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();
                    return Propietarios;
                }
            }
            return Propietarios;
        }

        public int InsertarPropietario(Propietario propietario)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.sp_InsertarPropietario", conn, sqlTransaction)
)
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id_Propietario", propietario.IdPropietario);
                        cmd.Parameters.AddWithValue("@Nombre", propietario.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", propietario.Apellido);
                        cmd.Parameters.AddWithValue("@Dni", propietario.DNI);
                        cmd.Parameters.AddWithValue("@NroCelular", propietario.NroCelular);


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

        public int ModificarPropietario(Propietario propietario)
        {
            List<Propietario> Propietarios = new List<Propietario>();
            Conexion conexion = new Conexion();
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_PropietarioModificar", conn, sqlTransaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Propietario", propietario.IdPropietario);
                        cmd.Parameters.AddWithValue("@Nombre", propietario.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", propietario.Apellido);
                        cmd.Parameters.AddWithValue("@dni", propietario.DNI);
                        cmd.Parameters.AddWithValue("@NroCelular", propietario.NroCelular);

                        //SqlParameter retorno = cmd.Parameters.Add("RETURN_VALUE", System.Data.SqlDbType.Int);
                        //cmd.ExecuteNonQuery();
                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                        sqlTransaction.Commit();

                        return resultado;
                    }

                }catch(Exception ex)
                {
                    sqlTransaction.Rollback();
                    return -10;
                }
            }
        }

        public int EliminarPropietario(Guid idPropietario)
        {
            Conexion conexion = new Conexion();
            using(SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EliminarPropietario", conn, sqlTransaction)) 
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Propietario", idPropietario);
                        
                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                        sqlTransaction.Commit();

                        return resultado;
                    }
                }catch( Exception ex)
                {
                    sqlTransaction.Rollback();
                    return 0;
                }
            }
            return 0;
        }
    }
}
