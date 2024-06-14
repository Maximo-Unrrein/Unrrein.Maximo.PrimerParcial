using Biblioteca;
using Biblioteca.clases;

namespace WinFormsApp
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();


            Admin.RutaCompleta = Admin.RutaArchivoJSON();

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