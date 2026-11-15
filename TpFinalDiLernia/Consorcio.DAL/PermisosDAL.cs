using System;
using System.Collections.Generic;
using Consorcio.BE;
using Microsoft.Data.SqlClient;

namespace Consorcio.DAL
{
    public class PermisosDAL
    {
        public List<Component> ObtenerPermisosUsuario(Guid idUsuario)
        {
            List<Component> permisoUsuario = new List<Component>();
            Conexion conexion = new Conexion();

            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                Dictionary<Guid, Component> arbol = CargarArbol(conn);

                using (SqlCommand cmd = new SqlCommand("dbo.sp_UsuarioPermisoListar", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Usuaruio", idUsuario);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Guid idPermiso = (Guid)reader["IdPermiso"];
                            if (arbol.ContainsKey(idPermiso))
                                permisoUsuario.Add(arbol[idPermiso]);
                        }
                    }
                }
            }
            return permisoUsuario;
        }

        public List<Component> ObtenerTodos()
        {
            Conexion conexion = new Conexion();
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                return CargarArbol(conn).Values.ToList();
            }
        }

        public int InsertarRol(Composite rol)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@Id_Permiso", rol.IdPermiso);
            parametros.Add("@Nombre", rol.Nombre);
            return EjecutarSP("dbo.sp_RolInsertar", parametros);
        }

        public int EliminarRol(Guid idRol)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@Id_Permiso", idRol);
            return EjecutarSP("dbo.sp_RolEliminar", parametros);
        }

        public int AgregarHijo(Guid idPadre, Guid idHijo)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@Id_Padre", idPadre);
            parametros.Add("@Id_Hijo", idHijo);
            return EjecutarSP("dbo.sp_PermisoPermisoInsertar", parametros);
        }

        public int QuitarHijo(Guid idPadre, Guid idHijo)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@Id_Padre", idPadre);
            parametros.Add("@Id_Hijo", idHijo);
            return EjecutarSP("dbo.sp_PermisoPermisoEliminar", parametros);
        }

        public int AsignarRolUsuario(Guid idUsuario, Guid idRol)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@Id_Usuario", idUsuario);
            parametros.Add("@Id_Permiso", idRol);
            return EjecutarSP("dbo.sp_UsuarioRolAsignar", parametros);
        }

        private int EjecutarSP(string nombreSp, Dictionary<string, object> parametros)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection conn = new SqlConnection(conexion.ObtenerCadenas()))
            {
                conn.Open();
                SqlTransaction sqlTransaction = conn.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(nombreSp, conn, sqlTransaction))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        foreach (KeyValuePair<string, object> parametro in parametros)
                            cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);

                        SqlParameter retorno = cmd.Parameters.Add("@RETURN_VALUE", System.Data.SqlDbType.Int);
                        retorno.Direction = System.Data.ParameterDirection.ReturnValue;

                        cmd.ExecuteNonQuery();
                        sqlTransaction.Commit();

                        return (int)retorno.Value;
                    }
                }
                catch (Exception)
                {
                    sqlTransaction.Rollback();
                    throw;
                }
            }
        }

        private Dictionary<Guid, Component> CargarArbol(SqlConnection conn)
        {
            Dictionary<Guid, Component> nodos = new Dictionary<Guid, Component>();

            using (SqlCommand cmd = new SqlCommand("dbo.sp_PermisoListar", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Guid id = (Guid)reader["IdPermiso"];
                        string nombre = reader["Nombre"].ToString();
                        bool esFamilia = (bool)reader["EsFamilia"];

                        Component componente;
                        if (esFamilia)
                            componente = new Composite(id, nombre);
                        else
                            componente = new Leaf(id, nombre, reader["Codigo"].ToString());

                        nodos.Add(id, componente);
                    }
                }
            }

            using (SqlCommand cmd = new SqlCommand("dbo.sp_PermisoPermisoListar", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Guid idPadre = (Guid)reader["IdPermisoPadre"];
                        Guid idHijo = (Guid)reader["IdPermisoHijo"];

                        if (nodos.ContainsKey(idPadre) && nodos.ContainsKey(idHijo))
                            nodos[idPadre].Agregar(nodos[idHijo]);
                    }
                }
            }

            return nodos;
        }
    }
}
