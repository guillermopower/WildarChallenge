using DevelopmentChallenge.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DevelopmentChallenge.DB
{
    public class TraductorDB: ITraductorDB
    {
        public List<Traductor> _Traductor = new List<Traductor>();

        public string Traducir(string expresion, int IdIdioma, int Cantidad = 0, bool totales=false)
        {
            Dictionary<int, string> diccionario = new Dictionary<int, string>();
       
            diccionario.Add(1, "Lista vacía de formas!");
            diccionario.Add(2, "Empty list of shapes!");
            diccionario.Add(3, "Elenco vuoto di forme!");
            _Traductor.AddRange(new List<Traductor>(){new Traductor(){Expresion = "Lista vacía de formas!", IdIdioma=1, Traduccion =  diccionario}});

            diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "Reporte de Formas");
            diccionario.Add(2, "Shapes report");
            diccionario.Add(3, "Rapporto sui moduli");
            _Traductor.AddRange(new List<Traductor>() { new Traductor() { Expresion = "Reporte de Formas", IdIdioma = 1, Traduccion = diccionario } });

            diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "formas");
            diccionario.Add(2, "shapes");
            diccionario.Add(3, "forme");
            _Traductor.AddRange(new List<Traductor>() { new Traductor() { Expresion = "formas", IdIdioma = 1, Traduccion = diccionario } });

            diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "Perimetro");
            diccionario.Add(2, "Perimeter");
            diccionario.Add(3, "Perimetro");
            _Traductor.AddRange(new List<Traductor>() { new Traductor() { Expresion = "Perimetro", IdIdioma = 1, Traduccion = diccionario } });

            diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "Cuadrado");
            diccionario.Add(2, "Square");
            diccionario.Add(3, "Piazza");
            _Traductor.AddRange(new List<Traductor>() { new Traductor() { Expresion = "Cuadrado", IdIdioma = 1, Traduccion = diccionario } });

            diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "Círculo");
            diccionario.Add(2, "Circle");
            diccionario.Add(3, "Cerchio");
            _Traductor.AddRange(new List<Traductor>() { new Traductor() { Expresion = "Círculo", IdIdioma = 1, Traduccion = diccionario } });

            diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "Triángulo");
            diccionario.Add(2, "Triangle");
            diccionario.Add(3, "Triangolo");
            _Traductor.AddRange(new List<Traductor>() { new Traductor() { Expresion = "Triángulo", IdIdioma = 1, Traduccion = diccionario } });

            diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "Trapecio");
            diccionario.Add(2, "Trapeze");
            diccionario.Add(3, "Trapezio");
            _Traductor.AddRange(new List<Traductor>() { new Traductor() { Expresion = "Trapecio", IdIdioma = 1, Traduccion = diccionario } });

            diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "Rectángulo");
            diccionario.Add(2, "Rectangle");
            diccionario.Add(3, "Rettangolo");
            _Traductor.AddRange(new List<Traductor>() { new Traductor() { Expresion = "Rectángulo", IdIdioma = 1, Traduccion = diccionario } });

            return _Traductor.FirstOrDefault(x=>x.Expresion==expresion).Traduccion.FirstOrDefault(y=>y.Key==IdIdioma).Value + (Cantidad > 1 && totales==false ? "s" : "");
 
        }
    }
}
