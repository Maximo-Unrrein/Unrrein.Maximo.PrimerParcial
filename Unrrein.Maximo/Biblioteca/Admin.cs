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
        private static List<Doctor> listaDoctor;
        
        static Admin()
        {
            Admin.ListaUsuarios = new List<Usuario>();
            Admin.ListaDoctor = new List<Doctor>();

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
        
        public static List<Doctor> ListaDoctor
        {
            get
            {
                return Admin.listaDoctor;
            }
            set
            {
                Admin.listaDoctor = value;
            }
        }


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
        
        public static bool BuscarPersona(Doctor doctor)
        {
            foreach (Doctor dComparison in Admin.ListaDoctor)
            {
                if (doctor == dComparison)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
