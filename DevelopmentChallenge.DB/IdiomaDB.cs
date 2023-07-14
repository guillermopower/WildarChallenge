using DevelopmentChallenge.Entities;
using System.Collections.Generic;

namespace DevelopmentChallenge.DB
{
    public class IdiomaDB : IIdiomaDB
    {
        private List<Idioma> _Idiomas;
        public List<Idioma> GetIdiomas()
        {
            _Idiomas.AddRange(new List<Idioma>() { new Idioma() { Id = 1, Name = "Castellano" }, new Idioma() { Id = 2, Name = "Ingles" }, new Idioma() { Id = 3, Name = "Italiano" } });
            return _Idiomas;
        }

    }
}
