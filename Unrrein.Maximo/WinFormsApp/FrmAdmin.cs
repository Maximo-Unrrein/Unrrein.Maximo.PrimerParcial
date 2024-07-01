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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            this.CargarTabla();



        }

        public void CargarTabla()
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> listaUsuarios = usuarioDAO.ListarUsuarios();

            // Limpiar el DataGridView antes de cargar los datos
            dataGridViewUsuarios.Rows.Clear();

            foreach (Usuario usuario in listaUsuarios)
            {

                string ocupacion = string.Empty;
                if (usuario.Doctor is not null)
                {
                    ocupacion = "Doctor";
                }
                else if (usuario.Paciente is not null)
                {
                    ocupacion = "Paciente";
                }


                if (usuario.NombreUsuario != "admin")
                {
                    dataGridViewUsuarios.Rows.Add(false, usuario.NombreUsuario, usuario.ContraseñaUsuario, ocupacion);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuariosParaEliminar = new List<Usuario>();

            foreach (DataGridViewRow filas in dataGridViewUsuarios.Rows)
            {
                bool seleccion = Convert.ToBoolean(filas.Cells["Seleccion"].Value);


                if (seleccion)
                {
                    string nombreUsuario = filas.Cells["Usuario"].Value.ToString();

                    Usuario usuario = ObtenerUsuarioPorNombre(nombreUsuario); // BIEN

                    if (usuario is not null)
                    {
                        usuariosParaEliminar.Add(usuario);
                    }
                }


            }

            if (usuariosParaEliminar.Count > 0)
            {
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                if (usuarioDAO.EliminarUsuarios(usuariosParaEliminar)) // MAL
                {
                    // Actualizar la tabla
                    this.CargarTabla();

                    lblConfirmacion.ForeColor = Color.Green;
                    lblConfirmacion.Text = "Usuarios\neliminados\ncorrectamente";

                }
                else
                {
                    lblConfirmacion.ForeColor = Color.Red;
                    lblConfirmacion.Text = "Error al\neliminar los\nusuarios";

                }
            }
            else
            {
                lblConfirmacion.ForeColor = Color.Red;
                lblConfirmacion.Text = "No se \nseleccionaron\nusuarios para\neliminar";

            }




        }


        private Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> listaUsuarios = usuarioDAO.ListarUsuarios();

            Usuario usuarioRetorno = new Usuario();
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario)
                {
                    usuarioRetorno = usuario;
                }
            }

            return usuarioRetorno;
        }

        private void btnCrearDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmCreacionDoctor frmCreacionDoctor = new FrmCreacionDoctor();
            frmCreacionDoctor.ShowDialog();
        }
    }
}
