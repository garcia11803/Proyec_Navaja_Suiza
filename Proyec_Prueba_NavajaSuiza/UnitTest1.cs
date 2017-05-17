using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProyecNavajaSuiza
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// Test para comprovar que la palabra es palindromica
        /// <remarks>No debe dar resultado positivo ya que la palabra si es palindromica</remarks>
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
        /// <remarks> Aqui podemos comprovar que la palabra introducida no lo es.</remarks>
        /// </summary>

        [TestMethod]
        public void TestPalindromo2()
        {

            //escenario
            string Texto = "pedro";

            bool ResultadoEsperado = false;


            bool ResultadoObtenido = false;

            Palindromica.PalidromicaLogica oTexto = new Palindromica.PalidromicaLogica();

            //acción
            ResultadoObtenido = oTexto.palindromo(Texto);



            //afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);



        }


        /// <summary>
        /// Test de suma de dos numeros positivos
        /// <remarks> Tiene que darnos un numero positivo en la suma de los dos</remarks>
        /// </summary>
        [TestMethod]
        public void TestSumaNumeros1()
        {
            //escenario
            int num3;

            //accion
            int resul = Sumanumeros.SumanumerosLogica.lasuma(33,22,out num3);

            //afirmacion
            Assert.AreEqual(55, resul);
        }



        /// <summary>
        /// Test que suma de dos numeros negativos 
        /// <remarks> Resultado de un numero negativo  con la suma de los dos numero</remarks>
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
        ///Test que suma de un numero negativo y otro positivo.
        ///<remarks>Nos dara un nermo con el sigo del mayor  valor 
        /// No realizamos prueba con caracteres no numero ya que se
        /// ha limitado en la entrada de datos.</remarks>
        /// </summary>
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
        /// Test de numero factorial,
        /// <remarks>El programa no admite ni letras, ni numeros negativos
        ///  y esta limitado el resultado si se pasa del maximo intero
        /// Realizamos el factorial de un numero positivo con resultado bueno.</remarks>
        /// </summary>
        [TestMethod]
        public void TestFactorial1()
        {
            //escenario
            int num = 4;

            //accion
            string resulfactorial = Factorial.FactorialLogica.facto(num);

            //afirmacion

            Assert.AreEqual("El factorial del numero introducido es: 24", resulfactorial);



        }

        /// <summary>
        /// Test del factorial de un numero positivo con resultado erroneo
        /// <remarks> Forzamos a comprovar si el resultado del factorial no es el esperado</remarks>
        /// </summary>
        [TestMethod]
        public void TestFactorial2()
        {
            //escenario
            int num = 4;
            //accion
            string resulfactorial = Factorial.FactorialLogica.facto(num);
            //afirmacion
            Assert.AreEqual("El factorial del numero introducido es: 50", resulfactorial);


        }



        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestTemperatur1()
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






    }
}
