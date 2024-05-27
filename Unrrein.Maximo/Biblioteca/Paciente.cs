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
        #region Atributos
        //Atributos
        protected Turno turno;
        protected string enfermedad;
        #endregion


        //Constructor
        [JsonConstructor]
        public Paciente(string nombre, string apellido, int dni, char genero, string enfermedad) : base(nombre, apellido, dni, genero)
        {
            this.Turno = null;
            this.Enfermedad = enfermedad;
        }

        public Paciente(string nombre, string apellido, int dni, char genero) : base(nombre, apellido, dni, genero)
        {
            this.Turno = null;
            this.Enfermedad = null;
        }

        //Propiedades
        public Turno Turno { get => this.turno; set => this.turno = value; }
        public string Enfermedad { get => this.enfermedad; set => this.enfermedad = value; }


        //Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if(this.Turno != null)
            {
                sb.AppendLine($"Nombre: {base.Nombre}");
                sb.AppendLine($"Apellido: {base.Apellido}");
                sb.AppendLine($"DNI: {base.DNI}");
                sb.AppendLine($"Genero: {base.Genero}");
                sb.AppendLine($"{this.Turno.Mostrar()}");
                sb.AppendLine($"Enfermedad:{this.Enfermedad}");
            }
            else
            {
                sb.AppendLine($"Nombre: {base.Nombre}");
                sb.AppendLine($"Apellido: {base.Apellido}");
                sb.AppendLine($"DNI: {base.DNI}");
                sb.AppendLine($"Genero: {base.Genero}");
                sb.AppendLine($"Enfermedad:{this.Enfermedad}");
            }


            return sb.ToString();
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
