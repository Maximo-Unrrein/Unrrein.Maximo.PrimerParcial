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
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();


            // Obtener los valores del enumerado y asignarlos al ComboBox
            cmbBoxEspecialidad.DataSource = Enum.GetValues(typeof(Especialidades));

            

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        private void cmbBoxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la especialidad seleccionada
            Especialidades especialidadSeleccionada = (Especialidades)cmbBoxEspecialidad.SelectedItem;


            //Se puede optimizar
            List<string> horariosMañana = new List<string> { "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00" };
            List<string> horariosTarde = new List<string> { "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00" };
            List<string> horariosNoche = new List<string> { "20:00", "21:00", "22:00", "23:00", "24:00", "1:00", "2:00" };
            List<Doctor> doctoresFiltrados = new List<Doctor>();



            // Filtrar los doctores por la especialidad seleccionada
            foreach (Usuario usuario in Admin.ListaUsuarios)
            {
                if (usuario.Persona is Doctor)
                {
                    Doctor doctor = (Doctor)usuario.Persona;
                    if (doctor.Especialidad == especialidadSeleccionada)
                    {
                        doctoresFiltrados.Add(doctor);

                        //Actualizacion ComboBox de horarios
                        if (doctor.HorariosAtencion == RangoHorario.Mañana)
                        {
                            cmbBoxHora.DataSource = horariosMañana;
                        }
                        else if (doctor.HorariosAtencion == RangoHorario.Tarde)
                        {
                            cmbBoxHora.DataSource = horariosTarde;
                        }
                        else if (doctor.HorariosAtencion == RangoHorario.Noche)
                        {
                            cmbBoxHora.DataSource = horariosNoche;

                        }
                    }

                }
            }



            // Actualizar el ComboBox de doctores
            cmbBoxDoctor.DataSource = doctoresFiltrados;
            cmbBoxDoctor.DisplayMember = "Nombre";
        }

        private void btnConfirmarTurno_Click(object sender, EventArgs e)
        {
            // Limpiar el ListBox antes de mostrar los datos
            lstBoxDatosDelTurno.Items.Clear();

            if (cmbBoxEspecialidad.SelectedIndex == -1 || cmbBoxDoctor.SelectedIndex == -1)
            {
                MessageBox.Show("Campos incompletos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Establecer la fecha mínima al día de hoy para evitar seleccionar fechas pasadas
                monthCalendar1.MinDate = DateTime.Today;


                foreach (Usuario usuario in Admin.ListaUsuarios) 
                {
                    if(usuario.Persona is Doctor && usuario.Persona.Nombre == cmbBoxDoctor.Text)
                    {
                        Doctor doctor = (Doctor)usuario.Persona;
                        Turno turno = new Turno(doctor, monthCalendar1.SelectionRange.Start, cmbBoxHora.Text); //Creacion Turno



                        Paciente paciente = (Paciente)Admin.UsuarioGuardado.Persona;
                        paciente.Turno = turno;

                        doctor.ListaPacientes.Add(paciente);




                        lstBoxDatosDelTurno.Items.Add("Nombre completo: " + paciente.Nombre + " "+ paciente.Apellido);
                        lstBoxDatosDelTurno.Items.Add("Doctor: " + doctor.Nombre + " " + doctor.Apellido);
                        lstBoxDatosDelTurno.Items.Add("Tipo turno: " + doctor.Especialidad);
                        lstBoxDatosDelTurno.Items.Add("Genero paciente: " + paciente.Genero);
                        lstBoxDatosDelTurno.Items.Add("Dia: " + paciente.Turno.Dia.ToString("dd/MM/yyyy"));
                        lstBoxDatosDelTurno.Items.Add("Hora: " + paciente.Turno.Horario);
                    }
                }




            }
        }
    }
}
