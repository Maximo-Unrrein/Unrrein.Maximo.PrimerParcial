using Biblioteca;

namespace WinFormsApp
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();


            // PRUEBA !!!!!!!!!!!!!!!!!!!!!!
            Paciente paciente = new Paciente("Blastois", "Casasola", 44222333, 'M', "Fractura");
            Usuario usuarioNuevo = new Usuario(paciente, "JOse", "Luis", DateTime.Now);

            Admin.ListaUsuarios.Add(usuarioNuevo);
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