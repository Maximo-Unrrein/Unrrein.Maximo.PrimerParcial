﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.excepciones
{
    public class DniInvalidoException : Exception
    {
        public DniInvalidoException(string message) : base(message) { }
        public DniInvalidoException(string? message, Exception ex) : base(message, ex) { }
    }
}
