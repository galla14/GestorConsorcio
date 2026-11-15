using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consorcio.BE
{
    public class Expensa
    {
        public Guid IdExpensa { get; set; }
        //public Guid IdUnidad {  get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVto { get; set; }
        public double MontoOrdinario {  get; set; }
        public double MontoExtraOrd {  get; set; }
        public double RecargoXMora {  get; set; }
        public string Estado {  get; set; }
        public Unidad Unidad {  get; set; }
        public Expensa(Guid idExpensa, DateTime fechaEmision, DateTime fechaVto, double montoOrdinario, 
            double montoExtraOrd, double recargoXMora, string estado, Unidad unidad)
        {
            IdExpensa = idExpensa;
            //IdUnidad = idUnidad;
            FechaEmision = fechaEmision;
            FechaVto = fechaVto;
            MontoOrdinario = montoOrdinario;
            MontoExtraOrd = montoExtraOrd;
            RecargoXMora = recargoXMora;
            Estado = estado;
            Unidad = unidad;
        }

        public Expensa(DateTime fechaEmision, DateTime fechaVto, double montoOrdinario, double montoExtraOrd, double recargoXMora, string estado, Unidad unidad)
        {
            FechaEmision = fechaEmision;
            FechaVto = fechaVto;
            MontoOrdinario = montoOrdinario;
            MontoExtraOrd = montoExtraOrd;
            RecargoXMora = recargoXMora;
            Estado = estado;
            Unidad = unidad;
        }
        public string NombreCompleto
        {
            get { return Unidad.Piso + " , " + Unidad.Departamento; }
        }
        public override string ToString()
        {
            return Unidad.Piso + ", " + Unidad.Departamento;
        }
    }
}
