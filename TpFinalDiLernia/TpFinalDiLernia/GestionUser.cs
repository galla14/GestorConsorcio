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
    public partial class GestionUser : Form
    {
        public GestionUser()
        {
            InitializeComponent();
        }

        UsuarioBLL UsuarioBLL = new UsuarioBLL();
        PermisosBLL permisosBll = new PermisosBLL();

        private void GestionUser_Load(object sender, EventArgs e)
        {
            try
            {
                CargarRoles();
                MostrarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            cmbRol.DataSource = null;
            txtPass.Text = "";
            txtUser.Text = "";
        }

        private void CargarRoles()
        {
            cmbRol.DataSource = null;
            cmbRol.DataSource = permisosBll.ListarRoles();
            cmbRol.DisplayMember = "Nombre";
            cmbRol.SelectedIndex = -1;
        }

        private void MostrarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = UsuarioBLL.ConsultarTodosUsuarios();
            LimpiarCampos();
        }

        private void btnCrearUser_Click(object sender, EventArgs e)
        {
            try
            {

                Composite rol = cmbRol.SelectedItem as Composite;
                if (rol == null)
                {
                    MessageBox.Show("Seleccione un rol.");
                    return;
                }

                Guid guid = Guid.NewGuid();
                string user = txtUser.Text;
                string pass = txtPass.Text;
                bool activo = true;
                int intentos = 0;
                bool bloq = false;
                DateTime fechaAlta = DateTime.Now;

                Usuario usuario = new Usuario(guid, user, pass, rol.Nombre, activo, intentos, bloq, fechaAlta);
                //bool validUser = UsuarioBLL.ValidarUsuario(usuario);
                if (UsuarioBLL.ValidarUsuario(usuario))
                {
                    int result = UsuarioBLL.CrearUsuario(usuario);
                    if (result == 1)
                    {
                        permisosBll.AsignarRol(guid, rol);
                        MostrarUsuarios();
                        MessageBox.Show("Usuario Creado con exito", "Usuario Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error creando usuario", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Caracteres invalidos al crear Usuario - Ejemplo:{ABC12345}", "Usuario Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MostrarUsuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifUser_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuarioSelected = dgvUsuarios.CurrentRow?.DataBoundItem as Usuario;
                string user = txtUser.Text != "" ? txtUser.Text : usuarioSelected.NombreUsuario;
                string pass = txtPass.Text != "" ? txtPass.Text : usuarioSelected.Password;
                string rol = cmbRol.Text != "" ? cmbRol.Text : usuarioSelected.Rol;
                Usuario usuarioModif = new Usuario(usuarioSelected.Id_Usuario, user, pass, rol);

                if (UsuarioBLL.ValidarUsuario(usuarioModif))
                {
                    int retorno = UsuarioBLL.ModificarUsuario(usuarioModif);
                    if (retorno == 1)
                    {
                        MessageBox.Show("Usuario Modificado con exito", "Usuario Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error Modificado usuario", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Caracteres invalidos al crear Usuario - Ejemplo:{ABC12345}", "Usuario Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                MostrarUsuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultUser_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuerioSelected = dgvUsuarios.CurrentRow?.DataBoundItem as Usuario;
                int retorno = UsuarioBLL.EliminarUsuario(usuerioSelected.Id_Usuario);
                MostrarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuerioSelected = dgvUsuarios.CurrentRow?.DataBoundItem as Usuario;
                UsuarioBLL.DesbloqueoUsuario(usuerioSelected.NombreUsuario);
                MessageBox.Show("Usuario Desbloqueado", "Desbloqueos", MessageBoxButtons.OK);
                MostrarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
