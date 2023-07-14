using DevelopmentChallenge.Entities;

namespace DevelopmentChallenge.Business
{
    public class CuadradoBusiness : Cuadrado, IFormaGeometricaBusiness
    {
        public int Tipo { get; set; }
        public decimal CalcularArea()
        {
            return (decimal)(Lado * Lado);
        }

        public decimal CalcularPerimetro() 
        {
            return (decimal)(Lado * 4);
        }
    }
}
