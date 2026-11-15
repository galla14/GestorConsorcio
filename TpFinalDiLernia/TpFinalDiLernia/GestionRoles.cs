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
using Consorcio.BE;
using Consorcio.BLL;

using Component = Consorcio.BE.Component;


namespace Consorcio.UI
{
    public partial class GestionRoles : Form
    {
        public GestionRoles()
        {
            InitializeComponent();
            CargarDatos();
            MostrarArbol();
        }

        PermisosBLL permisosBll = new PermisosBLL();

        private void CargarDatos()
        {
            try
            {
                Composite rolAnterior = RolSeleccionado();

                List<Component> todos = permisosBll.ListarTodos();

                List<Composite> roles = new List<Composite>();
                foreach (Component permiso in todos)
                {
                    Composite rol = permiso as Composite;
                    if (rol != null)
                        roles.Add(rol);
                }

                dgvRoles.DataSource = null;
                dgvRoles.DataSource = roles;
                if (dgvRoles.Columns["IdPermiso"] != null)
                    dgvRoles.Columns["IdPermiso"].Visible = false;

                // Catálogo: roles y hojas (todo lo que se puede meter en un rol)
                dgvPermisos.DataSource = null;
                dgvPermisos.DataSource = todos;
                if (dgvPermisos.Columns["IdPermiso"] != null)
                    dgvPermisos.Columns["IdPermiso"].Visible = false;

                // Vuelve a seleccionar el rol que estaba elegido antes de recargar
                if (rolAnterior != null)
                {
                    foreach (DataGridViewRow fila in dgvRoles.Rows)
                    {
                        Composite rol = fila.DataBoundItem as Composite;
                        if (rol != null && rol.IdPermiso == rolAnterior.IdPermiso)
                        {
                            dgvRoles.CurrentCell = fila.Cells["Nombre"];
                            break;
                        }
                    }
                }

                MostrarArbol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Composite RolSeleccionado()
        {
            if (dgvRoles.CurrentRow == null)
                return null;

            return dgvRoles.CurrentRow.DataBoundItem as Composite;
        }

        private void MostrarArbol()
        {
            tvRol.Nodes.Clear();

            Composite rol = RolSeleccionado();
            if (rol == null) return;

            tvRol.Nodes.Add(CrearNodo(rol));
            tvRol.ExpandAll();
        }

        private TreeNode CrearNodo(Component componente)
        {
            string texto;
            Leaf leaf = componente as Leaf;
            if (leaf != null)
                texto = componente.Nombre + " (" + leaf.Codigo + ")";   // hoja: muestra su código
            else
                texto = "[Rol] " + componente.Nombre;                    // compuesto

            TreeNode nodo = new TreeNode(texto);
            nodo.Tag = componente;   // guardo el objeto en el nodo para usarlo al quitar

            foreach (Component hijo in componente.ObtenerHijos())
                nodo.Nodes.Add(CrearNodo(hijo));   // se llama a sí mismo para cada hijo

            return nodo;
        }

        private void dgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            MostrarArbol();
        }

        private void btnCrearRol_Click_1(object sender, EventArgs e)
        {
            try
            {
                permisosBll.CrearRol(txtNombreRol.Text);
                txtNombreRol.Clear();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            try
            {
                Composite rol = RolSeleccionado();
                if (rol == null)
                {
                    MessageBox.Show("Seleccione un rol.");
                    return;
                }

                if (MessageBox.Show("¿Eliminar el rol " + rol.Nombre + "?", "Confirmar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                permisosBll.EliminarRol(rol);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                Composite rol = RolSeleccionado();
                Component permiso = null;
                if (dgvPermisos.CurrentRow != null)
                    permiso = dgvPermisos.CurrentRow.DataBoundItem as Component;

                permisosBll.AgregarPermiso(rol, permiso);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSacarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                Composite rol = RolSeleccionado();
                TreeNode nodo = tvRol.SelectedNode;

                // Solo se puede quitar lo que está DIRECTAMENTE dentro del rol (segundo nivel del árbol)
                if (nodo == null || nodo.Parent == null || nodo.Parent.Parent != null)
                {
                    MessageBox.Show("Seleccione en el árbol un permiso que esté directamente dentro del rol.");
                    return;
                }

                permisosBll.SacarPermiso(rol, (Component)nodo.Tag);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (RolSeleccionado() == null)
                {
                    MessageBox.Show("Seleccione un rol en la grilla de Roles.");
                    return;
                }

                MostrarArbol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
