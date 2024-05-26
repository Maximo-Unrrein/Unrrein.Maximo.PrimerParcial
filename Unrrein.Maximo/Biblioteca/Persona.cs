using Biblioteca.excepciones;
using System.Text.Json.Serialization;
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


        // Agregar constructor sin parámetros /ERROR PARA DESERIALIZAR
        public Persona()
        {
        }

        [JsonConstructor]
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
                if(Validaciones.NombreYApellido(value))
                {
                    this.nombre = value;
                }
                else
                {
                    throw new NombreInvalidoException("Nombre Invalido");
                }
            } 
        }
        public string Apellido
        {
            get => this.apellido;
            set
            {
                if (Validaciones.NombreYApellido(value))
                {
                    this.apellido = value;
                }
                else
                {
                    throw new ApellidoInvalidoException("Apellido Invalido");
                }
            }
        }
        public int DNI
        {
            get => this.dni;
            set
            {
                if (Validaciones.DNI($"{value}"))
                {
                    this.dni = value;
                }
                else
                {
                    throw new DniInvalidoException("Dni Invalido");
                }

            }
        }
        public char Genero
        {
            get => this.genero;
            set
            {
                if(value != null)
                {
                    this.genero = value;
                }
            }
        }


        //Metodos
        public abstract string ToString();
        public abstract bool Equals(Persona p);
       

        // Dentro de los metodos -> sobrecarga de operadores
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