using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidacionXMLyXSD.Excepciones
{
    public class ErrorLeerXmlExcepcion : System.Exception
    {
        public ErrorLeerXmlExcepcion(string message) : base(message) { }
        public ErrorLeerXmlExcepcion(string message, System.Exception inner) : base(message, inner) { }
    }
}
