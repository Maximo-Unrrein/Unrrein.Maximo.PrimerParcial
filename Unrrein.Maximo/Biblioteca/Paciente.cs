using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Paciente : Persona
    {

        //Atributos
        public enum Membresia { Oro, Plata, Bronce};
        protected Turno turno;
        protected string enfermedad;
        protected Membresia membresia;
        
        //Constructor
        public Paciente(string nombre, string apellido, int dni, string genero, Membresia membresia, Turno turno, string enfermedad) : base(nombre, apellido, dni, genero)
        {
            this.GETAndSETMembresia = membresia;
            this.Turno = turno;
            this.Enfermedad = enfermedad;
        }


        //Propiedades
        public Membresia GETAndSETMembresia { get => this.membresia; set => this.membresia = value; }
        public Turno Turno { get => this.turno; set => this.turno = value; }
        public string Enfermedad { get => this.enfermedad; set => this.enfermedad = value; }


        //MEtodos
        public override string Mostrar()
        {
            throw new NotImplementedException();
        }
    }
}
