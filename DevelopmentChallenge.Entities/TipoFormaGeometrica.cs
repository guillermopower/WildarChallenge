using System;
using System.Collections.Generic;
using System.Text;

namespace DevelopmentChallenge.Entities
{
    public class TipoFormaGeometrica
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public enum Tipos { Cuadrado = 1, TrianguloEquilatero = 2, Circulo = 3, Trapecio = 4, Rectangulo = 5}
    }
}
