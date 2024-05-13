using Biblioteca;

namespace ConsoleTesteo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            Paciente paciente = new Paciente("JOSE", "BOlsonaro", 45221230, "F", Paciente.Membresia.Plata, new Turno(), "Fractura");
            Console.Write(paciente.Nombre);
        }
    }
}