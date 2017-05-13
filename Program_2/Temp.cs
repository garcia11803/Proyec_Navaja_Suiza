using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyec_Navaja_Suiza.Temp
{/// <summary>
/// Clas e creada para la realizacion del programa de temeratura
/// </summary>

    public partial class Temp : Form
    {
        TempLogica otemperatura = new TempLogica();

        int posicion = 0;

        

        /// <summary>
        /// Aqui creamos vector para la recogida de datos y posterior utilizacion
        /// </summary>
        const int Khoras = 24;

        int[] vector = new int[Khoras];
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        public void FLeoVector(int[] vector)
        {
            bool bNumeroCorrecto;
            int numero;

            bNumeroCorrecto = int.TryParse(tTemperatura.Text, out numero);

            if (bNumeroCorrecto)
            {
                if (posicion < vector.Length)
                {
                    vector[posicion] = numero;
                    tTemperatura.Text = "";
                    posicion++;
                }
                else
                {
                    MessageBox.Show("Completado los temperaturas del dia");
                }
            }
            else
            {
                MessageBox.Show("¡Error! El valor introducido por el usuario no es un número entero");
            }
        }



        /// <summary>
        /// Instacionamos la apli
        /// </summary>
        public Temp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Con este boton relalizaremos la obtencion de temp max, temp media y temp mini
        /// </summary>
        /// <param name="sender">Lanza evento boton de calcular MED, MIN y MAX</param>
        /// <param name="e">Sin uso</param>
        private void bCalcula_Click(object sender, EventArgs e)
        {
            
            int tempmedia, maxima, minima;
            
           
            otemperatura.temperatura(vector, out maxima, out minima, out tempmedia);

            MessageBox.Show("La temperatura maxima es  " + maxima + ", la temperatura minima es " +
                minima +", la temperatura media es " + tempmedia);




        }
        /// <summary>
        /// Vamos a guardar la temperatura de cada hora del dia, para despues realizar una serie de calculos del ortro boton
        /// </summary>
        /// <param name="sender">Lanza el evento de leer el vector de temperatura</param>
        /// <param name="e">Sin uso</param>
        private void bleeTemp_Click(object sender, EventArgs e)
        {

          FLeoVector(vector);

        }
        /// <summary>
        /// Limitacion en el textbox para  no poder iuntroducir mas de 2 cifras
        /// </summary>
        /// <param name="sender">Redcimos a 2 los caracteres</param>
        /// <param name="e">aa</param>
        private void tTemperatura_TextChanged(object sender, EventArgs e)
        {
            tTemperatura.MaxLength = 2;
            
        }
    }
}
