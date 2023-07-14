using System;
using System.Collections.Generic;
using System.Text;

namespace DevelopmentChallenge.Entities
{
    public class Traductor
    {
        public string Expresion { get; set; }
        public int IdIdioma { get; set; }
        public Dictionary<int,string> Traduccion { get; set; }
    }
}
