using DevelopmentChallenge.Entities;
using System;

namespace DevelopmentChallenge.Business
{
    public class TrianguloEquilateroBusiness: TrianguloEquilatero, IFormaGeometricaBusiness
    {
        public int Tipo { get; set; }
        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * (decimal)(Math.Pow(Lado, 2));
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)(Lado * 3);
        }
    }
}
