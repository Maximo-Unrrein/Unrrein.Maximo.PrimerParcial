using Biblioteca.clases;
using Biblioteca;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Biblioteca.DAO;

namespace ConsoleTesteo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________
            /*
            /// USUARIOS

            Paciente paciente = new Paciente("Luis", "Juez", 29121234, 'F', "Peditis");
            Usuario usuario = new Usuario(paciente, "Luisito", "Luisito", DateTime.Now, "Luisito@gmail.com");

            Paciente paciente01 = new Paciente("Max", "Unrrein", 45226034, 'M', "Huevos revueltos");
            Usuario usuario01 = new Usuario(paciente01, "Max", "Max", DateTime.Now, "MaxUnrrein@gmail.com");


            Doctor doctor2 = new Doctor("Doctor", "Pinochet", 12345578, 'F', RangoHorario.Mañana, Especialidades.Cardiologia);
            Usuario usuario2 = new Usuario(doctor2, "Pinochet", "Pinochet", DateTime.Now, "Pinochet@hotmail.com");



            Doctor doctor3 = new Doctor("Doctor", "River", 12344478, 'F', RangoHorario.Tarde, Especialidades.Cardiologia);
            Usuario usuario3 = new Usuario(doctor3, "River", "River", DateTime.Now, "River@gmail.com");



            List<Usuario> listaDeUsuarios = new List<Usuario>();
            listaDeUsuarios.Add(usuario);
            listaDeUsuarios.Add(usuario01);
            listaDeUsuarios.Add(usuario2);
            listaDeUsuarios.Add(usuario3);


            
            
            
            
            //#######################################################################################################
            //#######################################################################################################
            //#######################################################################################################

            // Escapa las barras invertidas en el patrón de la expresión regular
            string[] parts = Regex.Split(AppDomain.CurrentDomain.BaseDirectory, @"\\");

            // Elimina los últimos 5 componentes
            parts = parts.Take(parts.Length - 5).ToArray();

            string reconstruccionRuta = string.Empty;
            foreach (string part in parts)
            {
                reconstruccionRuta += part + "\\";
            }
            reconstruccionRuta += "Biblioteca\\data.json";

            //Console.Write(reconstruccionRuta);  FUNCIONA

            //#######################################################################################################
            //#######################################################################################################
            //#######################################################################################################


            

            
            ManejadorJson.Serializacion(listaDeUsuarios, reconstruccionRuta);


            List<Usuario> listaUsuariosRetornada = ManejadorJson.Desealizacion(reconstruccionRuta, typeof(List<Usuario>)) as List<Usuario>;

            foreach (Usuario persona11 in listaUsuariosRetornada)
            {
                Console.WriteLine(persona11.ToString());
                Console.WriteLine("\n");
            }
            */
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________
            //______________________________________________________________________________________________________________________

            UsuarioDAO usuarioDao = new UsuarioDAO();

            List<Usuario> listaUsuarios = usuarioDao.ListarUsuarios();


            foreach(Usuario usuario in listaUsuarios)
            {
                Console.WriteLine(usuario.ToString());
                
                Console.WriteLine("\n");
                Console.WriteLine("___________________________________________________________________________________");
                Console.WriteLine("\n");
            }




        }
    }
}