using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.clases;

namespace Biblioteca.clases
{
    public sealed class Turno
    {

        private DateTime dia;
        private string horario;
        private Doctor doctor;

        public Turno() { }
        public Turno(Doctor doctor, DateTime dia, string horario)
        {
            this.Doctor = doctor;
            this.Dia = dia;
            this.Horario = horario;
        }

        public Doctor Doctor { get => doctor; set => doctor = value; }
        public DateTime Dia { get => dia; set => dia = value; }
        public string Horario { get => horario; set => horario = value; }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Turno: {Doctor.Nombre} {Doctor.Apellido}");
            sb.AppendLine($"Día: {Dia.ToString("dd/MM/yyyy")}");
            sb.Append($"Hora: {Horario}");
            return sb.ToString();
        }


    }
}
