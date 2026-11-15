using Consorcio.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consorcio.BE;
using System.Text.RegularExpressions;

namespace Consorcio.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL usuarioDal = new UsuarioDAL();
        PermisosBLL permisosBll = new PermisosBLL();
        public int ConsultarUsuario(string user, string pass)
        {
            return usuarioDal.ConsultarUsuariosParaIniciarSesion(user, pass);
        }
        public int IniciarSesion(string user, string pass)
        {
            return usuarioDal.IniciarSesion(user, pass);
        }

        public string ConsultarRol(string user)
        {
            return usuarioDal.ConsultarRol(user);
        }

        public int CrearUsuario(Usuario usuario)
        {
            return usuarioDal.CrearUsuario(usuario);
        }

        public List<Usuario> ConsultarTodosUsuarios()
        {
            return usuarioDal.ConsultarTodosUsuarios();
        }
        public void DesbloqueoUsuario(string user)
        {
            usuarioDal.DesbloqueoUsuario(user);
        }

        public int ModificarUsuario(Usuario user)
        {
            return usuarioDal.ModificarUsuario(user);
        }
        public int EliminarUsuario(Guid user)
        {
            return usuarioDal.EliminarUsuario(user);
        }

        public bool ValidarUsuario(Usuario usuario)
        {
            
            bool patronValido = Regex.IsMatch(usuario.NombreUsuario, @"^[A-z]{3}[0-9]{5}$");
            return Regex.IsMatch(usuario.NombreUsuario, @"^[A-Za-z]{3}[0-9]{5}$"); ;
        }

        public Usuario ObtenerUsuarioLogueado(string nombreUsuario)
        {
            Usuario usuario = ConsultarTodosUsuarios().FirstOrDefault(u => u.NombreUsuario == nombreUsuario);

            if (usuario == null)
                throw new Exception("No se encontró el usuario.");

            permisosBll.CargarPermisos(usuario);
            return usuario;
        }
    }
}
