using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecNavajaSuiza.Temp
{
    public class TempLogica
    {
        const int Khoras = 24;
        ///int posicion = 0;
        
        
        
        /// <summary>
        /// Vamos a saber la temperatura media de los introducidos
        /// maxima y minima
        /// </summary>
        /// <param name="vector">Aqui recogemos la temperratura de cada hora del dia</param>
        /// <param name="maxi">Aqui introducimos la temperatura maxima</param>
        /// <param name="mini">Aqui recogemos la temperatura minima</param>
        /// <param name="media">Aqui recogemos la temperatura media </param>
        public void temperatura(int[] vector, out int maxi, out int mini, out int media)
        {
            maxi = vector[0];
            mini = vector[0];
            media = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > maxi)
                {
                    maxi = vector[i];
                }
                if (vector[i] < mini)
                {
                    mini = vector[i];

                }
                media = media + vector[i];
            }
            media = media / Khoras;

        }

    }
}
