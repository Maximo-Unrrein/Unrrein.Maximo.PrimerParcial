using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.excepciones
{
    public class ContraseñaInvalidaException : Exception
    {
        public ContraseñaInvalidaException(string message) : base(message) { }
        public ContraseñaInvalidaException(string? message, Exception ex) : base(message, ex) { }
    }
}
