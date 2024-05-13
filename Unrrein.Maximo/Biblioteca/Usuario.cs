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

        public Usuario(Persona persona, string nombreUsuario, string contraseñaUsuario)
        {
            this.Persona = persona;
            this.NombreUsuario = nombreUsuario;
            this.ContraseñaUsuario = contraseñaUsuario;
        }

        //Propiedades
        public Persona Persona { get => this.persona ; set => this.persona = value;}
        public string NombreUsuario { get => this.nombreUsuario ; set => this.nombreUsuario = value;}
        public string ContraseñaUsuario { get => this.contraseñaUsuario; set => this.contraseñaUsuario = value;}


    }
}
