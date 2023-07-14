using DevelopmentChallenge.DB;
using DevelopmentChallenge.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevelopmentChallenge.Business.Test
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestResumenListaVaciaCastellano()
        {
            ReporterBusiness reporter = new ReporterBusiness(new TraductorDB());
            reporter.formas = new System.Collections.Generic.List<IFormaGeometricaBusiness>();
            reporter.idioma = (int) Idioma.Idiomas.Castellano;
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                reporter.Imprimir());
        }

        [TestMethod]
        public void TestResumenListaVaciaItaliano()
        {
            ReporterBusiness reporter = new ReporterBusiness(new TraductorDB());
            reporter.formas = new System.Collections.Generic.List<IFormaGeometricaBusiness>();
            reporter.idioma = (int)Idioma.Idiomas.Italiano; ;
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                reporter.Imprimir());
        }

        [TestMethod]
        public void TestResumenListaConUnCuadrado()
        {
            ReporterBusiness reporter = new ReporterBusiness(new TraductorDB());
            reporter.formas = new System.Collections.Generic.List<IFormaGeometricaBusiness>();
            reporter.idioma = (int)Idioma.Idiomas.Castellano;
            reporter.formas.Add(new CuadradoBusiness() { Lado = 5, Tipo = (int)TipoFormaGeometrica.Tipos.Cuadrado});

            var resumen = reporter.Imprimir();

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestMethod]
        public void TestResumenListaConMasCuadrados()
        {
            ReporterBusiness reporter = new ReporterBusiness(new TraductorDB());
            reporter.formas = new System.Collections.Generic.List<IFormaGeometricaBusiness>();
            reporter.idioma = (int)Idioma.Idiomas.Ingles;
            reporter.formas.Add(new CuadradoBusiness() { Lado = 5, Tipo = (int)TipoFormaGeometrica.Tipos.Cuadrado });
            reporter.formas.Add(new CuadradoBusiness() { Lado = 1, Tipo = (int)TipoFormaGeometrica.Tipos.Cuadrado });
            reporter.formas.Add(new CuadradoBusiness() { Lado = 3, Tipo = (int)TipoFormaGeometrica.Tipos.Cuadrado });

            var resumen = reporter.Imprimir();

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestMethod]
        public void TestResumenListaConUnTrapecio()
        {
            ReporterBusiness reporter = new ReporterBusiness(new TraductorDB());
            reporter.formas = new System.Collections.Generic.List<IFormaGeometricaBusiness>();
            reporter.idioma = (int)Idioma.Idiomas.Castellano;
            reporter.formas.Add(new TrapecioBusiness() { BaseMenor =4, BaseMayor=8,Altura=7, Lado = 7.3, Tipo = (int)TipoFormaGeometrica.Tipos.Trapecio });

            var resumen = reporter.Imprimir();

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 42 | Perimetro 26.6 <br/>TOTAL:<br/>1 formas Perimetro 26.6 Area 42", resumen);
        }

    }
}
