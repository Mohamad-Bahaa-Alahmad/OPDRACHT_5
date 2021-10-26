using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
        }

        private void smallCrtlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(Name, 12, FontStyle.Regular);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(Name, 24, FontStyle.Regular);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(Name, 36, FontStyle.Bold);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control == true && e.KeyCode == Keys.R)
            {
                textBox1.ForeColor = Color.Red;
            }
            if (e.Control == true && e.KeyCode == Keys.G)
            {
                textBox1.ForeColor = Color.Green;
            }
            if (e.Control == true && e.KeyCode == Keys.B)
            {
                textBox1.ForeColor = Color.Blue;
            }
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                textBox1.Font = new Font(Name, 12, FontStyle.Regular);
            }
            if (e.Control == true && e.KeyCode == Keys.N)
            {
                textBox1.Font = new Font(Name, 24, FontStyle.Regular);
            }
            if (e.Control == true && e.KeyCode == Keys.L)
            {
                textBox1.Font = new Font(Name, 36, FontStyle.Bold);
            }
        }
    }
}
