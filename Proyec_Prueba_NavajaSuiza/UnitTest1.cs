using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Proyec_Navaja_Suiza
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
            
        [TestMethod]
        public void TestSumaNumeros()
        {
            //escenario

            //accion

            //afirmacion

        }
     }
}
