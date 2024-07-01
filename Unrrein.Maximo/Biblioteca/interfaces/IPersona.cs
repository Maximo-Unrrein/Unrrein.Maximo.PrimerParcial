using Biblioteca.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.interfaces
{
    public interface IPersona
    {
        string ToString();
        bool Equals(Persona p);
    }
}
