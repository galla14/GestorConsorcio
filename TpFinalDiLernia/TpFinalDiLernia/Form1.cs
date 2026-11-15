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
using TpFinalDiLernia;

namespace Consorcio.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UsuarioBLL usuarioBll = new UsuarioBLL();

        private void LimpiarCampos()
        {
            txtUser.Text = "";
            txtPassw.Text = "";
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUser.Text;
                string pass = txtPassw.Text;

                int resultado = usuarioBll.ConsultarUsuario(user, pass);

                if (resultado == 1 || resultado == 2)
                {
                    Usuario usuario = usuarioBll.ObtenerUsuarioLogueado(user);

                    SuperAdministrador superAdmin = new SuperAdministrador(usuario);
                    superAdmin.Show();
                    
                }else if(resultado == -1)
                {
                    MessageBox.Show("Usuario Inactivo. Contacte al superadministrador.", "Acceso denegado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == -2)
                {
                    MessageBox.Show("Usuario bloqueado. Contacte al superadministrador.", "Acceso denegado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == -3)
                {
                    MessageBox.Show("Superó los 3 intentos. Su usuario fue bloqueado.", "Acceso denegado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LimpiarCampos();
            }
        }

        private void btnPassw_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReestablecerPass_Click(object sender, EventArgs e)
        {
            try
            {

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
