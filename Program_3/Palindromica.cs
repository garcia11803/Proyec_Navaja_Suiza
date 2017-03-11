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
        bool palindromo(string frase)
        {
            bool palin = true;
            int i = 0;
            int cont = frase.Length - 1;

            while(i < frase.Length / 2)
            {
                if(frase[i] != frase[cont])
                {
                    palin = false;
                }
                i++;
                cont--;
            }
            return palin;
        }

        /// <summary>
        /// Instanciamos la apli
        /// </summary>
        public Palindromica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase = textBox1.Text;
            bool capicua = palindromo(frase);

            if (capicua == true)
            {
                MessageBox.Show("La palabra introducida es palindromica");
            }
            else
                MessageBox.Show("La palabra introducida NO es palindromica");
        }
    }
}
