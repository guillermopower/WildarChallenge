namespace DevelopmentChallenge.Business
{
    public interface IReporterBusiness
    {
        string Imprimir();
        string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, int idioma);
        string TraducirForma(int tipo, int cantidad, int idioma);
    }
}
