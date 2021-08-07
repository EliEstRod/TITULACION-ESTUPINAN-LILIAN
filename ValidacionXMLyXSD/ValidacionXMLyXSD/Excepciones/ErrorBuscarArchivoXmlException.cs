using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidacionXMLyXSD.Excepciones
{
    public class ErrorBuscarArchivoXmlException : System.Exception
    {
        public ErrorBuscarArchivoXmlException(string message) : base(message) { }
        public ErrorBuscarArchivoXmlException(string message, System.Exception inner) : base(message, inner) { }
    }
}
