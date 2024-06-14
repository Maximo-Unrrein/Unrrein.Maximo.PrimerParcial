using Biblioteca.clases;
using Biblioteca;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

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

            /// USUARIOS

            Paciente paciente = new Paciente("Pdr", "Puig", 29121234, 'F', "Peditis");
            Usuario usuario = new Usuario(paciente, "PDrr", "JDJDJ", DateTime.Now, "pdr@gmail.com");

            Doctor doctor2 = new Doctor("TTTT", "pedriot", 12345578, 'F', RangoHorario.Mañana, Especialidades.Cardiologia);
            Usuario usuario2 = new Usuario(doctor2, "TTttT", "fjfjjd", DateTime.Now, "TTT@hotmail.com");



            Doctor doctor3 = new Doctor("AAA", "pedriot", 12344478, 'F', RangoHorario.Mañana, Especialidades.Cardiologia);
            Usuario usuario3 = new Usuario(doctor3, "AaaaaA", "hhghh", DateTime.Now, "pedriot@gmail.com");



            List<Usuario> listaDeUsuarios = new List<Usuario>();
            listaDeUsuarios.Add(usuario);
            listaDeUsuarios.Add(usuario2);
            listaDeUsuarios.Add(usuario3);


            bool caca = doctor2 + paciente;
            
            
            
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














            //Admin.ListaUsuarios = listaUsuariosRetornada;
            //Console.WriteLine(Admin.BuscarPersona(usuarios));

        }
    }
}