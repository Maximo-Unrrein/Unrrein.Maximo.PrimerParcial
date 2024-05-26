using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.excepciones
{
    public class ApellidoInvalidoException : Exception
    {
        public ApellidoInvalidoException(string message) : base(message) { }
        public ApellidoInvalidoException(string? message, Exception ex) : base(message, ex) { }
    }
}
