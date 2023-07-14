using DevelopmentChallenge.Entities;

namespace DevelopmentChallenge.Business
{
    public class TrapecioBusiness : Trapecio, IFormaGeometricaBusiness
    {
        public int Tipo { get; set; }
        public decimal CalcularArea()
        {
            return (decimal)((BaseMayor + BaseMenor) / 2) * (decimal)Altura;
        }

        public decimal CalcularPerimetro() 
        {
            return (decimal)(BaseMayor + BaseMenor + (Lado * 2));
        }
    }
}
