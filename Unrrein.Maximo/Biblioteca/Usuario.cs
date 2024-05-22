using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Usuario
    {
        private Persona persona;
        private string nombreUsuario;
        private string contraseñaUsuario;
        private DateTime horarioIngreso;

        public Usuario(Persona persona, string nombreUsuario, string contraseñaUsuario, DateTime horarioIngreso)
        {
            this.Persona = persona;
            this.NombreUsuario = nombreUsuario;
            this.ContraseñaUsuario = contraseñaUsuario;
            this.HorarioIngreso = horarioIngreso;
        }

        //Propiedades
        public Persona Persona { get => this.persona ; set => this.persona = value;}
        public string NombreUsuario { get => this.nombreUsuario ; set => this.nombreUsuario = value;}
        public string ContraseñaUsuario { get => this.contraseñaUsuario; set => this.contraseñaUsuario = value;}
        public DateTime HorarioIngreso { get => this.horarioIngreso; set => this.horarioIngreso = value;}

        public string Tostring()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Persona.ToString());
            sb.Append($"Usuario: {this.NombreUsuario}");
            sb.Append($"Contraseña: {this.ContraseñaUsuario}");
            sb.Append($"Horario de Ingreso: {this.HorarioIngreso}");
            
            return sb.ToString();
        }

        public static bool operator ==(Usuario usuario, Usuario usuario2)
        {
            if(usuario.NombreUsuario == usuario2.NombreUsuario && usuario.ContraseñaUsuario == usuario2.ContraseñaUsuario)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Usuario usuario, Usuario usuario2) 
        {
            return !(usuario == usuario2);
        }

        //=======================================================================================================
        
    }
}
