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
{
    public partial class Navaja_Suiza : Form
    {
        public Navaja_Suiza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Sumanumeros.Sumanumeros osuma = new Sumanumeros.Sumanumeros();
            osuma.ShowDialog();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Temp.Temp otemperatura = new Temp.Temp();
            otemperatura.ShowDialog();

        }   
    }
}

