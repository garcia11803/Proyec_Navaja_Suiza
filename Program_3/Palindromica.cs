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
/// Programa para saber si una palabra es palindromica
/// </summary>
namespace Proyec_Navaja_Suiza.Palindromica
{/// <summary>
/// Realizamos la comparacion del string introducido y su posterior analisis
/// si la palabra es palindromica.
/// </summary>
    public partial class Palindromica : Form
    {
        

        /// <summary>
        /// Instanciamos la apli
        /// </summary>
        public Palindromica()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Aqui vamos a realizar la comprovacion de  la palabra introducida es palindromica
        /// </summary>
        /// <param name="sender">Lanza el evento bPalindro</param>
        /// <param name="e">Sin uso</param>

        private void bComprueva_Click(object sender, EventArgs e)
        {
            PalidromicaLogica opalin = new PalidromicaLogica();

            string frase = tPalabra.Text;
            bool capicua = opalin.palindromo(frase);

            if (capicua == true)
            {
                MessageBox.Show("La palabra introducida es palindromica");
            }
            else
                MessageBox.Show("La palabra introducida NO es palindromica");
        }

        private void tPalabra_TextChanged(object sender, EventArgs e)
        {
            tPalabra.MaxLength = 20;
        }
    }
}
