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
        public Doctor(string nombre, string apellido, int dni, string genero, List<Paciente> listaPacientes, int[] horarioAtencion, List<int> dias, string turno, string especialidad) : base(nombre, apellido, dni, genero)
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


        //MEtodos
        public override string Mostrar()
        {
            throw new NotImplementedException();
        }
    }
}
