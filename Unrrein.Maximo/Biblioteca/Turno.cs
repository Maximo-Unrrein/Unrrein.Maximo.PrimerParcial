using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Biblioteca.Paciente;

namespace Biblioteca
{
    public sealed class Turno
    {
        
        private DateTime dia;
        private string horario;
        private Doctor doctor;

        public Turno(Doctor doctor, DateTime dia, string horario)
        {
            this.Doctor = doctor;
            this.Dia = dia;
            this.Horario = horario;
        }

        public Doctor Doctor{ get => this.doctor; set => this.doctor = value; }
        public DateTime Dia { get => this.dia; set => this.dia = value; }
        public string Horario { get => this.horario; set => this.horario = value; }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Turno: {this.Doctor.Nombre} {this.Doctor.Apellido}");
            sb.AppendLine($"Día: {this.Dia.ToString("dd/MM/yyyy")}");
            sb.Append($"Hora: {this.Horario}");
            return sb.ToString();
        }


    }
}
