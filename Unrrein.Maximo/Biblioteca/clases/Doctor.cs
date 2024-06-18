using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private List<string> horariosDisponibles;

        public Doctor() : base("A", "s", 12345678, 'G') { }

        //Constructor
        public Doctor(string nombre, string apellido, int dni, char genero, RangoHorario horarioAtencion, Especialidades especialidad) : base(nombre, apellido, dni, genero)
        {
            this.Especialidad = especialidad;

            this.ListaPacientes = new List<Paciente> { };
            this.HorariosAtencion = horarioAtencion;
            this.HorariosDisponibles = SeteoHorariosDisponibles(this.HorariosAtencion);
        }
        public Doctor(string nombre, string apellido, int dni, char genero, List<Paciente> listaPacientes, RangoHorario horarioAtencion, Especialidades especialidad) : base(nombre, apellido, dni, genero)
        {
            this.ListaPacientes = listaPacientes;
            this.HorariosAtencion = horarioAtencion;
            this.Especialidad = especialidad;
            this.HorariosDisponibles = SeteoHorariosDisponibles(this.HorariosAtencion);
        }


        //Propiedades
        public List<Paciente> ListaPacientes { get => this.listaPacientes; set => this.listaPacientes = value; }
        public RangoHorario HorariosAtencion{ get => this.horariosAtencion; set => this.horariosAtencion = value; }
        public Especialidades Especialidad { get => this.especialidad; set => this.especialidad = value; }
        public List<string> HorariosDisponibles { get => this.horariosDisponibles; set => this.horariosDisponibles = value; }

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


        public string NombreCompleto { get => $"{this.Nombre} {this.Apellido}"; }


        public List<string> SeteoHorariosDisponibles(RangoHorario horario)
        {
            List<string> result = new List<string>();

            switch (horario)
            {
                case RangoHorario.Mañana:
                    result.AddRange(new List<string> { "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00" });
                    break;
                case RangoHorario.Tarde:
                    result.AddRange(new List<string> { "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00" });
                    break;
                case RangoHorario.Noche:
                    result.AddRange(new List<string> { "20:00", "21:00", "22:00", "23:00", "24:00", "1:00", "2:00" });
                    break;
            }
            return result;
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
