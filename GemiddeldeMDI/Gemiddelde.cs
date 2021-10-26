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
    public partial class Gemiddelde : Form
    {
        public Gemiddelde()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3= new Form3();

            


            if (form3.ShowDialog() == DialogResult.OK)
            {

                listBox1.Items.Add(form3.getal);
                int count = listBox1.Items.Count;
                double sum = 0;
                foreach (double i in listBox1.Items)
                {
                    sum += i;
                }
                double result = sum / (double)count;
                textBox1.Text = result.ToString() ;
            }
            
            
        }
        
    }
}
