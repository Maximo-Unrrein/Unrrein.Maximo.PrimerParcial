using Biblioteca.clases;
using Biblioteca.DAO;
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
    public partial class FrmCreacionDoctor : Form
    {
        public FrmCreacionDoctor()
        {
            InitializeComponent();

            ComboBox groupBoxTurno = (ComboBox)groupBoxDatosDoctor.Controls["cmbBoxTurno"];
            ComboBox groupBoxEspecialidad = (ComboBox)groupBoxDatosDoctor.Controls["cmbBoxEspecialidad"];

            groupBoxEspecialidad.DataSource = Enum.GetValues(typeof(Especialidades));
            groupBoxTurno.DataSource = Enum.GetValues(typeof(RangoHorario));


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.ShowDialog();
        }
        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.ShowDialog();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            bool validaciones = true;

            //Datos personales
            TextBox groupBoxNombre = (TextBox)groupBoxDatosPersonales.Controls["txtBoxNombre"];
            TextBox groupBoxApellido = (TextBox)groupBoxDatosPersonales.Controls["txtBoxApellido"];
            TextBox groupBoxDNI = (TextBox)groupBoxDatosPersonales.Controls["txtBoxDNI"];
            ComboBox groupBoxGenero = (ComboBox)groupBoxDatosPersonales.Controls["cmbBoxGenero"];
            //Datos Usuario
            TextBox groupBoxNombreUsuario = (TextBox)groupBoxUsuario.Controls["txtBoxNombreUsuario"];
            TextBox groupBoxContraseñaUsuario = (TextBox)groupBoxUsuario.Controls["txtBoxContraseñaUsuario"];
            TextBox groupBoxMailUsuario = (TextBox)groupBoxUsuario.Controls["txtBoxMail"];
            //Datos Doctor
            ComboBox groupBoxTurno = (ComboBox)groupBoxDatosDoctor.Controls["cmbBoxTurno"];
            ComboBox groupBoxEspecialidad = (ComboBox)groupBoxDatosDoctor.Controls["cmbBoxEspecialidad"];


            try
            {

                UsuarioDAO usuarioDao = new UsuarioDAO();
                Doctor doctor = new Doctor(groupBoxNombre.Text, groupBoxApellido.Text, int.Parse(groupBoxDNI.Text), char.Parse(groupBoxGenero.Text), Enum.Parse<RangoHorario>(groupBoxTurno.Text), Enum.Parse<Especialidades>(groupBoxEspecialidad.Text));
                Usuario usuarioNuevo = new Usuario(doctor, groupBoxNombreUsuario.Text, groupBoxContraseñaUsuario.Text, groupBoxMailUsuario.Text);

                if (usuarioDao.CrearDoctor(usuarioNuevo))
                {
                    lblConfirmacion.ForeColor = Color.Green;
                    lblConfirmacion.Text = "Usuario creado correctamente";



                    // Reseteo de textos
                    groupBoxNombre.Text = string.Empty;
                    groupBoxApellido.Text = string.Empty;
                    groupBoxDNI.Text = string.Empty;
                    groupBoxGenero.Text = string.Empty;

                    groupBoxNombreUsuario.Text = string.Empty;
                    groupBoxContraseñaUsuario.Text = string.Empty;
                    groupBoxMailUsuario.Text = string.Empty;

                    groupBoxTurno.Text = string.Empty;
                    groupBoxEspecialidad.Text = string.Empty;
                }
                else
                {
                    lblConfirmacion.ForeColor = Color.Red;
                    lblConfirmacion.Text = "No se pudo crear el usuario correctamente";
                }



            }
            catch (Exception ex)
            {
                validaciones = false;
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
