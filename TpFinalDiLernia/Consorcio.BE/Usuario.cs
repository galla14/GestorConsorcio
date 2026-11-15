using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consorcio.BE
{
    public class Usuario
    {
        public Guid Id_Usuario { get; set; }
        public string NombreUsuario {  set; get; }
        public string Password { get; set; }
        public string Rol {  set; get; }
        public bool Activo { set; get; }
        public int IntentosFallidos {  set; get; }
        public bool Bloqueado {  set; get; }
        public DateTime FechaAlta { set; get; }
        public List<Component> Permisos { get; set; } = new List<Component>();

        public Usuario(string nombreUsuario,  string password, string rol, bool activo, int intentos, bool bloqueado, DateTime fechaAlta)
        {
            NombreUsuario = nombreUsuario;
            Password = password;
            Rol = rol;
            Activo = activo;
            IntentosFallidos = intentos;
            Bloqueado = bloqueado;
            FechaAlta = fechaAlta;

        }

        public Usuario(Guid id_usuario,string nombreUsuario, string password, string rol, bool activo, int intentos, bool bloqueado, DateTime fechaAlta)
        {
            Id_Usuario = id_usuario;
            NombreUsuario = nombreUsuario;
            Password = password;
            Rol = rol;
            Activo = activo;
            IntentosFallidos = intentos;
            Bloqueado = bloqueado;
            FechaAlta = fechaAlta;
        }

        public Usuario(Guid guid, string nombreUsuario, string password, string rol)
        {
            Id_Usuario = guid;
            NombreUsuario = nombreUsuario;
            Password = password;
            Rol = rol;
        }

        public Usuario(string nombreUsuario, string password)
        {
            
            NombreUsuario = nombreUsuario;
            Password = password;
            
        }

        public bool TienePermiso(string codigo)
        {
            foreach(Component permiso in Permisos)
            {
                if(permiso.TienePermiso(codigo))
                    return true;
            }
            return false;
        }
    }
}
