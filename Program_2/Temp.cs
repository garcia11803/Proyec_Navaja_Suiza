﻿using System;
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
        int posicion = 0;

        private static string InputBox(string texto)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = texto;
            ib.DefaultValue = "";
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }
        /// <summary>
        /// Aqui creamos vector para la recogida de datos y posterior utilizacion
        /// </summary>
        const int Khoras = 24;

        int[] vector = new int[Khoras];
        /*
        void leervector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
              vector[i] = int.Parse(InputBox("Introduzca el elemento " + i));
            }
            

        }*/

        void FLeoVector(int[] vector)
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
                    MessageBox.Show("Vector lleno");
                }
            }
            else
            {
                MessageBox.Show("¡Error! El valor introducido por el usuario no es un número entero");
            }
        }

        /// <summary>
        /// Vamos a saber la temperatura media de los introducidos
        /// maxima y minima
        /// </summary>
        /// <param name="vector">Aqui recogemos la temperratura de cada hora del dia</param>
        /// <param name="maxi">Aqui introducimos la temperatura maxima</param>
        /// <param name="mini">Aqui recogemos la temperatura minima</param>
        /// <param name="media">Aqui recogemos la temperatura media </param>
        void temperatura(int []vector, out int maxi, out int mini, out int media)
        {
            maxi = vector[0];
            mini = vector[0];
            media = 0;
            
            for(int i = 0; i < vector.Length; i++)
            {
                    if(vector[i]> maxi)
                    {
                    maxi = vector[i];
                     }
                      if(vector[i]<mini)
                        {
                        mini = vector[i];

                        }
                media = media + vector[i];
            }
            media = media / Khoras;

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
            
            //leervector(vector);
            temperatura(vector, out maxima, out minima, out tempmedia);

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
    }
}
