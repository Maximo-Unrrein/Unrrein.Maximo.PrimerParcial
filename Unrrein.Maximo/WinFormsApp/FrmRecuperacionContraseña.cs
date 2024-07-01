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
    public partial class FrmRecuperacionContraseña : Form
    {
        public FrmRecuperacionContraseña()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Admin.ListaUsuarios = ManejadorJson.Desealizacion(Admin.RutaCompleta, typeof(List<Usuario>)) as List<Usuario>;
            //bool flagCambioContraseña = false;




            if (txtBoxUsuario.Text == Session.UsuarioActual.NombreUsuario && txtBoxMail.Text == Session.UsuarioActual.Mail)
            {
                UsuarioDAO usuarioDao = new UsuarioDAO();
                usuarioDao.CambiarContraseña(Session.UsuarioActual, txtBoxContraseña.Text);


                txtBoxUsuario.Text = string.Empty;
                txtBoxMail.Text = string.Empty;
                txtBoxContraseña.Text = string.Empty;

                lblConfirmacion.ForeColor = Color.Green;
                lblConfirmacion.Text = "Cambio de contraseña correctamente ejecutado";

            }
            else
            {
                lblConfirmacion.ForeColor = Color.Red;
                lblConfirmacion.Text = "Usuario no existe";
            }


            //List<Usuario> listaAuxUsuario = Admin.ListaUsuarios.ToList();
            //foreach(Usuario usuario in listaAuxUsuario)
            //{
            //    if(txtBoxUsuario.Text == usuario.NombreUsuario && txtBoxMail.Text == usuario.Mail)
            //    {



            //        if(usuario.Paciente is not null)
            //        {
            //            Usuario cambioUsuario = new Usuario(usuario.Paciente, usuario.NombreUsuario, txtBoxContraseña.Text, usuario.Mail);

            //            Admin.ListaUsuarios.Remove(usuario);
            //            Admin.ListaUsuarios.Add(cambioUsuario);
            //        }
            //        else if(usuario.Doctor is not null)
            //        {
            //            Usuario cambioUsuario = new Usuario(usuario.Doctor, usuario.NombreUsuario, txtBoxContraseña.Text, usuario.Mail);

            //            Admin.ListaUsuarios.Remove(usuario);
            //            Admin.ListaUsuarios.Add(cambioUsuario);
            //        }

            //        flagCambioContraseña = true;

            //        txtBoxUsuario.Text = string.Empty;
            //        txtBoxMail.Text = string.Empty;
            //        txtBoxContraseña.Text = string.Empty;

            //        lblConfirmacion.ForeColor = Color.Green;
            //        lblConfirmacion.Text = "Cambio de contraseña correctamente ejecutado";
            //    }
            //    else
            //    {
            //        lblConfirmacion.ForeColor = Color.Red;
            //        lblConfirmacion.Text = "Usuario no existe";
            //    }
            //}


            //if(flagCambioContraseña)
            //{
            //    ManejadorJson.Serializacion(Admin.ListaUsuarios, Admin.RutaCompleta);
            //}

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
