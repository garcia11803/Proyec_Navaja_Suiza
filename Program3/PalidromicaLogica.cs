using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecNavajaSuiza.Palindromica
{
    public class PalidromicaLogica
    {

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
