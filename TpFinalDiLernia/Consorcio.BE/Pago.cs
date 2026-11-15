using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Consorcio.BE
{
    public class Pago
    {
        public Guid IdPago {  get; set; }
        public Expensa Expensa { get; set; }
        public DateTime FechaPago { get; set; }
        public double Monto { get; set; }
        public string MedioPago {  get; set; }
        public int NroComprobante {  get; set; }
        public string Observaciones {  get; set; }
        public Pago(Guid idPago, Expensa expensa, DateTime fechaPago, double monto, string medioPago, int nroComprobante, string observaciones)
        {
            IdPago = idPago;
            Expensa = expensa;
            FechaPago = fechaPago;
            Monto = monto;
            MedioPago = medioPago;
            NroComprobante = nroComprobante;
            Observaciones = observaciones;
        }

        public Pago(Expensa expensa, DateTime fechaPago, double monto, string medioPago, int nroComprobante, string observaciones)
        {
            Expensa = expensa;
            FechaPago = fechaPago;
            Monto = monto;
            MedioPago = medioPago;
            NroComprobante = nroComprobante;
            Observaciones = observaciones;
        }

    }
}
