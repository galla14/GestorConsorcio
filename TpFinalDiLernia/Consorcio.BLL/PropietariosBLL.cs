using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Consorcio.BE;
using Consorcio.DAL;

namespace Consorcio.BLL
{
    public class PropietariosBLL
    {
        PropietariosDAL propietarioDal = new PropietariosDAL();
        public List<Propietario> ConsultarPropietarios()
        {
            return propietarioDal.ConsultarPropietarios();
        }

        public void InsertarPropietario(Propietario propietario)
        {
            ValidarCampos(propietario);
            propietarioDal.InsertarPropietario(propietario);
        }

        public void EliminarPropietario(Guid idPropietario)
        {
            propietarioDal.EliminarPropietario(idPropietario);   
        }
        public void ModificarPropietario(Propietario propietario)
        {
            ValidarCampos(propietario);
            propietarioDal.ModificarPropietario(propietario);
        }

        private void ValidarCampos(Propietario propietario)
        {
            if (string.IsNullOrWhiteSpace(propietario.Nombre) || string.IsNullOrWhiteSpace(propietario.Apellido) || string.IsNullOrWhiteSpace(propietario.DNI))
                throw new Exception("Faltan campos obligatorios.");
        }        
    }
}
