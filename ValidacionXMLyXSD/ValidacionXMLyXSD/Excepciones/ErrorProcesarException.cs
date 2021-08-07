using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidacionXMLyXSD.Excepciones
{
    public class ErrorProcesarException : System.Exception
    {
        public ErrorProcesarException(string message) : base(message) { }
        public ErrorProcesarException(string message, System.Exception inner) : base(message, inner) { }
    }
}
