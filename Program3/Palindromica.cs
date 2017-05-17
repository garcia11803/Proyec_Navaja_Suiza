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
namespace ProyecNavajaSuiza.Palindromica
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
            string resultado = "";


            try
            {///Vamos a comprovar que no este vacio el textbox, para dar un aviso al usuario
                if (String.IsNullOrWhiteSpace((tPalabra.Text)))
                {
                   resultado = "AVISO: Estado vacio debes introducir una palabra ";
                }
                else
                {
                    if (capicua == true)
                    {
                        resultado = "La palabra introducida es palindromica";
                    }
                    else
                        resultado = "La palabra introducida NO es palindromica";
                }

                MessageBox.Show(resultado);
            }

           
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido un error:" );
            }


            
        }
        /// <summary>
        /// Limitamos el text box para que no puedan meter mas de 20 letras
        /// </summary>
        /// <param name="sender">Se podran ingresar hasta 20 letras </param>
        /// <param name="e"></param>
        private void tPalabra_TextChanged(object sender, EventArgs e)
        {
            tPalabra.MaxLength = 20;

        }
    }
}
