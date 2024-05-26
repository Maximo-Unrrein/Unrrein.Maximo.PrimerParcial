using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.excepciones
{
    public class NombreInvalidoException : Exception
    {
        public NombreInvalidoException(string message) : base(message) { }
        public NombreInvalidoException(string? message, Exception ex) : base(message, ex) { }


    }
}
