using DevelopmentChallenge.Entities;
using System;

namespace DevelopmentChallenge.Business
{
    public class CirculoBusiness: Circulo, IFormaGeometricaBusiness
    {
        public int Tipo { get; set; }
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (decimal)Math.Pow(Radio, 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)(Math.PI * 2*Radio);
        }
    }
}
