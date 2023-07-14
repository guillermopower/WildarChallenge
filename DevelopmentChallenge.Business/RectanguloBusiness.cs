using DevelopmentChallenge.Entities;

namespace DevelopmentChallenge.Business
{
    public class RectanguloBusiness: Rectangulo, IFormaGeometricaBusiness
    {
        public int Tipo { get; set; }
        public decimal CalcularArea()
        {
            return (decimal)(Base *Altura);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)((Base*2) + (Altura * 2));
        }
    }
}
