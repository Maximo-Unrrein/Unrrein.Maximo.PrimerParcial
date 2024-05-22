using Biblioteca;
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

        private void button1_Click(object sender, EventArgs e)
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

            // Validar nombre
            if (groupBoxNombre == null || !Validaciones.NombreYApellido(groupBoxNombre.Text))
            {
                validaciones = false;
            }

            // Validar apellido
            if (groupBoxApellido == null || !Validaciones.NombreYApellido(groupBoxApellido.Text))
            {
                validaciones = false;
            }

            // Validar DNI
            if (groupBoxDNI == null || !Validaciones.DNI(groupBoxDNI.Text))
            {
                validaciones = false;
            }

            // Validar género
            if (groupBoxGenero == null || groupBoxGenero.SelectedIndex == -1)
            {
                validaciones = false;
            }

            // Validar usuario
            if (string.IsNullOrEmpty(txtBoxUsuario.Text))
            {
                validaciones = false;
            }

            // Validar contraseña
            if (string.IsNullOrEmpty(txtBoxContraseña.Text))
            {
                validaciones = false;
            }

            // Validar confirmación de contraseña
            if (string.IsNullOrEmpty(txtBoxConfirmarContraseña.Text))
            {
                validaciones = false;
            }

            if(txtBoxContraseña.Text != txtBoxConfirmarContraseña.Text) 
            {
                validaciones = false;
            }


            // Mostrar resultado de validación
            if (validaciones)
            {
                // Aquí iría la lógica para crear el usuario
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
