using DevelopmentChallenge.Entities;
using System.Collections.Generic;

namespace DevelopmentChallenge.DB
{
    public interface IIdiomaDB
    {
        List<Idioma> GetIdiomas();
    }
}
