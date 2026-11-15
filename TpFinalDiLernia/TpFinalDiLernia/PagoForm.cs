using Consorcio.BE;
using Consorcio.BLL;
using Consorcio.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Consorcio.UI
{
    public partial class PagoForm : Form
    {
        public PagoForm()
        {
            InitializeComponent();
            MostrarPagos();
        }

        PagoBLL pagoBll = new PagoBLL();
        ExpensasBLL expensaBll = new ExpensasBLL();

        public void MostrarPagos()
        {
            dgvPago.DataSource = null;
            dgvPago.DataSource = pagoBll.ConsultarPago();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtMonto.Text = "";
            txtNroComprobante.Text = "";
            txtObser.Text = "";
            cmbExpensas.DataSource = null;
            cmbMedioPago.DataSource = null;
            
        }

        private void btnIngresarPago_Click(object sender, EventArgs e)
        {
            try
            {
                Guid guid = Guid.NewGuid();
                Expensa expensaSelct = cmbExpensas.SelectedItem as Expensa;
                DateTime fechaPago = dtpFechaPago.Value;
                Double monto = Convert.ToDouble(txtMonto.Text);
                string medioPago = cmbMedioPago.Text;
                int nroCompr = Convert.ToInt16(txtNroComprobante.Text);
                string obser = txtObser.Text;

                //public Pago(Guid idPago, Expensa expensa, DateTime fechaPago, double monto, string medioPago, int nroComprobante, string observaciones)
                Pago pago = new Pago(guid, expensaSelct, fechaPago, monto, medioPago, nroCompr, obser);
                pagoBll.IngresarPago(pago);

                MostrarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PagoForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbExpensas.DataSource = expensaBll.ConsultarExpensas();
                cmbExpensas.DisplayMember = "NombreCompleto";
                cmbExpensas.ValueMember = "idExpensa";
                cmbExpensas.SelectedIndex = -1;

                cmbMedioPago.Items.AddRange(new object[] { "Tarjeta Debito", "Tarjeta Credito", "Transferencia", "Efectivo" });

                MostrarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarPago_Click(object sender, EventArgs e)
        {
            try
            {
                Pago pago = dgvPago.CurrentRow?.DataBoundItem as Pago;

                Expensa expensaSelct = cmbExpensas.SelectedItem as Expensa != null ? cmbExpensas.SelectedItem as Expensa : pago.Expensa;
                
                
                DateTime fechaPago = dtpFechaPago.Value;
                Double monto = txtMonto.Text != "" ? Convert.ToDouble(txtMonto.Text) : pago.Monto;
                string medioPago = cmbMedioPago.Text != "" ? cmbMedioPago.Text : pago.MedioPago;
                int nroCompr = txtNroComprobante.Text != "" ? Convert.ToInt32(txtNroComprobante.Text) : pago.NroComprobante;
                string obser = txtObser.Text != "" ? txtObser.Text : pago.Observaciones;

                bool validFecha = pagoBll.CompararFecha(fechaPago);
                if (validFecha)
                {
                    DialogResult  resultado = MessageBox.Show($"¿Estas seguro que la fecha que pago es {fechaPago}?", "Validar Fecha", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                
                    if (resultado == DialogResult.Yes)
                    {
                        Pago pagoModif = new Pago(pago.IdPago, expensaSelct, fechaPago, monto, medioPago, nroCompr, obser);

                        pagoBll.ModificarPago(pagoModif);
                    }

                }
                else
                {
                    Pago pagoModif = new Pago(pago.IdPago, expensaSelct, fechaPago, monto, medioPago, nroCompr, obser);

                    pagoBll.ModificarPago(pagoModif);
                }  
                MostrarPagos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            try
            {
                
                Pago pagoSelect = dgvPago.CurrentRow?.DataBoundItem as Pago;
                DialogResult resultado = MessageBox.Show($"¿Estas seguro que desea eliminar?", "Eliminar Propietario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                    pagoBll.EliminarPago(pagoSelect);
                MostrarPagos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
