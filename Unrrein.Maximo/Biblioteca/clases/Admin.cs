using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Biblioteca.clases;

namespace Biblioteca
{
    public class Admin
    {
        private static List<Usuario> listaUsuarios;
        private static List<Paciente> listaPacientes;
        private static List<Doctor> listaDoctores;
        private static Usuario usuarioGuardado;

        private static string rutaCompleta;


        //private static List<Paciente> listaPaciente;
        
        
        static Admin()
        {
            Admin.listaUsuarios = new List<Usuario>();
            Admin.listaPacientes = new List<Paciente>();
            Admin.listaDoctores = new List<Doctor>();
            
            Admin.rutaCompleta = string.Empty;
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
        public static List<Paciente> ListaPacientes
        {
            get
            {
                return Admin.listaPacientes;
            }
            set
            {
                Admin.listaPacientes = value;
            }
        } 
        
        public static List<Doctor> ListaDoctores
        {
            get
            {
                return Admin.listaDoctores;
            }
            set
            {
                Admin.listaDoctores = value;
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

        public static string RutaCompleta
        {
            get => Admin.rutaCompleta; set => Admin.rutaCompleta = value;
        }


        /// <summary>
        /// Funcion que busca a pacientes en la lista de usuarios de Admin
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        public static bool BuscarPersona(Paciente paciente)
        {
            foreach (Paciente pComparison in Admin.ListaPacientes)
            {
                if (pComparison == paciente)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool BuscarPersona(Doctor doctor)
        {
            foreach (Doctor dComparison in Admin.ListaDoctores)
            {
                if (dComparison == doctor)
                {
                    return true;
                }
            }
            return false;
        }


        public static string RutaArchivoJSON()
        {
            // Escapa las barras invertidas en el patrón de la expresión regular
            string[] parts = Regex.Split(AppDomain.CurrentDomain.BaseDirectory, @"\\");

            // Elimina los últimos 5 componentes
            parts = parts.Take(parts.Length - 5).ToArray();

            string reconstruccionRuta = string.Empty;
            foreach (string part in parts)
            {
                reconstruccionRuta += part + "\\";
            }
            reconstruccionRuta += "Biblioteca\\data.json";

            return reconstruccionRuta;
        }

    }
}
