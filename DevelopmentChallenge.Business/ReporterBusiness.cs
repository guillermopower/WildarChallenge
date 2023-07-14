using DevelopmentChallenge.DB;
using DevelopmentChallenge.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DevelopmentChallenge.Business
{
    public class ReporterBusiness : IReporterBusiness
    {
        private readonly ITraductorDB TraductorDB;
        public List<IFormaGeometricaBusiness> formas { get; set; }
        public int idioma { get; set; }

        public ReporterBusiness(ITraductorDB traductorDB)
        {
            this.TraductorDB = traductorDB;
        }
        public string Imprimir()
        {
           var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append("<h1>" + TraductorDB.Traducir("Lista vacía de formas!", idioma) + "</h1>");
            }
            else
            {
                sb.Append("<h1>" + TraductorDB.Traducir("Reporte de Formas", idioma) + "</h1>");

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;

                var numeroTrapecios = 0;
                var areaTrapecios = 0m;
                var perimetroTrapecios = 0m;

                var numeroRectangulos = 0;
                var areaRectangulos = 0m;
                var perimetroRectangulos = 0m;

                for (var i = 0; i < formas.Count; i++)
                {
                    if (formas[i].Tipo == (int)TipoFormaGeometrica.Tipos.Cuadrado)
                    {
                        numeroCuadrados++;
                        areaCuadrados += formas[i].CalcularArea();
                        perimetroCuadrados += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo == (int)TipoFormaGeometrica.Tipos.Circulo)
                    {
                        numeroCirculos++;
                        areaCirculos += formas[i].CalcularArea();
                        perimetroCirculos += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo == (int)TipoFormaGeometrica.Tipos.TrianguloEquilatero)
                    {
                        numeroTriangulos++;
                        areaTriangulos += formas[i].CalcularArea();
                        perimetroTriangulos += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo== (int)TipoFormaGeometrica.Tipos.Trapecio)
                    {
                        numeroTrapecios++;
                        areaTrapecios += formas[i].CalcularArea();
                        perimetroTrapecios += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo == (int)TipoFormaGeometrica.Tipos.Rectangulo)
                    {
                        numeroRectangulos++;
                        areaRectangulos += formas[i].CalcularArea();
                        perimetroTriangulos += formas[i].CalcularPerimetro();
                    }
                }

                sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, (int)TipoFormaGeometrica.Tipos.Cuadrado, idioma));
                sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, (int)TipoFormaGeometrica.Tipos.Circulo, idioma));
                sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, (int)TipoFormaGeometrica.Tipos.TrianguloEquilatero, idioma));
                sb.Append(ObtenerLinea(numeroTrapecios, areaTrapecios, perimetroTrapecios, (int)TipoFormaGeometrica.Tipos.Trapecio, idioma));
                sb.Append(ObtenerLinea(numeroRectangulos, areaRectangulos, perimetroRectangulos, (int)TipoFormaGeometrica.Tipos.Rectangulo, idioma));

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + numeroRectangulos + numeroTrapecios + " " + TraductorDB.Traducir("formas", idioma) + " ");
                sb.Append(TraductorDB.Traducir("Perimetro", idioma) + " " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecios + perimetroRectangulos).ToString("#.##") + " ");
                sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos + areaTrapecios + areaRectangulos).ToString("#.##"));
            }

            return sb.ToString();
        }
        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, int idioma)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | {TraductorDB.Traducir("Perimetro", idioma, cantidad,true)} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        public string TraducirForma(int tipo, int cantidad, int idioma)
        {
            switch (tipo)
            {
                case (int)TipoFormaGeometrica.Tipos.Cuadrado:
                    return TraductorDB.Traducir("Cuadrado", idioma, cantidad);
                case (int)TipoFormaGeometrica.Tipos.Circulo:
                    return TraductorDB.Traducir("Círculo", idioma, cantidad);
                case (int)TipoFormaGeometrica.Tipos.TrianguloEquilatero:
                    return TraductorDB.Traducir("Triángulo", idioma, cantidad);
                case (int)TipoFormaGeometrica.Tipos.Trapecio:
                    return TraductorDB.Traducir("Trapecio", idioma, cantidad);
                case (int)TipoFormaGeometrica.Tipos.Rectangulo:
                    return TraductorDB.Traducir("Rectángulo", idioma, cantidad);
            }

            return string.Empty;
        }
    }
}
