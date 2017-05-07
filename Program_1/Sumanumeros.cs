using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    /// <summary>
    /// Aqui tenemos el nombre completo del programa
    /// </summary>
namespace Proyec_Navaja_Suiza.Sumanumeros
{
    public partial class Sumanumeros : Form
    {/// <summary>
    /// Realizamos la sum de los dos numeros introducidos
    /// </summary>
    /// <param name="num1">Primer numero introducido</param>
    /// <param name="num2">Segundo numero introducido</param>
    /// <returns>En este metodo nos da el resultado de la suma</returns>

        int suma(int num1, int num2)
        {
            int resul;
            resul = num1 + num2;
            return resul;
        }
        /// <summary>
        ///   Aqui se instacia la apli
        /// </summary>
        public Sumanumeros()
        {
            InitializeComponent();
        }
        /// <summary>
        /// En este boton declaramos una serie de variables y llamamos al metodo suma
        /// </summary>
        /// <param name="sender">Lanza el evento de sumanmeros</param>
        /// <param name="e">Sin uso</param>
        private void bCalcula_Click(object sender, EventArgs e)
        {
            
            int numero1, numero2,sumador;
            numero1 = int.Parse(tNumero1.Text);
            numero2 = int.Parse(tNumero2.Text);
            sumador = suma(numero1, numero2);

            MessageBox.Show("El resultado de la suma es " + sumador.ToString());

        }
    }
}
