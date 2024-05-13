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
        private RangoHorario rangoHorariov;


        public Turno(RangoHorario rangoHorario, DateTime dia, DateTime horario)
        {
            this.RangoHorarioP = rangoHorario;
            this.Dia = dia;
            this.Horario = horario;
        }

        public RangoHorario RangoHorarioP { get => this.rangoHorariov; set => this.rangoHorariov = value; }
        public DateTime Dia { get => this.dia; set => this.dia = value; }
        public DateTime Horario { get => this.horario; set => this.horario = value; }

        //Metodos
        
        //*Cancelar TURNO

    }
}
