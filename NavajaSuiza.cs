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
/// Metodo principal donde tenemos el resto de aplicaciones
/// </summary>
namespace ProyecNavajaSuiza
{/// <summary>
///     Clase base,del proyecto
/// </summary>
    public partial class NavajaSuiza : Form
    {/// <summary>
    ///     Instanciador de la clase principal, parte fundamental del programa
    /// </summary>
        public NavajaSuiza()
        {
            InitializeComponent();
        }
        /// <summary>
        /// En este boton realizamos la llamada al programa sumanumeros
        /// </summary>
        /// <param name="sender">Lanza el evento de sumanumeros</param>
        /// <param name="e">Sin uso</param>
        private void bSumanumeros_Click(object sender, EventArgs e)
        {
            
          
            Sumanumeros.Sumanumeros osuma = new Sumanumeros.Sumanumeros();
            osuma.ShowDialog();
            
            
        }

        /// <summary>
        /// Aqui realizamos la activacion del prorama para calcular la tem, 
         ///max min y media in introducido
        /// </summary>
        /// <param name="sender">Lanza el evento de temperatura</param>
        /// <param name="e">Sin uso</param>

        private void bTemperatura_Click(object sender, EventArgs e)
        {
          
            Temp.Temp otemperatura = new Temp.Temp();
            otemperatura.ShowDialog();

        }

        /// <summary>
        /// Ahora vamos a iniciar el programa poara saber si una palabra intooducida es palindromica
        /// </summary>
        /// <param name="sender">Lanza el evento de boton Palindrmo</param>
        /// <param name="e"></param>

        private void bPalindromo_Click(object sender, EventArgs e)
        {
           
            Palindromica.Palindromica opalin = new Palindromica.Palindromica();
            opalin.ShowDialog();
        }

        /// <summary>
        /// Aqui iniciamos el programa para saber el factorial de un numero introducido
        /// </summary>
        /// <param name="sender">Lanza el evento de boton factorial</param>
        /// <param name="e">Sin uso</param>
        private void bFactorial_Click(object sender, EventArgs e)
        {

            
            Factorial.Facto ofacto = new Factorial.Facto();
            ofacto.ShowDialog();
        }

        private void Navaja_Suiza_Load(object sender, EventArgs e)
        {

        }
    }
}

