using Biblioteca;
using Biblioteca.clases;
using Biblioteca.DAO;
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
            UsuarioDAO usuarioDao = new UsuarioDAO();
            List<Usuario> listaUsuarioRetornada = usuarioDao.ListarUsuarios();





            //JSON
            //List<Usuario> listaUsuariosRetornada = ManejadorJson.Desealizacion(Admin.RutaCompleta, typeof(List<Usuario>)) as List<Usuario>;

            foreach (Usuario usuario in listaUsuarioRetornada)
            {
                if (txtBoxUsuario.Text == usuario.NombreUsuario && txtBoxContraseña.Text == usuario.ContraseñaUsuario && usuario.Paciente is not null)
                {
                    //Admin.UsuarioGuardado = usuario;
                    Session.UsuarioActual = usuario;

                    this.Hide();
                    FrmPaciente frmPaciente = new FrmPaciente();
                    frmPaciente.ShowDialog();

                }
                else if (txtBoxUsuario.Text == usuario.NombreUsuario && txtBoxContraseña.Text == usuario.ContraseñaUsuario && usuario.Doctor is not null)
                {
                    //Admin.UsuarioGuardado = usuario;
                    Session.UsuarioActual = usuario;

                    this.Hide();
                    FrmDoctor frmDoctor = new FrmDoctor();
                    frmDoctor.ShowDialog();
                }
                else if (txtBoxUsuario.Text == usuario.NombreUsuario && txtBoxContraseña.Text == usuario.ContraseñaUsuario && usuario.Doctor is null && usuario.Paciente is null)
                {
                    this.Hide();
                    FrmAdmin frmAdmin = new FrmAdmin();
                    frmAdmin.ShowDialog();
                }
                else
                {
                    lblConfirmacion.Text = "No existe usuario con Nombre/Contraseña similares";
                }
            }

        }

        private void lnkLableRecuperacionContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuperacionContraseña frmRecuperacionContraseña = new FrmRecuperacionContraseña();
            frmRecuperacionContraseña.ShowDialog();
        }

        
    }
}
