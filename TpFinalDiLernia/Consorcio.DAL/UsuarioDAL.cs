using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consorcio.BE;
using Microsoft.Data.SqlClient;

namespace Consorcio.DAL
{
    public class UsuarioDAL
    {
        Conexion conexion = new Conexion();
        public List<Usuario> usuario = new List<Usuario>();

        public int ConsultarUsuariosParaIniciarSesion(string user, string pass)
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("sp_ConsultarUsuarioIniciarSesion", conn, sqlTransaction))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreUsuario", user);
                    cmd.Parameters.AddWithValue("@Password", pass);

                    SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);

                    retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    sqlTransaction.Commit();

                    return (int)retorno.Value;

                }
            }
        }

        public int IniciarSesion(string user, string pass)
        {
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("sp_ConsultarUsuario", conn, sqlTransaction))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreUsuario", user);
                    cmd.Parameters.AddWithValue("@Password", pass);


                    SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);

                    retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    sqlTransaction.Commit();

                    return (int)retorno.Value;

                }
            }
        }

        public string ConsultarRol(string user)
        {
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("sp_ConsultarRol", conn, sqlTransaction))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreUsuario", user);

                    object resultado = cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();
                    sqlTransaction.Commit();

                    return resultado == null ? "" : resultado.ToString();

                }
            }
        }

        public int CrearUsuario(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("sp_CrearUsuario", conn, sqlTransaction))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id_Usuario", usuario.Id_Usuario);
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@Password", usuario.Password);
                    cmd.Parameters.AddWithValue("@Rol", usuario.Rol);
                    cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                    cmd.Parameters.AddWithValue("@IntentosFallidos", usuario.IntentosFallidos);
                    cmd.Parameters.AddWithValue("@Bloqueado", usuario.Bloqueado);
                    cmd.Parameters.AddWithValue("@FechaAlta", usuario.FechaAlta);

                    SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);
                    retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    sqlTransaction.Commit();

                    return (int)retorno.Value;
                }
            }
                return 0;
        }

        public int ModificarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("sp_ModificarNombreUsuario", conn, sqlTransaction))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id_Usuario", usuario.Id_Usuario);
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);

                    SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);
                    retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    sqlTransaction.Commit();

                    return (int)retorno.Value;
                }
            }
        }

        public int ModificarPass(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("sp_ModificarPassword", conn, sqlTransaction))
                {
                    cmd.Parameters.AddWithValue("@Id_Unidad", usuario.Id_Usuario);
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@Password", usuario.Password);

                    SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);
                    retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    sqlTransaction.Commit();

                    return (int)retorno.Value;
                }
            }
        }

        public List<Usuario> ConsultarTodosUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Conexion conexion = new Conexion();

            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ConsultarTodosUsuarios", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            (
                                (Guid)reader["IdUsuario"],
                                reader["NombreUsuario"].ToString(),
                                reader["Password"].ToString(),
                                reader["Rol"].ToString(),
                                (bool)reader["Activo"],
                                (int)reader["IntentosFallidos"],
                                (bool)reader["Bloqueado"],
                                (DateTime)reader["FechaAlta"]
                            );
                            usuarios.Add(usuario);
                        }
                    }
                }
            }
            return usuarios;
        }

        public void DesbloqueoUsuario(string user)
        {
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_DesbloqueoUsuario", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreUsuario", user);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        public int EliminarUsuario(Guid user)
        {
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("sp_UsuarioDesactivar", conn, sqlTransaction))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Usuario", user);

                    SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);
                    retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    sqlTransaction.Commit();

                    return (int)retorno.Value;

                }
            }
        }

    }
}
