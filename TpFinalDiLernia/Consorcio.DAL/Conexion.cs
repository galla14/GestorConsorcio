using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
using Microsoft.IdentityModel.Protocols;

namespace Consorcio.DAL
{
    public class Conexion
    {
        public string ObtenerCadenas()
        {
            ConnectionStringSettings cadena = ConfigurationManager.ConnectionStrings["GestorConsorcio"];
            if (cadena == null)
            {
                throw new Exception("No se encontro el connection string");
            }

            return cadena.ConnectionString;
        }
    }
}
