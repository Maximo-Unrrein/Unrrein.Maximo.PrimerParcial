using Biblioteca;

namespace ConsoleTesteo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un nuevo paciente
            Paciente paciente = new Paciente("JOSE", "BOlsonaro", 45221230, 'F', new Turno(Turno.RangoHorario.Mañana, DateTime.Now, new DateTime()), "Fractura");

            // Limpiar el archivo
            SerializadorJson.ClearFile("Usuarios.json");

            // Serializar el objeto paciente y escribirlo en el archivo
            SerializadorJson.Serialize(paciente, "Usuarios.json");
            SerializadorJson.Serialize(paciente, "Usuarios.json");
            
            // Deserializar el objeto desde el archivo y mostrarlo
            Paciente pacienteJson = (Paciente)SerializadorJson.Deserialize("Usuarios.json", typeof(Paciente));
            Console.WriteLine("\nDatos del paciente deserializado:");
            Console.WriteLine(pacienteJson.Mostrar());


        }
    }
}