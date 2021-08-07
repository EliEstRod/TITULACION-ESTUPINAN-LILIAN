using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidacionXMLyXSD.Excepciones
{
    public class ErrorValidarBusquedaException : System.Exception
    {
        public ErrorValidarBusquedaException(string message) : base(message) { }
        public ErrorValidarBusquedaException(string message, System.Exception inner) : base(message, inner) { }
    }
}
