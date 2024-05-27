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
            foreach (Usuario usuario in Admin.ListaUsuarios)
            {
                if (txtBoxUsuario.Text == usuario.NombreUsuario)
                {
                    usuario.ContraseñaUsuario = txtBoxContraseña.Text;

                    txtBoxContraseña.Text = string.Empty;
                    txtBoxUsuario.Text = string.Empty;

                    lblConfirmacion.ForeColor = Color.Green;
                    lblConfirmacion.Text = "Cambio de contraseña correctamente ejecutado";


                }
                else
                {
                    lblConfirmacion.ForeColor = Color.Red;
                    lblConfirmacion.Text = "Usuario no existe";

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
