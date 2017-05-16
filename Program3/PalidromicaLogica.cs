using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Parte logica de la aplicacion de palindrmo
/// </summary>
namespace ProyecNavajaSuiza.Palindromica
{/// <summary>
/// Clase creada logica para el uso del metodo palindromo
/// </summary>
    public class PalidromicaLogica
    {
        /// <summary>
        /// Booleano para comprovar si la palabra que introducimos es palindromica
        /// </summary>
        /// <param name="frase">Palabra que vamos a revisar si es palindromica</param>
        /// <returns>Valor booleano de dicho metodo</returns>
        public bool palindromo(string frase)
        {
            bool palin = true;
            int i = 0;
            int cont = frase.Length - 1;

            while (i < frase.Length / 2)
            {
                if (frase[i] != frase[cont])
                {
                    palin = false;
                }
                i++;
                cont--;
            }
            return palin;
        }



    }
}
