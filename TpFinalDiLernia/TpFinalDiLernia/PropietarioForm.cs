using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using Consorcio.BE;
using Consorcio.BLL;

namespace TpFinalDiLernia
{
    public partial class PropietarioForm : Form
    {

        public PropietarioForm()
        {
            InitializeComponent();
            MostrarPropietarios();
        }

        private void LimpiarCampos()
        {
            txtApellido.Text = "";
            txtDni.Text = "";
            txtNombre.Text = "";
            txtNroCel.Text = "";
        }

        public List<Propietario> propietarios = new List<Propietario>();
        public PropietariosBLL propietarioBLL = new PropietariosBLL();

        private XDocument documento;

        private void btnAgregarProp_Click(object sender, EventArgs e)
        {
            try
            {
                Propietario propietario = new Propietario(Guid.NewGuid(), txtNombre.Text, txtApellido.Text, txtDni.Text, txtNroCel.Text);
                propietarioBLL.InsertarPropietario(propietario);
                MostrarPropietarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MostrarPropietarios()
        {
            dgvPropietario.DataSource = null;
            dgvPropietario.DataSource = propietarioBLL.ConsultarPropietarios();
            LimpiarCampos();
        }

        private void btnConsPropietarios_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarPropietarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarProp_Click(object sender, EventArgs e)
        {
            try
            {
                Propietario propietario = dgvPropietario.CurrentRow?.DataBoundItem as Propietario;
                DialogResult resultado = MessageBox.Show($"¿Estas seguro que desea eliminar?", "Eliminar Propietario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                    propietarioBLL.EliminarPropietario(propietario.IdPropietario);

                MostrarPropietarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarProp_Click(object sender, EventArgs e)
        {
            try
            {
                Propietario propietario = dgvPropietario.CurrentRow?.DataBoundItem as Propietario;

                Guid guid = propietario.IdPropietario;
                string nombre = txtNombre.Text != null ? txtNombre.Text : propietario.Nombre;
                string apellido = txtApellido.Text != null ? txtApellido.Text : propietario.Apellido;
                string dni = txtDni.Text != null ? txtDni.Text : propietario.DNI;
                string nroCel = txtNroCel != null ? txtNroCel.Text : propietario.NroCelular;
                Propietario propietarioMod = new Propietario (guid,nombre, apellido, dni, nroCel);

                propietarioBLL.ModificarPropietario(propietarioMod);

                MostrarPropietarios();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
