using System.Text.RegularExpressions;

namespace Biblioteca
{
    public abstract class Persona
    {

        public Persona(string nombre, string apellido, int dni, string genero) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Genero = genero;

        }


        //Atributos
        public string Nombre 
        {
            get => this.Nombre;
            set 
            {
                if (this.ValidacionNombreApellido(value))
                {
                    this.Nombre = value;
                }
                else
                {
                    throw new ArgumentException("Nombre no valido");
                }
            } 
        }
        public abstract string Apellido { get; set; }
        public abstract int DNI { get; set; }
        public abstract string Genero { get; set;}


        //Metodos
        public abstract string Mostrar();
        private bool ValidacionNombreApellido(string valor)
        {
            if (!string.IsNullOrEmpty(valor) && !(Regex.IsMatch(valor, @"\d")))
            {
                return true;
            }
            return false;
        }


    }
}