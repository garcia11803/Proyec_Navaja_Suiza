using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void bCalcula_Click(object sender, EventArgs e)
        {

            int i, num,fact;
            String texto1,texto2;
            fact = 1;
            texto1 = "El numero factorial de ";
            texto2 = " es: ";
            num = int.Parse(tNumero.Text);
            for (i=num ;i > 0 ; i--)
            {
                fact = fact * i;
                
            }
            MessageBox.Show(texto1 + num + texto2 + fact );

        }
    }
}
