using DevelopmentChallenge.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevelopmentChallenge.DB
{
    public interface ITipoFormaGeometricaDB
    {
        public List<TipoFormaGeometrica> GetTipoFormaGeometricas();
    }
}
