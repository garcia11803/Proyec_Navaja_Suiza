using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>Programa sumanuemros
///<remarks> Programa en el cual realizaremos la suma de dos numeros enteros,
/// </remarks>
/// </summary>
namespace ProyecNavajaSuiza.Sumanumeros
{   /// <summary>
    /// Clase sumanumeros
    /// </summary>
    public partial class Sumanumeros : Form
    {
         

        
        /// <summary>
        ///   Aqui se instacia la apli
        /// </summary>
        public Sumanumeros()
        {
            InitializeComponent();
        }
        

        /// <summary>
        /// Realizamos la suma de dos numeros pasando por la logica
        /// </summary>
        /// <param name="sender">Suma los numeros introducidos y validados por el try </param>
        /// <param name="e"></param>
        private void bCalcula_Click(object sender, EventArgs e)
        {
            int num1, num2,resul,suma;
            bool oknumero1 = false;
            bool oknumero2 = false;
            if ((oknumero1 = int.TryParse(tNumero1.Text, out num1) == true) && (oknumero2 = int.TryParse(tNumero2.Text, out num2)))
            {
                SumanumerosLogica.lasuma(num1, num2, out resul);
                MessageBox.Show("El resultado de la suma de " + num1 + " y " + num2 + " es: " + resul);
            }
            else
            {
                MessageBox.Show("Agun caracter no permitido, revise y vuelva a intentarlo");
            }
                        
           

            

        }
        /// <summary>
        /// Vamos a limitar la cifra por la que vamos a sumar
        /// <remarks>Con ello conseguimos un a limitacion en la enttrada de datos</remarks>
        /// </summary>
        /// <param name="sender">Hemos limitado a 10 la cifra por la que sumamos</param>
        /// <param name="e">nn</param>
        private void tNumero1_TextChanged(object sender, EventArgs e)
        {
            tNumero1.MaxLength = 9;
        }
        /// <summary>
        /// Vamos a limitar la cifra por la que vamos a sumar
        /// <remarks>Con ello conseguimos un a limitacion en la enttrada de datos</remarks>
        /// </summary>
        /// <param name="sender">Hemos limitado a 10 la cifra por la que sumamos</param>
        /// <param name="e">nn</param>
        private void tNumero2_TextChanged(object sender, EventArgs e)
        {
            tNumero2.MaxLength = 9;
        }
    }
}
