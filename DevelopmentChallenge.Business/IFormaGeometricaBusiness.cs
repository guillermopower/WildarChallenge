using DevelopmentChallenge.Entities;

namespace DevelopmentChallenge.Business
{
    public interface IFormaGeometricaBusiness
    {
        public int Tipo { get; set; }
        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}
        
