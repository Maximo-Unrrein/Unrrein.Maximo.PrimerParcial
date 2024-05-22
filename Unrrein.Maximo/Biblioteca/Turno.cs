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
        public enum RangoHorario { Mañana, Tarde, Noche};
        private DateTime dia;
        private DateTime horario;
        private RangoHorario rangoHorario;



        public Turno() { }
        public Turno(RangoHorario rangoHorario, DateTime dia, DateTime horario)
        {
            this.RangoHorarioP = rangoHorario;
            this.Dia = dia;
            this.Horario = horario;
        }

        public RangoHorario RangoHorarioP { get => this.rangoHorario; set => this.rangoHorario = value; }
        public DateTime Dia { get => this.dia; set => this.dia = value; }
        public DateTime Horario { get => this.horario; set => this.horario = value; }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Turno: {this.RangoHorarioP}");
            sb.AppendLine($"Día: {this.Dia.ToString("dd/MM/yyyy")}");
            sb.Append($"Hora: {this.Horario.ToString("HH:mm")}");
            return sb.ToString();
        }

        //Metodos
        
        //*Cancelar TURNO

    }
}
