using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Paciente : Persona
    {

        //Atributos
        //public enum Membresia { Oro, Plata, Bronce};
        protected Turno turno;
        protected string enfermedad;
        //protected Membresia membresia;

        //Constructor
        [JsonConstructor]
        public Paciente(string nombre, string apellido, int dni, char genero, string enfermedad) : base(nombre, apellido, dni, genero)
        {
            this.Turno = null;
            this.Enfermedad = enfermedad;
        }



        //Propiedades
       // public Membresia GETAndSETMembresia { get => this.membresia; set => this.membresia = value; }
        public Turno Turno { get => this.turno; set => this.turno = value; }
        public string Enfermedad { get => this.enfermedad; set => this.enfermedad = value; }


        //MEtodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {base.Nombre}");
            sb.AppendLine($"Apellido: {base.Apellido}");
            sb.AppendLine($"DNI: {base.DNI}");
            sb.AppendLine($"Genero: {base.Genero}");
            //sb.AppendLine($"Membresia: {this.GETAndSETMembresia}");
            sb.AppendLine($"{this.Turno.Mostrar()}");
            sb.AppendLine($"Enfermedad:{this.Enfermedad}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar(); //VER NO OPTIMIZADO
        }
        public override bool Equals(Persona p)
        {
            // Si el objeto pasado es null, retorna false
            if (p == null)
            {
                return false;
            }

            // Usa el método GetType() para comparar los tipos de las dos instancias
            return this.GetType() == p.GetType();
        }
    }
}
