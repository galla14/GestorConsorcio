using Consorcio.BE;
using Consorcio.BLL;
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
    public partial class UnidadForm : Form
    {
        public UnidadForm()
        {
            InitializeComponent();
            MostrarUnidad();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        UnidadBLL unidadBll = new UnidadBLL();
        PropietariosBLL propietarioBll = new PropietariosBLL();

        private void MostrarUnidad()
        {
            dgvUnidad.DataSource = null;
            dgvUnidad.DataSource = unidadBll.ConsultarUnidad();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtDpto.Text = "";
            txtMedida.Text = "";
            txtPiso.Text = "";
            cmbPropietarios.DataSource = null;
            rdAlquilado.Checked = false;
            rdbSi.Checked = false;
            tdbNo.Checked = false;
            radioButton1.Checked = false;
            cmbPropietarios.DataSource = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Propietario> propietarios = new List<Propietario>();
                propietarios = propietarioBll.ConsultarPropietarios();

                Guid guid = Guid.NewGuid();
                string piso = txtPiso.Text;
                string dpto = txtDpto.Text;
                float medida = float.Parse(txtMedida.Text);
                Boolean aptoAlquiler = rdbSi.Checked;
                Boolean alquilado = rdAlquilado.Checked;
                Propietario propietario = cmbPropietarios.SelectedItem as Propietario;

                Unidad unidad = new Unidad(guid, propietario, piso, dpto, medida, aptoAlquiler, alquilado);
                unidadBll.InsertarUnidad(unidad);
                MostrarUnidad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarUnidad();
        }

        private void UnidadForm_Load(object sender, EventArgs e)
        {
            cmbPropietarios.DataSource = propietarioBll.ConsultarPropietarios();
            cmbPropietarios.DisplayMember = "NombreCompleto";
            cmbPropietarios.ValueMember = "IdPropietario";
            cmbPropietarios.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Unidad unidad = dgvUnidad.CurrentRow?.DataBoundItem as Unidad;
                DialogResult resultado = MessageBox.Show($"¿Estas seguro que desea eliminar?", "Eliminar Unidad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                    unidadBll.ElimininarUnidad(unidad.idUnidad);
                MostrarUnidad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Unidad unidadSelect = dgvUnidad.CurrentRow?.DataBoundItem as Unidad;
                Guid idUnidad = unidadSelect.idUnidad;
                string piso = txtPiso.Text != "" ? txtPiso.Text : unidadSelect.Piso;
                string dpto = txtDpto.Text != "" ? txtDpto.Text : unidadSelect.Departamento;
                float medida = txtMedida.Text != "" ? float.Parse(txtMedida.Text) : unidadSelect.MedidaDpto;
                Boolean aptoAlquiler = rdbSi.Checked != null ? rdbSi.Checked : unidadSelect.AptoAlquiler;
                Boolean alquilado = rdAlquilado.Checked != null ? rdAlquilado.Checked : unidadSelect.Alquilado;
                Propietario propietario = cmbPropietarios.SelectedItem as Propietario;

                Unidad unidadModificar = new Unidad(idUnidad,propietario, piso, dpto, medida, aptoAlquiler, alquilado);

                int retorno = unidadBll.ModificarUnidad(unidadModificar);
                MostrarUnidad();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
