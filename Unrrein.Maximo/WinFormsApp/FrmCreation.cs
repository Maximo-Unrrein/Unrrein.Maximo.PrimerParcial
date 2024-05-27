using Biblioteca;
using Biblioteca.excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp
{
    public partial class FrmCreation : Form
    {
        public FrmCreation()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu login = new FrmMenu();
            login.ShowDialog();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {

            bool validaciones = true;

            //Datos persona
            TextBox groupBoxNombre = (TextBox)grpBoxDatosPersona.Controls["txtBoxNombrePersona"];
            TextBox groupBoxApellido = (TextBox)grpBoxDatosPersona.Controls["txtBoxApellidoPersona"];
            TextBox groupBoxDNI = (TextBox)grpBoxDatosPersona.Controls["txtBoxDNIPersona"];
            ComboBox groupBoxGenero = (ComboBox)grpBoxDatosPersona.Controls["cmbBoxGeneroPersona"];



            try
            {
                if(txtBoxContraseña.Text == txtBoxConfirmarContraseña.Text)
                {
                    Paciente paciente = new Paciente(groupBoxNombre.Text, groupBoxApellido.Text, int.Parse(groupBoxDNI.Text), char.Parse(groupBoxGenero.Text));
                    Usuario usuarioNuevo = new Usuario(paciente, txtBoxUsuario.Text, txtBoxContraseña.Text, DateTime.Now);

                    Admin.ListaUsuarios.Add(usuarioNuevo);
                    SerializadorJson.Serializacion(Admin.ListaUsuarios, "ListaUsuarios.json");

                }
                else
                {
                    throw new ContraseñaInvalidaException("Error con la contraseña");
                }
            }
            catch (ContraseñaInvalidaException ex)
            {
                validaciones = false;
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception ex)
            {
                validaciones = false;
                //MessageBox.Show("Argumento invalido");
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            // Mostrar resultado de validación
            if (validaciones)
            {

                lblConfirmacionCreacionUsuario.ForeColor = Color.Green;
                lblConfirmacionCreacionUsuario.Text = "Usuario creado correctamente";



                // Reseteo de textos
                groupBoxNombre.Text = string.Empty;
                groupBoxApellido.Text = string.Empty;
                groupBoxDNI.Text = string.Empty;
                groupBoxGenero.Text = string.Empty;

                txtBoxUsuario.Text = string.Empty;
                txtBoxContraseña.Text = string.Empty;
                txtBoxConfirmarContraseña.Text = string.Empty;
            }
            else
            {
                lblConfirmacionCreacionUsuario.ForeColor = Color.Red;
                lblConfirmacionCreacionUsuario.Text = "No se pudo crear el usuario correctamente";
            }




        }
    }
}
