using System.Text.RegularExpressions;

namespace Biblioteca
{
    public abstract class Persona
    {

        //Atributos
        private string nombre;
        private string apellido;
        private int dni;
        private char genero;

        public Persona(string nombre, string apellido, int dni, char genero) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Genero = genero;

        }


        //Propiedades
        public string Nombre 
        {
            get => this.nombre;
            set 
            {
                this.nombre = value;
                
            } 
        }
        public string Apellido
        {
            get => this.apellido;
            set
            {
                this.apellido = value;

            }
        }
        public int DNI
        {
            get => this.dni;
            set
            {
                this.dni = value;

            }
        }
        public char Genero
        {
            get => this.genero;
            set
            {
                this.genero = value;

            }
        }


        //Metodos
        public abstract string Mostrar();
        public abstract string ToString();
        public abstract bool Equals(Persona p);
       
        public static bool operator ==(Persona p1, Persona p2)
        {
            if(p1.DNI == p2.DNI && p1.GetHashCode() != p2.GetHashCode()) //NOSE SI VA EL GETHASHCODE o PONER OTRA PROPIEDADE
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }






    }
}