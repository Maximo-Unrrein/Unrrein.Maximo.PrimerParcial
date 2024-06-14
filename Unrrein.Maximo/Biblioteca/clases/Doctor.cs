using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.clases;

namespace Biblioteca
{
    public sealed class Doctor : Persona
    {
        //Atributos
        private List<Paciente> listaPacientes;
        private RangoHorario horariosAtencion;
        private Especialidades especialidad;

        public Doctor() : base("A", "s", 12345678, 'G') { }

        //Constructor
        public Doctor(string nombre, string apellido, int dni, char genero, RangoHorario horarioAtencion, Especialidades especialidad) : base(nombre, apellido, dni, genero)
        {
            this.especialidad = especialidad;

            this.listaPacientes = new List<Paciente> { };
            this.horariosAtencion = horarioAtencion;
        }
        public Doctor(string nombre, string apellido, int dni, char genero, List<Paciente> listaPacientes, RangoHorario horarioAtencion, Especialidades especialidad) : base(nombre, apellido, dni, genero)
        {
            this.listaPacientes = listaPacientes;
            this.horariosAtencion = horarioAtencion;
            this.especialidad = especialidad;
        }


        //Propiedades
        public List<Paciente> ListaPacientes { get => this.listaPacientes; set => this.listaPacientes = value; }
        public RangoHorario HorariosAtencion{ get => this.horariosAtencion; set => this.horariosAtencion = value; }
        public Especialidades Especialidad { get => this.especialidad; set => this.especialidad = value; }


        //Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {base.Nombre}");
            sb.AppendLine($"Apellido: {base.Apellido}");
            sb.AppendLine($"DNI: {base.DNI}");
            sb.AppendLine($"Genero: {base.Genero}");
            sb.AppendLine($"Especialidad: {this.Especialidad}");
            
            sb.AppendLine($"Lista de pacientes:");
            foreach(Paciente p in this.listaPacientes)
            {
                sb.AppendLine(p.Nombre + " " + p.Apellido);
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


        public static bool operator ==(Doctor doctor, Paciente paciente)
        {
            foreach(Persona persona in doctor.ListaPacientes)
            {
                if (persona == paciente) 
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Doctor doctor, Paciente paciente)
        {
            return !(doctor == paciente);
        }

        public static bool operator +(Doctor doctor, Paciente paciente)
        {
            if(doctor != paciente)
            {
                doctor.listaPacientes.Add(paciente);
                return true;
            }
            return false;
        }
        public static bool operator -(Doctor doctor, Paciente paciente)
        {
            if (doctor == paciente)
            {
                doctor.listaPacientes.Remove(paciente);
                return false;
            }
            return true;
        }
    }
}
