using System.Text.RegularExpressions;

namespace Biblioteca
{
    public abstract class Persona
    {

        private string nombre;
        private string apellido;
        private int dni;
        private string genero;

        protected Persona(string nombre, string apellido, int dni, string genero) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Genero = genero;

        }


        //Atributos
        public string Nombre 
        {
            get => this.nombre;
            set 
            {
                this.nombre = value;
                
            } 
        }

        //Propiedades
        public  string Apellido { get => this.apellido; set => this.apellido = value; }
        public  int DNI { get => this.dni; set => this.dni = value; }
        public  string Genero { get => this.genero; set => this.genero = value; }


        //Metodos
        public abstract string Mostrar();

        /*
        private bool ValidacionNombreApellido(string valor)
        {
            if (!string.IsNullOrEmpty(valor) && Regex.IsMatch(valor, @"\d"))
            {
                return true;
            }
            return false;
        }*/


    }
}