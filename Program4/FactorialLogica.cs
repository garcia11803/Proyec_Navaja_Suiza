using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Parte logica de la aplicacion de factorial
/// </summary>
namespace ProyecNavajaSuiza.Factorial
{/// <summary>
/// Clase estatica llamada factorial logica
/// </summary>
    public static class FactorialLogica
    {/// <summary>
    /// Dentro de la clase vamos a realizar el calculo del factorial del numero que hemos introducido
    /// </summary>
    /// <param name="numero">Es el numero que metemos en el programa para realizar su factorial</param>
    /// <returns>Devuelve el textro con el resultado calculado en la clase</returns>
    /// 
    ///
        public static string facto( int numero)
        {
            string text="El factorial del numero introducido es: ";

            int aux = 1;

            for ( int i = numero; i > 0; i--)
            {
                aux = aux * i;
            }
            if (aux >= Int32.MaxValue || aux < 0)
            {
                text = "Resultado fuera de rango,borre vuelva a intentarlo";
            }
            else
            {
                text = text + aux;
            }

            return text;
        }


    }
}
