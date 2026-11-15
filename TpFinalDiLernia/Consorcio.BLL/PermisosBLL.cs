using System;
using System.Collections.Generic;
using Consorcio.BE;
using Consorcio.DAL;

namespace Consorcio.BLL
{
    public class PermisosBLL
    {
        PermisosDAL permisosDal = new PermisosDAL();

        private const string ROL_SUPERADMIN = "SuperAdmin";
        private const string PERMISO_GESTION_USUARIOS = "GESTION_USUARIOS";

        public void CargarPermisos(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new Exception("No hay usuario para cargar permiso");
            }
            usuario.Permisos = permisosDal.ObtenerPermisosUsuario(usuario.Id_Usuario);
        }

        public List<Component> ListarTodos()
        {
            return permisosDal.ObtenerTodos();
        }

        public List<Composite> ListarRoles()
        {
            return permisosDal.ObtenerTodos().OfType<Composite>().ToList();
        }

        public void CrearRol(string nombre)
        {
            nombre = (nombre ?? "").Trim();

            if (nombre == "")
                throw new Exception("Ingrese el nombre del rol.");
            if (nombre.Length > 50)
                throw new Exception("El nombre del rol admite como máximo 50 caracteres.");

            Composite rol = new Composite(Guid.NewGuid(), nombre);

            if (permisosDal.InsertarRol(rol) == -1)
                throw new Exception("Ya existe un permiso o rol con ese nombre.");
        }
        public void EliminarRol(Composite rol)
        {
            if (rol == null)
                throw new Exception("Seleccione un rol.");
            if (string.Equals(rol.Nombre, ROL_SUPERADMIN, StringComparison.OrdinalIgnoreCase))
                throw new Exception("El rol SuperAdmin no se puede eliminar.");

            int resultado = permisosDal.EliminarRol(rol.IdPermiso);

            if (resultado == -1)
                throw new Exception("No se puede eliminar: hay usuarios con este rol.");
            if (resultado == -2)
                throw new Exception("No se puede eliminar: está incluido dentro de otro rol. Quítelo de ahí primero.");
        }

        public void AgregarPermiso(Composite rol, Component permiso)
        {
            if (rol == null)
                throw new Exception("Seleccione un rol.");
            if (permiso == null)
                throw new Exception("Seleccione el permiso a agregar.");

            rol.Agregar(permiso);

            if (permisosDal.AgregarHijo(rol.IdPermiso, permiso.IdPermiso) == -1)
                throw new Exception("Ese permiso ya está dentro del rol.");
        }

        public void SacarPermiso(Composite rol, Component permiso)
        {
            if (rol == null || permiso == null)
                throw new Exception("Seleccione el rol y el permiso a quitar.");

            Leaf leaf = permiso as Leaf;
            if (string.Equals(rol.Nombre, ROL_SUPERADMIN, StringComparison.OrdinalIgnoreCase)
                && leaf != null && leaf.Codigo == PERMISO_GESTION_USUARIOS)
                throw new Exception("El SuperAdmin no puede perder el permiso de gestión de usuarios.");

            permisosDal.QuitarHijo(rol.IdPermiso, permiso.IdPermiso);
        }

        public void AsignarRol(Guid idUsuario, Composite rol)
        {
            if (rol == null)
                throw new Exception("Seleccione un rol.");

            permisosDal.AsignarRolUsuario(idUsuario, rol.IdPermiso);
        }
    }
}
