using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Validaciones
    {
        //Validaciones para clase PERSONA
        public static bool NombreYApellido(string nombre)
        {
            string pattern = @"^[A-Za-z ]+$";
            return Regex.IsMatch(nombre, pattern);
        }

        public static bool DNI(string dni)
        {
            // Regex para un DNI válido (8 dígitos)
            string pattern = @"^\d{8}$";
            return Regex.IsMatch(dni, pattern);
        }


        public static bool Mail(string mail)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@(gmail\.com|hotmail\.com)$";
            return Regex.IsMatch(mail, pattern); 
        }

    }
}
