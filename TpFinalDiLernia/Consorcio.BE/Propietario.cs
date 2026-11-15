using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consorcio.BE
{
    public class Propietario
    {
        public Guid IdPropietario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string NroCelular { get; set; }
        public Propietario(Guid idPropietario, string nombre, string apellido, string dNI, string nroCelular)
        {
            IdPropietario = idPropietario;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            NroCelular = nroCelular;
        }
        public Propietario(string nombre, string apellido, string dNI, string nroCelular)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            NroCelular = nroCelular;
        }

        public string NombreCompleto
        {
            get { return Nombre + " , " + Apellido; }
        }
        public override string ToString()
        {
            return Apellido + ", " + Nombre;
        }
    }
}
