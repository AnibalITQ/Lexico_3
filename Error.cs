using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lexico_3
{
    public class Error : Exception
    {
        private char v;

        public Error(char v)
        {
            this.v = v;
        }

        public Error(string mensaje, StreamWriter log, int linea, int columna) : base(mensaje + " en la linea "+linea + ", columna "+columna)
        {
            log.WriteLine("Error: "+mensaje+" en la linea "+linea);
        }
        
    }
}