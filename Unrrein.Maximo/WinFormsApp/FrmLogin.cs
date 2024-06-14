using Biblioteca;
using Biblioteca.clases;
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

            List<Usuario> listaUsuariosRetornada = ManejadorJson.Desealizacion(Admin.RutaCompleta, typeof(List<Usuario>)) as List<Usuario>;

            foreach (Usuario usuario in listaUsuariosRetornada)
            {
                if (txtBoxUsuario.Text == usuario.NombreUsuario && txtBoxContraseña.Text == usuario.ContraseñaUsuario && usuario.Paciente is not null)
                {
                    Admin.UsuarioGuardado = usuario;

                    this.Hide();
                    FrmPaciente frmPaciente = new FrmPaciente();
                    frmPaciente.ShowDialog();
                }
                else if (txtBoxUsuario.Text == usuario.NombreUsuario && txtBoxContraseña.Text == usuario.ContraseñaUsuario && usuario.Doctor is not null)
                {
                    Admin.UsuarioGuardado = usuario;

                    this.Hide();
                    FrmDoctor frmDoctor = new FrmDoctor();
                    frmDoctor.ShowDialog();
                }
                else
                {
                    lblConfirmacion.Text = "No existe usuario con Nombre/Contraseña similares";
                }
            }

            //foreach (Usuario usuario in Admin.ListaUsuarios)
            //{
            //    if (txtBoxUsuario.Text == usuario.NombreUsuario && txtBoxContraseña.Text == usuario.ContraseñaUsuario && usuario.Persona is Paciente)
            //    {
            //        Admin.UsuarioGuardado = usuario;

            //        this.Hide();
            //        FrmPaciente frmPaciente = new FrmPaciente();
            //        frmPaciente.ShowDialog();
            //    }
            //    else if (txtBoxUsuario.Text == usuario.NombreUsuario && txtBoxContraseña.Text == usuario.ContraseñaUsuario && usuario.Persona is Doctor)
            //    {
            //        Admin.UsuarioGuardado = usuario;


            //        this.Hide();
            //        FrmDoctor frmDoctor = new FrmDoctor();
            //        frmDoctor.ShowDialog();
            //    }
            //    else
            //    {
            //        lblConfirmacion.Text = "No existe usuario con Nombre/Contraseña similares";
            //    }
            //}





        }

        private void lnkLableRecuperacionContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuperacionContraseña frmRecuperacionContraseña = new FrmRecuperacionContraseña();
            frmRecuperacionContraseña.ShowDialog();
        }
    }
}
