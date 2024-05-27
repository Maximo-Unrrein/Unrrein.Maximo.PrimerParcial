using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Admin
    {
        private static List<Usuario> listaUsuarios;
        private static Usuario usuarioGuardado;
        
        
        static Admin()
        {
            Admin.ListaUsuarios = new List<Usuario>();
            

        }

        public static List<Usuario> ListaUsuarios
        {
            get
            {
                return Admin.listaUsuarios;
            }
            set
            {
                Admin.listaUsuarios = value;
            }
        } 

        public static Usuario UsuarioGuardado
        {
            get
            {
                return Admin.usuarioGuardado;
            }
            set
            {
                if(value is Usuario)
                {
                    Admin.usuarioGuardado = value;
                }
            }
        }
        
        
        /// <summary>
        /// ////////////////////////
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        public static bool BuscarPersona(Usuario usuario)
        {
            foreach (Usuario uComparison in Admin.ListaUsuarios)
            {
                if (usuario == uComparison)
                {
                    return true;
                }
            }
            return false;
        }
        
        
    }
}
