using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Biblioteca.clases;
using Biblioteca.excepciones;

namespace Biblioteca
{
    public sealed class Paciente : Persona
    {
        #region Atributos
        
        protected Turno turno;
        #endregion


        //Constructor
        public Paciente() : base() { }


        public Paciente(string nombre, string apellido, int dni, char genero, string enfermedad) : this(nombre, apellido, dni, genero)
        {
            this.Turno = null;
            //this.Enfermedad = enfermedad;
        }

        public Paciente(string nombre, string apellido, int dni, char genero) : base(nombre, apellido, dni, genero)
        {
            this.Turno = null;
            //this.Enfermedad = null;
        }

        //Propiedades
        public Turno Turno { get => this.turno; set => this.turno = value; }
        public string NombreCompleto { get => $"{this.Nombre} {this.Apellido}"; }
        public string? DiaTurno { get => this.Turno != null ? $"{this.Turno.Dia.ToString("dd/MM/yyyy")}" : null; }



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
                sb.AppendLine($"{this.Turno.ToString()}");
                //sb.AppendLine($"Enfermedad:{this.Enfermedad}");
            }
            else
            {
                sb.AppendLine($"Nombre: {base.Nombre}");
                sb.AppendLine($"Apellido: {base.Apellido}");
                sb.AppendLine($"DNI: {base.DNI}");
                sb.AppendLine($"Genero: {base.Genero}");
                //sb.AppendLine($"Enfermedad:{this.Enfermedad}");
            }


            return sb.ToString();
        }
        public override bool Equals(Persona p)
        {
            
            // Usa el método GetType() para comparar los tipos de las dos instancias
            return this.GetType() == p.GetType();
        }
                
    }
}
