using Consorcio.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consorcio.BE;

namespace Consorcio.BLL
{
    public class PagoBLL
    {
        PagoDAL pagoDal = new PagoDAL();

        public List<Pago> ConsultarPago()
        {
            return pagoDal.ConsultarPagos();
        }

        public int IngresarPago(Pago pago)
        {
            ValidarCampos(pago);
            return pagoDal.InsertarPago(pago);
        }
        public int ModificarPago(Pago pago)
        {
            ValidarCampos(pago);
            return pagoDal.ModificarPago(pago);
        }
        public int EliminarPago(Pago pago)
        {
            return pagoDal.EliminarPago(pago);
        }

        public bool CompararFecha(DateTime fechaModif)
        {
            DateTime fechaHoy = DateTime.Today;
            if (fechaModif.Date == fechaHoy)
            {
                return true;
            }
            return false;   
        }

        private void ValidarCampos(Pago pago)
        {
            if (pago.Expensa == null || pago.Monto <= 0 || pago.NroComprobante <= 0 || string.IsNullOrWhiteSpace(pago.Observaciones))
                throw new Exception("Error en campos obligatorios.");
        }

    }
}
