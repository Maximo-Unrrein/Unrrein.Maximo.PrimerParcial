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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.ShowDialog();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Admin.ListaUsuarios)
            {
                if (txtBoxUsuario.Text == usuario.NombreUsuario && txtBoxContraseña.Text == usuario.ContraseñaUsuario)
                {
                    this.Hide();
                    FrmPaciente frmPaciente = new FrmPaciente();
                    frmPaciente.ShowDialog();
                }
                else
                {
                    lblConfirmacion.Text = "No existe usuario con Nombre/Contraseña similares";
                }
            }





        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
