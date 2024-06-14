using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.excepciones
{
    public class MailInvalidoException : Exception
    {
        public MailInvalidoException(string message) : base(message) { }
        public MailInvalidoException(string? message, Exception ex) : base(message, ex) { }
    }
}
