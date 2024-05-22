using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Admin
    {
        private static List<Persona> listaPersonas;
        static Admin()
        {
            Admin.ListaPersonas = new List<Persona>();
        }

        public static List<Persona> ListaPersonas
        {
            get
            {
                return Admin.listaPersonas;
            }
            set
            {
                Admin.listaPersonas = value;
            }
        }


        public static bool BuscarPersona(Persona persona)
        {
            foreach (Persona pComparison in Admin.listaPersonas)
            {
                if (persona == pComparison)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
