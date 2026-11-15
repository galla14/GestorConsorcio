using Consorcio.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpFinalDiLernia;

namespace Consorcio.UI
{
    public partial class SuperAdministrador : Form
    {

        private Usuario usuarioLogueado;
        public SuperAdministrador(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;

            btnGestionUser.Visible = usuario.TienePermiso("GESTION_USUARIOS");
            btnPropietario.Visible = usuario.TienePermiso("PROPIETARIOS");
            btnUnidad.Visible = usuario.TienePermiso("UNIDADES");
            btnExpensas.Visible = usuario.TienePermiso("EXPENSAS");
            btnPago.Visible = usuario.TienePermiso("PAGOS");
            btnRoles.Visible = usuario.TienePermiso("GESTION_ROLES");
        }

        private void btnPropietario_Click(object sender, EventArgs e)
        {
            try
            {
                PropietarioForm propietarioForm = new PropietarioForm();
                propietarioForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnUnidad_Click(object sender, EventArgs e)
        {
            try
            {
                UnidadForm unidadForm = new UnidadForm();
                unidadForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnExpensas_Click(object sender, EventArgs e)
        {
            ExpensasForm expensaForm = new ExpensasForm();
            expensaForm.ShowDialog();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            PagoForm pagoForm = new PagoForm();
            pagoForm.ShowDialog();
        }

        private void btnGestionUser_Click(object sender, EventArgs e)
        {
            GestionUser gestion = new GestionUser();
            gestion.ShowDialog();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            GestionRoles roles = new GestionRoles();
            roles.ShowDialog();
        }
    }
}
