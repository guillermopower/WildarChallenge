using DevelopmentChallenge.Entities;
using System.Collections.Generic;

namespace DevelopmentChallenge.DB
{
    public class TipoFormaGeometricaDB: ITipoFormaGeometricaDB
    {
        private List<TipoFormaGeometrica> _TipoFormaGeometricas;
        public List<TipoFormaGeometrica> GetTipoFormaGeometricas()
        {
            _TipoFormaGeometricas.AddRange(new List<TipoFormaGeometrica>() { 
                new TipoFormaGeometrica() { Id = 1, Name = "Cuadrado" }
            , new TipoFormaGeometrica() { Id = 2, Name = "TrianguloEquilatero" }
            , new TipoFormaGeometrica() { Id = 3, Name = "Circulo" }
            , new TipoFormaGeometrica() { Id = 4, Name = "Trapecio" }
            });
            return _TipoFormaGeometricas;
        }
    }
}
