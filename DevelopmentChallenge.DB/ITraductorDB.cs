namespace DevelopmentChallenge.DB
{
    public interface ITraductorDB
    {
        string Traducir(string expresion, int IdIdioma, int Cantidad = 0, bool totales=false);
    }
}
