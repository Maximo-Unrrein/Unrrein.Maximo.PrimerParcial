using Biblioteca.excepciones;
using Biblioteca.interfaces;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Biblioteca.clases
{
    public abstract class Persona : IPersona
    {

        //Atributos
        private string nombre;
        private string apellido;
        private int dni;
        private char genero;


        // Agregar constructor sin parámetros /ERROR PARA DESERIALIZAR


        public Persona() { }
        public Persona(string nombre, string apellido, int dni, char genero)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Genero = genero;

        }


        //Propiedades
        public string Nombre
        {
            get => nombre;
            set
            {
                if (Validaciones.NombreYApellido(value))
                {
                    nombre = value;
                }
                else
                {
                    throw new NombreInvalidoException("Nombre Invalido");
                }
            }
        }
        public string Apellido
        {
            get => apellido;
            set
            {
                if (Validaciones.NombreYApellido(value))
                {
                    apellido = value;
                }
                else
                {
                    throw new ApellidoInvalidoException("Apellido Invalido");
                }
            }
        }
        public int DNI
        {
            get => dni;
            set
            {
                if (Validaciones.DNI($"{value}"))
                {
                    dni = value;
                }
                else
                {
                    throw new DniInvalidoException("Dni Invalido");
                }

            }
        }
        public char Genero
        {
            get => genero;
            set
            {
                if (value != null)
                {
                    genero = value;
                }
            }
        }


        //Metodos
        public abstract override string ToString();
        public virtual bool Equals(Persona p)
        {
            if(this.GetHashCode() == p.GetHashCode())
            {
                return true;
            } 
            return false;
        }


        // Dentro de los metodos -> sobrecarga de operadores
        public static bool operator ==(Persona p1, Persona p2)
        {
            if (p1.DNI == p2.DNI && p1.Equals(p2) && p1.Nombre == p2.Nombre) 
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