using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Doctor : Persona
    {
        //Atributos
        private List<Paciente> listaPacientes;
        private int[] horariosAtencion;
        private List<int> dias;
        private string turno;
        private string especialidad;

        //Constructor
        public Doctor(string nombre, string apellido, int dni, char genero, List<Paciente> listaPacientes, int[] horarioAtencion, List<int> dias, string turno, string especialidad) : base(nombre, apellido, dni, genero)
        {
            this.listaPacientes = listaPacientes;
            this.turno = turno;
            this.horariosAtencion = horarioAtencion;
            this.dias = dias;
            this.especialidad = especialidad;
        }


        //Propiedades
        public List<Paciente> ListaPacientes { get => this.listaPacientes; set => this.listaPacientes = value; }
        public int[] HorariosAtencion{ get => this.horariosAtencion; set => this.horariosAtencion = value; }
        public List<int> Dias{ get => this.dias; set => this.dias = value; }
        public string Turno { get => this.turno; set => this.turno = value; }
        public string Especialidad { get => this.especialidad; set => this.especialidad = value; }


        //Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {base.Nombre}");
            sb.AppendLine($"Apellido: {base.Apellido}");
            sb.AppendLine($"DNI: {base.DNI}");
            sb.AppendLine($"Genero: {base.Genero}");
            sb.AppendLine($"Especialidad: {this.Especialidad}");
            sb.AppendLine($"Turno: {this.Turno}");
            sb.AppendLine($"Horarios de Atención: {this.Turno}");
            sb.AppendLine($"Lista de pacientes:\n{this.ListaPacientes}");

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
