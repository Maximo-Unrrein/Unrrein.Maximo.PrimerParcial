using Biblioteca;

namespace ConsoleTesteo
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Paciente paciente = new Paciente("Blastois", "Casasola", 44222333, 'M', "Fractura");
            Usuario usuarioNuevo = new Usuario(paciente, "JOse", "Luis", DateTime.Now);

            Admin.ListaUsuarios.Add(usuarioNuevo);
            //SerializadorJson.Serializacion(Admin.ListaUsuarios, "ListaUsuarios.json");

            ////////////////////////////////////////////////////////


            
            
            foreach(Usuario usuario in Admin.ListaUsuarios)
            {
                Console.WriteLine(Admin.BuscarPersona(usuario));
                Console.WriteLine(usuario.ToString());
            }

        }
    }
}