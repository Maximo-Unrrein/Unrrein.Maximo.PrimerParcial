using Biblioteca.excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Biblioteca.clases
{
    public sealed class Usuario
    {

        private Paciente? paciente;
        private Doctor? doctor;


        private string nombreUsuario;
        private string contraseñaUsuario;
        private DateTime horarioIngreso;

        private string mail;
        //Agregar constructor sin parámetros /ERROR DESERILIZACION



        public Usuario()
        {

        }
        public Usuario(string nombreUsuario, string contraseñaUsuario, string mail)
        {
            this.NombreUsuario = nombreUsuario;
            this.ContraseñaUsuario = contraseñaUsuario;
            this.Mail = mail;
        }
        public Usuario(Paciente persona, string nombreUsuario, string contraseñaUsuario, string mail)
        {
            this.Paciente = persona;
            this.NombreUsuario = nombreUsuario;
            this.ContraseñaUsuario = contraseñaUsuario;
            //this.HorarioIngreso = horarioIngreso;
            this.Mail = mail;
        }

        public Usuario(Doctor persona, string nombreUsuario, string contraseñaUsuario, string mail)
        {
            this.Doctor = persona;
            this.NombreUsuario = nombreUsuario;
            this.ContraseñaUsuario = contraseñaUsuario;
            //this.HorarioIngreso = horarioIngreso;
            this.Mail = mail;
        }





        //Propiedades
        

        public Paciente? Paciente { get => paciente; set => paciente = value; }
        public Doctor? Doctor { get => doctor; set => doctor = value; }

        public string NombreUsuario { get => nombreUsuario; set { if (value != null) { nombreUsuario = value; }; } }
        public string ContraseñaUsuario { get => contraseñaUsuario; set { if (value != null) { contraseñaUsuario = value; }; } }
        public DateTime HorarioIngreso { get => horarioIngreso; set => horarioIngreso = value; }



        public string Mail
        {
            get => this.mail;
            set
            {
                if (Validaciones.Mail(value))
                {
                    this.mail = value;
                }
                else
                {
                    throw new MailInvalidoException("Mail Invalido");
                }
            }
        }



        //Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Paciente is not null)
            {
                sb.Append(Paciente.ToString());
            }
            if (Doctor is not null)
            {
                sb.Append(Doctor.ToString());

            }


            sb.AppendLine($"Usuario: {NombreUsuario}");
            sb.AppendLine($"Contraseña: {ContraseñaUsuario}");
            sb.Append($"Horario de Ingreso: {HorarioIngreso}");

            return sb.ToString();
        }

        public static bool operator ==(Usuario usuario, Usuario usuario2)
        {
            if (usuario.NombreUsuario == usuario2.NombreUsuario && usuario.ContraseñaUsuario == usuario2.ContraseñaUsuario)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Usuario usuario, Usuario usuario2)
        {
            return !(usuario == usuario2);
        }
    }
}
