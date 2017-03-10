using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyec_Navaja_Suiza
{/// <summary>
///     Clase base,del proyecto
/// </summary>
    public partial class Navaja_Suiza : Form
    {/// <summary>
    ///     Instanciador de la clase principal, parte fundamental del programa
    /// </summary>
        public Navaja_Suiza()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ////En este boton realizamos la llamada al programa sumanumeros
          
            Sumanumeros.Sumanumeros osuma = new Sumanumeros.Sumanumeros();
            osuma.ShowDialog();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////Aqui realizamos la activacion del prorama para calcular la tem, 
            ////max min y media in introducido
            Temp.Temp otemperatura = new Temp.Temp();
            otemperatura.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //// Ahora vamos a iniciar el programa poara saber si una palabra intooducida es palindromica
            Palindromica.Palindromica opalin = new Palindromica.Palindromica();
            opalin.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ////Aqui iniciamos el programa para saber el factorial de un numero introducido
            Factorial.Factorial ofacto = new Factorial.Factorial();
            ofacto.ShowDialog();
        }
    }
}

