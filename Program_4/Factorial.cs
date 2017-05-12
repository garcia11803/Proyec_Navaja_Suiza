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
/// Para saber el  factorial de un numero utilizaremos este programa
/// </summary>
namespace Proyec_Navaja_Suiza.Factorial
{
    public partial class Factorial : Form
    {/// <summary>
    /// Instanciamos la clase para el proceso
    /// </summary>
        public Factorial()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Boton en el cual llamamos a la logica para calcular el factorial de un numero introducido
        /// </summary>
        /// <param name="sender">Lanza el evento bCalcular</param>
        /// <param name="e">sin uso</param>
        private void bCalcula_Click(object sender, EventArgs e)
        {
            int otro = int.Parse(tNumero.Text);


            string numFac = FactorialLogica.facto(otro);

            MessageBox.Show(numFac);




        }
    }
}
