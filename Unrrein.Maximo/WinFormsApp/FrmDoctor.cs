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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp
{
    public partial class FrmDoctor : Form
    {
        Doctor doctor = (Doctor)Admin.UsuarioGuardado.Persona;

        public FrmDoctor()
        {
            InitializeComponent();



            cmbBoxPacientes.DataSource = doctor.ListaPacientes;
            // Establecer las propiedades DisplayMember y ValueMember si es necesario
            cmbBoxPacientes.DisplayMember = "Nombre"; // Propiedad a mostrar

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void btnMostrarDatosPaciente_Click(object sender, EventArgs e)
        {

            // Limpiar el ListBox antes de mostrar los datos
            lstBoxDatos.Items.Clear();

            foreach (Paciente paciente in doctor.ListaPacientes)
            {
                if(cmbBoxPacientes.Text == paciente.Nombre)
                {

                    lstBoxDatos.Items.Add("Nombre: " + paciente.Nombre);
                    lstBoxDatos.Items.Add("Apellido: " + paciente.Apellido);
                    lstBoxDatos.Items.Add("DNI: " + paciente.DNI);
                    lstBoxDatos.Items.Add("Genero: " + paciente.Genero);
                    lstBoxDatos.Items.Add("Enfermedad: " + paciente.Enfermedad);

                }
            }
        }
    }
}
