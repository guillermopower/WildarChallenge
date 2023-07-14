using System;
using System.Collections.Generic;
using System.Text;

namespace DevelopmentChallenge.Entities
{
    public class Idioma
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public enum Idiomas
        {
            Castellano=1,
            Ingles=2,
            Italiano=3
        }
    }
}
