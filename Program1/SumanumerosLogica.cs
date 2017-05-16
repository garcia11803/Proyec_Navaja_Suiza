using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/// <summary>
/// Parte logica de la aplicacion sumanumeros
/// </summary>
namespace ProyecNavajaSuiza.Sumanumeros
{/// <summary>
/// Clase estatica sumanumeros logica en la cual realizaremos la suma de dos numeros
/// </summary>
    public static class SumanumerosLogica
    {
        /// <summary>
        /// Realizamos la sum de los dos numeros introducidos
        /// </summary>
        /// <param name="num1">Primer numero introducido</param>
        /// <param name="num2">Segundo numero introducido</param>
        /// <param name="resul">Resultado dfe la suma de los numeros introducidos</param>
        public static int lasuma(int num1,int num2,out int resul)
        {
            resul = num1 + num2;

            return resul;
        }
        
    }
}
