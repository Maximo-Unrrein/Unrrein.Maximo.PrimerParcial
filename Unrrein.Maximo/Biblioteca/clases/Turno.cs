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
        

        public Turno() { }
        public Turno(DateTime dia, string horario)
        {
            this.Dia = dia;
            this.Horario = horario;
        }

        public DateTime Dia { get => this.dia; set => this.dia = value; }
        public string Horario { get => this.horario; set => this.horario = value; }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("TURNO:");
            sb.AppendLine($"Día: {Dia.ToString("dd/MM/yyyy")}");
            sb.Append($"Hora: {Horario}");
            return sb.ToString();
        }


    }
}
