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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp
{
    public partial class FrmDoctor : Form
    {
        //Doctor doctor = (Doctor)Admin.UsuarioGuardado.Persona;  ---------------------- CUALQUIERA

        public FrmDoctor()
        {
            InitializeComponent();



            cmBoxDia.DataSource = Admin.UsuarioGuardado.Doctor.ListaPacientes;
            cmBoxDia.DisplayMember = "DiaTurno";



            cmbBoxPacientes.Enabled = false;
            //cmbBoxPacientes.DataSource = Admin.UsuarioGuardado.Doctor.ListaPacientes;
            //cmbBoxPacientes.DisplayMember = "NombreCompleto";




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

            foreach (Paciente paciente in Admin.UsuarioGuardado.Doctor.ListaPacientes)
            {
                if (cmbBoxPacientes.Text == paciente.NombreCompleto)
                {

                    lstBoxDatos.Items.Add("Nombre: " + paciente.Nombre);
                    lstBoxDatos.Items.Add("Apellido: " + paciente.Apellido);
                    lstBoxDatos.Items.Add("Genero: " + paciente.Genero);
                    lstBoxDatos.Items.Add("");
                    lstBoxDatos.Items.Add("-----------[TURNO]-----------");
                    lstBoxDatos.Items.Add("Dia: " + paciente.Turno.Dia.ToString("dd/MM/yyyy"));
                    lstBoxDatos.Items.Add("Hora: " + paciente.Turno.Horario);

                }
            }
        }

        private void cmBoxDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxPacientes.Enabled = true;

            List<Paciente> listaPacienteFiltrado = new List<Paciente>();

            foreach(Paciente paciente in Admin.UsuarioGuardado.Doctor.ListaPacientes)
            {
                if(paciente.Turno.Dia.ToString("dd/MM/yyyy") == cmBoxDia.Text)
                {
                    listaPacienteFiltrado.Add(paciente);
                }
            }


            cmbBoxPacientes.DataSource = listaPacienteFiltrado;
            cmbBoxPacientes.DisplayMember = "NombreCompleto";
            cmbBoxPacientes.Text = "";

        }
    }
}
