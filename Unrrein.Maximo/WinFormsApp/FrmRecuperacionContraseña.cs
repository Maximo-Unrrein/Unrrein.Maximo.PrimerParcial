using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp
{
    public partial class FrmRecuperacionContraseña : Form
    {
        public FrmRecuperacionContraseña()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool usuarioEncontrado = false;

            foreach (Usuario usuario in Admin.ListaUsuarios)
            {
                if (txtBoxUsuario.Text == usuario.NombreUsuario)
                {
                    usuario.ContraseñaUsuario = txtBoxContraseña.Text;

                    txtBoxContraseña.Text = string.Empty;
                    txtBoxUsuario.Text = string.Empty;

                    lblConfirmacion.ForeColor = Color.Green;
                    lblConfirmacion.Text = "Cambio de contraseña correctamente ejecutado";

                    usuarioEncontrado = true;
                    break;
                }
            }

            if (!usuarioEncontrado)
            {
                lblConfirmacion.ForeColor = Color.Red;
                lblConfirmacion.Text = "Usuario no existe";
            }
            else
            {
                // Crear un temporizador para esperar 1 segundo antes de cerrar el formulario
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // 1 segundo
                timer.Tick += (s, args) =>
                {
                    timer.Stop(); // Detener el temporizador
                    this.Close(); // Cerrar el formulario
                };
                timer.Start(); // Iniciar el temporizador
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
