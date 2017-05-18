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
namespace ProyecNavajaSuiza.Factorial
{
    public partial class Facto : Form
    {/// <summary>
    /// Instanciamos la clase para el proceso
    /// </summary>
        public Facto()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Boton en el cual llamamos a la logica para calcular el factorial de un numero introducido
        /// </summary>
        /// <param name="sender">Lanza el evento bCalcular</param>
        /// <param name="e">sin uso</param>
        /// Realizamos la entrada de datos con tryParse para evitar datos erroneos
        private void bCalcula_Click(object sender, EventArgs e)
        {
            int numero;
            
            bool aotro = true;
            aotro = int.TryParse(tNumero.Text, out numero);

            if (aotro == false || numero < 0 )
            {
                MessageBox.Show("Dato erroeno, caracter no numero o con signo negativo");
            }
            else
            {
                string numFac = FactorialLogica.Facto(numero);

                MessageBox.Show(numFac);
            }



        }
        /// <summary>
        /// Limitamos el numero de datos que vamos a introducir en el texbox
        /// </summary>
        
        /// <param name="sender">Se ha limitado a 4 y no se puede introducir mas</param>
        /// <param name="e">bb</param>
        private void tNumero_TextChanged(object sender, EventArgs e)
        {
            tNumero.MaxLength = 4;
        }
    }
}
