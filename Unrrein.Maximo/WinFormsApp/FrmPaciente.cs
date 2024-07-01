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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmPaciente : Form
    {

        private Task relojTask;
        private CancellationTokenSource cancellationTokenSource;

        #region FrmPaciente
        public FrmPaciente()
        {
            InitializeComponent();
            cancellationTokenSource = new CancellationTokenSource();
            relojTask = Task.Run(() => this.IniciarReloj(cancellationTokenSource.Token));
            //Task.Run(this.IniciarReloj);
            
            


            // Obtener los valores del enumerado y asignarlos al ComboBox
            cmbBoxEspecialidad.DataSource = Enum.GetValues(typeof(Especialidades));

            // Establecer la fecha mínima al día de hoy para evitar seleccionar fechas pasadas
            monthCalendar1.MinDate = DateTime.Today;


            //Boton "cancelar" lo escondemos y lo inhabilitamos
            btnCancelar.Visible = false;
            btnCancelar.Enabled = false;


            //Admin.UsuarioGuardado.Paciente.Turno
            if (Session.UsuarioActual.Paciente.Turno != null)
            {
                cmbBoxEspecialidad.Enabled = false;
                cmbBoxDoctor.Enabled = false;
                cmbBoxHora.Enabled = false;
                monthCalendar1.Enabled = false;
                btnConfirmarTurno.Enabled = false;

                btnCancelar.Enabled = true;
                btnCancelar.Visible = true;


                //Deserealizo la lista
                UsuarioDAO usuarioDao = new UsuarioDAO();
                List<Usuario> listaUsuariosRetornada = usuarioDao.ListarUsuarios();



                foreach (Usuario usuario in listaUsuariosRetornada)
                {
                    if (usuario.Doctor is not null)
                    {
                        foreach (Paciente paciente in usuario.Doctor.ListaPacientes)
                        {
                            if (paciente.Nombre == Session.UsuarioActual.Paciente.Nombre)
                            {
                                lblDatosTurno.Text = $"Doctor: {usuario.Doctor.NombreCompleto}\nFecha: {Session.UsuarioActual.Paciente.Turno.Dia.ToString("dd/MM/yyyy")} \nHorario: {Session.UsuarioActual.Paciente.Turno.Horario}";
                            }
                        }
                    }
                }

            }
            else
            {
                cmbBoxEspecialidad.Enabled = true;
                cmbBoxDoctor.Enabled = true;
                cmbBoxHora.Enabled = true;
                btnConfirmarTurno.Enabled = true;

                btnCancelar.Enabled = false;
                btnCancelar.Visible = false;


                lblDatosTurno.Text = "";
            }

        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();

            this.Hide();
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        #region cmbBoxEspecialidad_SelectedIndexChanged
        private void cmbBoxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Obtener la especialidad seleccionada
            Especialidades especialidadSeleccionada = (Especialidades)cmbBoxEspecialidad.SelectedItem;


            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> listaUsuariosRetornada = usuarioDAO.ListarUsuarios();
            //List<Usuario> listaUsuariosRetornada = ManejadorJson.Desealizacion(Admin.RutaCompleta, typeof(List<Usuario>)) as List<Usuario>;
            List<Doctor> listaDoctoresFiltrados = new List<Doctor>();

            //Creacion de lista con todos los doctores de la especialidad seleccionada
            foreach (Usuario usuario in listaUsuariosRetornada)
            {
                if (usuario.Doctor is not null && usuario.Doctor.Especialidad == especialidadSeleccionada && usuario.Doctor.HorariosDisponibles.Count > 0)
                {
                    listaDoctoresFiltrados.Add(usuario.Doctor);
                }
            }

            //actualizacion comboBOx de doctores y Horarios
            cmbBoxDoctor.DataSource = listaDoctoresFiltrados;
            cmbBoxDoctor.DisplayMember = "NombreCompleto";

            if (cmbBoxDoctor.SelectedIndex != -1)
            {



                //Reseteo los horarios
                Doctor doctorSeleccionado = (Doctor)cmbBoxDoctor.SelectedItem;
                doctorSeleccionado.SeteoHorariosDisponibles(doctorSeleccionado.HorariosAtencion);

                //Eliminamos los horarios de los pacientes
                foreach (Paciente paciente in doctorSeleccionado.ListaPacientes)
                {
                    if (paciente.Turno.Dia == monthCalendar1.SelectionRange.Start)
                    {
                        string formateado = paciente.Turno.Horario.Substring(0, 5);

                        doctorSeleccionado.HorariosDisponibles.Remove(formateado);
                    }
                }

                cmbBoxDoctor.Enabled = true;
                cmbBoxHora.Enabled = true;
                monthCalendar1.Enabled = true;

                cmbBoxHora.DataSource = doctorSeleccionado.HorariosDisponibles;

                //actualizacion Hora doctor
                //cmbBoxHora.DataSource = doctorSeleccionado.HorariosDisponibles;



            }
            else
            {
                cmbBoxDoctor.ResetText();
                cmbBoxHora.ResetText();

                cmbBoxDoctor.Enabled = false;
                cmbBoxHora.Enabled = false;
                monthCalendar1.Enabled = false;
            }




        }
        #endregion


        private void cmbBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctor doctorSeleccionado = (Doctor)cmbBoxDoctor.SelectedItem;
            //cmbBoxHora.DataSource = doctorSeleccionado.HorariosDisponibles;



            //List<Usuario> listaUsuariosRetornada = ManejadorJson.Desealizacion(Admin.RutaCompleta, typeof(List<Usuario>)) as List<Usuario>;
            UsuarioDAO usuarioDao = new UsuarioDAO();
            List<Usuario> listaUsuariosRetornada = usuarioDao.ListarUsuarios();


            foreach (Usuario usuario in listaUsuariosRetornada)
            {
                if (usuario.Doctor is not null && usuario.Doctor.NombreCompleto == cmbBoxDoctor.Text)
                {

                    //Reseteo los horarios
                    usuario.Doctor.SeteoHorariosDisponibles(usuario.Doctor.HorariosAtencion);

                    //Eliminamos los horarios de los pacientes
                    foreach (Paciente paciente in usuario.Doctor.ListaPacientes)
                    {
                        if (paciente.Turno.Dia == monthCalendar1.SelectionRange.Start)
                        {
                            string formateado = paciente.Turno.Horario.Substring(0, 5);
                            usuario.Doctor.HorariosDisponibles.Remove(formateado);
                        }
                    }

                    cmbBoxHora.DataSource = usuario.Doctor.HorariosDisponibles;
                }
            }
        }

        #region btnConfirmarTurno_Click
        private void btnConfirmarTurno_Click(object sender, EventArgs e)
        {
            // Limpiar el ListBox antes de mostrar los datos
            //lstBoxDatosDelTurno.Items.Clear();

            if (cmbBoxDoctor.SelectedIndex == -1 || cmbBoxHora.SelectedIndex == -1)
            {
                MessageBox.Show("Campos incompletos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Deserializacion
                //List<Usuario> listaUsuariosRetornada = ManejadorJson.Desealizacion(Admin.RutaCompleta, typeof(List<Usuario>)) as List<Usuario>;
                UsuarioDAO usuarioDao = new UsuarioDAO();
                List<Usuario> listaUsuariosRetornada = usuarioDao.ListarUsuarios();

                // Creamos turno
                Doctor doctorSeleccionado = (Doctor)cmbBoxDoctor.SelectedItem;
                Turno turno = new Turno(monthCalendar1.SelectionRange.Start, cmbBoxHora.Text);


                int idDoctor = usuarioDao.ObtenerIdUsuarioPorDNI(doctorSeleccionado.DNI);
                int idPaciente = usuarioDao.ObtenerIdUsuarioPorDNI(Session.UsuarioActual.Paciente.DNI);

                usuarioDao.AsignarTurno(idDoctor, idPaciente, turno.Dia, turno.Horario);




                ////Bandera
                //bool flagTurnoAsignado = false;
                //Usuario usuarioAux = new Usuario();


                //foreach (Usuario usuario in listaUsuariosRetornada)
                //{
                //    //Buscamos paciente y le asignamos turno
                //    if (Session.UsuarioActual == usuario)
                //    {
                //        usuario.Paciente.Turno = turno;

                //        usuarioAux = new Usuario(usuario.Paciente, usuario.NombreUsuario, usuario.ContraseñaUsuario, usuario.Mail);

                //        flagTurnoAsignado = true;


                //        Admin.UsuarioGuardado = usuario;
                //    }
                //}


                //if (flagTurnoAsignado)
                //{
                //    foreach (Usuario usuario in listaUsuariosRetornada)
                //    {
                //        //Buscamos doctor seleccionado 
                //        if (usuario.Doctor is not null && cmbBoxDoctor.Text == usuario.Doctor.NombreCompleto)
                //        {
                //            //usuario.Doctor.HorariosDisponibles.Remove(cmbBoxHora.Text);

                //            //Agregar el paciente con turno en la lista del Doctor
                //            usuario.Doctor.ListaPacientes.Add(usuarioAux.Paciente);

                //        }
                //    }
                //}



                lblDatosTurno.Text = $"Doctor: {cmbBoxDoctor.Text}\nFecha: {monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy")} \nHorario: {cmbBoxHora.Text}";


                //ManejadorJson.Serializacion(listaUsuariosRetornada, Admin.RutaCompleta);




                //Los inhabilitamos para que no puedan sacar nuevamente otro turno
                cmbBoxEspecialidad.Enabled = false;
                cmbBoxDoctor.Enabled = false;
                cmbBoxHora.Enabled = false;
                btnConfirmarTurno.Enabled = false;

                //Mostramos el boton cancelar 
                btnCancelar.Enabled = true;
                btnCancelar.Visible = true;

            }
        }




        #endregion

        #region btnCancelar_Click
        private void btnCancelar_Click(object sender, EventArgs e)
        {


            // HACER --> 1)Desealizar lista     2)Buscar Paciente y cambiar turno a 'null'      3)Serializar nuevamente
            //List<Usuario> listaUsuariosRetornada = ManejadorJson.Desealizacion(Admin.RutaCompleta, typeof(List<Usuario>)) as List<Usuario>;

            UsuarioDAO usuarioDao = new UsuarioDAO();
            int idPaciente = usuarioDao.ObtenerIdUsuarioPorDNI(Session.UsuarioActual.Paciente.DNI);

            usuarioDao.CancelarTurno(idPaciente);


            //bool flagPacienteEliminado = false;
            //foreach (Usuario usuario in listaUsuariosRetornada)
            //{

            //    if(usuario.Doctor is not null)
            //    {

            //        //Colection was modified
            //        List<Paciente> listaPacientesAux = usuario.Doctor.ListaPacientes.ToList();

            //        foreach (Paciente paciente in listaPacientesAux)
            //        {
            //            if(paciente == Admin.UsuarioGuardado.Paciente)
            //            {
            //                usuario.Doctor.ListaPacientes.Remove(paciente);
            //                flagPacienteEliminado = true;
            //            }
            //        }




            //    }

            //}



            //foreach (Usuario usuario in listaUsuariosRetornada)
            //{
            //    if (flagPacienteEliminado && usuario.Paciente is not null && usuario.Paciente == Admin.UsuarioGuardado.Paciente)
            //    {
            //        usuario.Paciente.Turno = null;
            //    }
            //}

            //Habilitamos la seleccion de campos nuevamente
            cmbBoxEspecialidad.Enabled = true;
            cmbBoxDoctor.Enabled = true;
            cmbBoxHora.Enabled = true;

            btnConfirmarTurno.Enabled = true;

            //Reseteamos el los datos del turno y ademas escondemos boton de cancelar
            lblDatosTurno.Text = "";
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;


            //ManejadorJson.Serializacion(listaUsuariosRetornada, Admin.RutaCompleta);


        }
        #endregion

        #region monthCalendar1_DateSelected
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            UsuarioDAO usuarioDao = new UsuarioDAO();
            List<Usuario> listaUsuariosRetornada = usuarioDao.ListarUsuarios();
            //List<Usuario> listaUsuariosRetornada = ManejadorJson.Desealizacion(Admin.RutaCompleta, typeof(List<Usuario>)) as List<Usuario>;


            foreach (Usuario usuario in listaUsuariosRetornada)
            {
                if (usuario.Doctor is not null && usuario.Doctor.NombreCompleto == cmbBoxDoctor.Text)
                {

                    //Reseteo los horarios
                    usuario.Doctor.SeteoHorariosDisponibles(usuario.Doctor.HorariosAtencion);

                    //Eliminamos los horarios de los pacientes
                    foreach (Paciente paciente in usuario.Doctor.ListaPacientes)
                    {
                        if (paciente.Turno.Dia == monthCalendar1.SelectionRange.Start)
                        {
                            //usuario.Doctor.HorariosDisponibles.Remove(paciente.Turno.Horario);
                            string formateado = paciente.Turno.Horario.Substring(0, 5);
                            usuario.Doctor.HorariosDisponibles.Remove(formateado);
                        }
                    }

                    cmbBoxHora.DataSource = usuario.Doctor.HorariosDisponibles;
                }
            }
        }
        #endregion

        


        //Manejo reloj
        private void IniciarReloj(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                this.ActualizarLabelReloj();
                Thread.Sleep(1000);
            }
        }

        private void ActualizarLabelReloj()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(this.ActualizarLabelReloj);
            }
            else
            {
                this.lblHoraActual.Text = $"Hora: {DateTime.Now.ToString("HH:mm:ss")}";

            }
        }

    }
}
