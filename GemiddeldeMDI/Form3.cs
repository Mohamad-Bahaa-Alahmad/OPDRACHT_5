using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GemiddeldeMDI
{
    public partial class Form3 : Form
    {
        public double getal { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getal = double.Parse(textBox1.Text);

            this.Close();
        }
    }
}
