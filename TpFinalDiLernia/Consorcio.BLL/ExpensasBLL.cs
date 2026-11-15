using Consorcio.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consorcio.BE;

namespace Consorcio.BLL
{
    public class ExpensasBLL
    {
        ExpensasDAL expensasDal = new ExpensasDAL();
        public List<Expensa> ConsultarExpensas()
        {
            return expensasDal.ConsultarExpensas();
        }
        public int InsertarExpensa(Expensa expensa)
        {
            ValidarCampos(expensa);
            return expensasDal.InsertarExpensa(expensa);
        }
        public int ModificarExpensas(Expensa expensa)
        {
            ValidarCampos(expensa);
            return expensasDal.ModificarExpensa(expensa);
        }
        public int EliminarExpensa(Expensa expensa)
        {
            return expensasDal.EliminarExpensa(expensa);
        }

        private void ValidarCampos(Expensa expensa)
        {
            if (expensa.MontoOrdinario == null || string.IsNullOrWhiteSpace(expensa.Estado))
                throw new Exception("Faltan campos obligatorios.");
        }
    }
}
