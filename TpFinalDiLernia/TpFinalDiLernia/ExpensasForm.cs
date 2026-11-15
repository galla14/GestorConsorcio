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

namespace Consorcio.UI
{
    public partial class ExpensasForm : Form
    {
        public ExpensasForm()
        {
            InitializeComponent();
            MostrarExpensas();
        }

        private void LimpiarCampos()
        {
            txtMontoExtraord.Text = "";
            txtMontoOrd.Text = "";
            btnRecargo.Text = "";
            cmbEstado.DataSource = null;
        }

        ExpensasBLL expensasBll = new ExpensasBLL();
        UnidadBLL unidadBll = new UnidadBLL();

        private void MostrarExpensas()
        {
            dgvExpensas.DataSource = null;
            dgvExpensas.DataSource = expensasBll.ConsultarExpensas();
            LimpiarCampos();
        }
        private void ExpensasForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbUnidad.DataSource = unidadBll.ConsultarUnidad();
                cmbUnidad.DisplayMember = "NombreCompleto";
                cmbUnidad.ValueMember = "idUnidad";                
                cmbUnidad.SelectedIndex = -1;

                cmbEstado.Items.AddRange(new object[] { "Pago", "Impago", "Pago atrasado", "Vencio" });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                Unidad unidadSelct = cmbUnidad.SelectedItem as Unidad;
                //Guid guid = new Guid();
                Guid guid  = Guid.NewGuid();
                DateTime fechaEmsion = dtEmision.Value;
                DateTime fechavto = dtVencimiento.Value;
                Double montoOrd = Convert.ToDouble(txtMontoOrd.Text);
                Double montoExtra = txtMontoExtraord.Text != "" ? Convert.ToDouble(txtMontoExtraord.Text): 0;
                Double recargo = btnRecargo.Text != "" ? Convert.ToDouble(btnRecargo.Text) : 0;
                string estado = cmbEstado.Text;
                Expensa expensas = new Expensa(guid, fechaEmsion, fechavto, montoOrd, montoExtra, recargo, estado, unidadSelct);

                expensasBll.InsertarExpensa(expensas);
                MostrarExpensas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                Expensa expensaSelected = dgvExpensas.DataSource as Expensa;
                DialogResult resultado = MessageBox.Show($"¿Estas seguro que desea eliminar?", "Eliminar Propietario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                    expensasBll.EliminarExpensa(expensaSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                Expensa expensaSelected = dgvExpensas.CurrentRow?.DataBoundItem as Expensa;


                Unidad unidadSelct = cmbUnidad.SelectedItem as Unidad;
                unidadSelct = unidadSelct == null ? expensaSelected.Unidad : unidadSelct;

                DateTime fechaEmsion = dtEmision.Value;
                DateTime fechavto = dtVencimiento.Value;
                Double montoOrd = txtMontoOrd.Text != "" ? Convert.ToDouble(txtMontoOrd.Text) : expensaSelected.MontoExtraOrd;
                Double montoExtra = txtMontoExtraord.Text != "" ? Convert.ToDouble(txtMontoExtraord.Text) : expensaSelected.MontoExtraOrd;
                Double recargo = btnRecargo.Text != "" ? Convert.ToDouble(btnRecargo.Text) : expensaSelected.RecargoXMora;
                string estado = cmbEstado.Text != "" ? cmbEstado.Text : expensaSelected.Estado;

                Expensa expensas = new Expensa(expensaSelected.IdExpensa,fechaEmsion, fechavto, montoOrd, montoExtra, recargo, estado, unidadSelct);

                expensasBll.ModificarExpensas(expensas);
                MostrarExpensas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarExpensas();
        }
    }
}
