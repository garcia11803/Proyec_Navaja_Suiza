using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProyecNavajaSuiza
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// Test para comprovar que la palabra es palindromica
        /// No debe dar resultado positivo ya que la palabra si es palindromica
        /// </summary>
        [TestMethod]
        public void TestPalindromo1()
        {
            //escenario
            string Texto = "anna";
            
            bool ResultadoEsperado = true;

            
            bool ResultadoObtenido = true;

            Palindromica.PalidromicaLogica oTexto = new Palindromica.PalidromicaLogica();

            //acción
            ResultadoObtenido = oTexto.palindromo(Texto);

            

            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
            

            

        }

        /// <summary>
        /// Test para comprovar que la palabra no es palindromica
        /// Aqui podemos comprovar que la palabra introducida no lo es.
        /// </summary>

        [TestMethod]
        public void TestPalindromo2()
        {

            //escenario
            string Texto = "Pedro";

            bool ResultadoEsperado = false;


            bool ResultadoObtenido = false;

            Palindromica.PalidromicaLogica oTexto = new Palindromica.PalidromicaLogica();

            //acción
            ResultadoObtenido = oTexto.palindromo(Texto);



            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);



        }


            /// <summary>
            /// Realizamos test de suma de dos numeros positivos  con resultado 
            /// </summary>
        [TestMethod]
        public void TestSumaNumeros1()
        {
            //escenario
            int num3;

            //accion
            int resul = Sumanumeros.SumanumerosLogica.lasuma(2,5,out num3);

            //afirmacion
            Assert.AreEqual(7, resul);
        }



        /// <summary>
        /// Realizamos la suma de dos numeros negativos y prueba OK
        /// </summary>
        [TestMethod]
        public void TestSumaNumeros2()
        {
            //escenario
            int num3;

            //accion
            int resul = Sumanumeros.SumanumerosLogica.lasuma(-2, -5, out num3);

            //afirmacion
            Assert.AreEqual(-7, resul);
        }


        /// <summary>
        /// Realizamos la suma de un numero negativo y otro positivo.OK
        /// </summary>
        /// No realizamos prueba con caracteres no numero ya que se ha limitado en la entrada de datos.
        [TestMethod]
        public void TestSumaNumeros3()
        {
            //escenario
            int num3;

            //accion
            int resul = Sumanumeros.SumanumerosLogica.lasuma(-2, 5, out num3);

            //afirmacion
            Assert.AreEqual(3, resul);
        }
         

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestFactorial1()
        {
            //escenario

            //accion

            //afirmacion




        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestTemperatura2()
        {
            //escenario

            //accion

            //afirmacion




        }



        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestTemperatur3()
        {
            //escenario

            //accion

            //afirmacion




        }



        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestTemperatura4()
        {
            //escenario

            //accion

            //afirmacion




        }






    }
}
