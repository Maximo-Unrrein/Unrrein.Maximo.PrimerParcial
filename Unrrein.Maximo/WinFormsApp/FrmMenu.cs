using Biblioteca;

namespace WinFormsApp
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();






            Doctor doctor = new Doctor("Dexter", "Doctor", 12345678, 'M', RangoHorario.Noche, Especialidades.Psicologia);
            Usuario usuarioDoctor = new Usuario(doctor, "Dexter", "Luis", DateTime.Now);


            // PRUEBA !!!!!!!!!!!!!!!!!!!!!!
            Paciente paciente = new Paciente("Blastois", "Casasola", 44222333, 'M', "Fractura");
            Usuario usuarioPaciente = new Usuario(paciente, "JOse", "Luis", DateTime.Now);

            Admin.ListaUsuarios.Add(usuarioPaciente);
            Admin.ListaUsuarios.Add(usuarioDoctor);






            // HARDCODEADO LISTA PACIENTES DE DOCTOR DEXTER
            Paciente paciente00 = new Paciente("Blastois", "Casasola", 44222333, 'M', "Fractura");
            Paciente paciente01 = new Paciente("Pedrito", "Casasola", 44222333, 'M', "Fractura");
            Paciente paciente02 = new Paciente("Messi", "Casasola", 44222333, 'M', "Fractura");
            Paciente paciente03 = new Paciente("Ronaldo", "Casasola", 44222333, 'M', "Fractura");
            Paciente paciente04 = new Paciente("Parmo", "Casasola", 44222333, 'M', "Fractura");
            Paciente paciente05 = new Paciente("Holanda", "Casasola", 44222333, 'M', "Fractura");

            List<Paciente> listaDePacientesDexter = new List<Paciente> {paciente00, paciente01, paciente02, paciente03, paciente04, paciente05};
            doctor.ListaPacientes = listaDePacientesDexter;


            // HARDCODEADO DOCTORES; PRUEBA ESPECIALIDADES
            Doctor doctor00 = new Doctor("PEPITO EL PEDIATRA", "Doctor", 12345678, 'M', RangoHorario.Tarde, Especialidades.Pediatra);
            Usuario usuarioDoctor00 = new Usuario(doctor00, "DDD", "Luis", DateTime.Now);
            
            Doctor doctor01 = new Doctor("Martin", "Doctor", 12345678, 'M', RangoHorario.Mañana, Especialidades.Cardiologia);
            Usuario usuarioDoctor01 = new Usuario(doctor01, "GGG", "Luis", DateTime.Now);

            Doctor doctor02 = new Doctor("Neumatico", "Doctor", 12345678, 'M', RangoHorario.Tarde, Especialidades.Neumologia);
            Usuario usuarioDoctor02 = new Usuario(doctor02, "RRR", "Luis", DateTime.Now);

            Doctor doctor03 = new Doctor("Enfermerito", "Doctor", 12345678, 'M', RangoHorario.Noche, Especialidades.Enfermeria);
            Usuario usuarioDoctor03 = new Usuario(doctor03, "YYY", "Luis", DateTime.Now);



            Admin.ListaUsuarios.Add(usuarioDoctor00);
            Admin.ListaUsuarios.Add(usuarioDoctor01);
            Admin.ListaUsuarios.Add(usuarioDoctor02);
            Admin.ListaUsuarios.Add(usuarioDoctor03);

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCreation frmCreation = new FrmCreation();
            frmCreation.ShowDialog();
        }
    }
}