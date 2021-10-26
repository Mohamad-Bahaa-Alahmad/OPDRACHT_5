using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening3
{
    public partial class Form2 : Form
    {
        public int alpha, rood, groen, blauw;

        

        public Form2()
        {
            InitializeComponent();
        }
        private void Alph_ValueChanged(object sender, EventArgs e)
        {
            alpha = Convert.ToInt32(Alph.Value);
        }

        private void Red_ValueChanged(object sender, EventArgs e)
        {
            rood = Convert.ToInt32(Red.Value);
        }

        private void Green_ValueChanged(object sender, EventArgs e)
        {

            groen = Convert.ToInt32(Green.Value);
        }

        private void Blue_ValueChanged(object sender, EventArgs e)
        {
            blauw = Convert.ToInt32(Blue.Value);
        }
    }
}
