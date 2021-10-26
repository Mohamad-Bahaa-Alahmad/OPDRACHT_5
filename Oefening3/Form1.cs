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
    public partial class Form1 : Form
    {
        List<Button> list = new List<Button>();
     
        public Form1()
        {
            InitializeComponent();
        }

        private void rechthoekToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Button button = new Button();
            button.BackColor = Color.Red;
            
            button.MouseHover += new EventHandler(this.btn_MouseHover);
            list.Add(button);
            this.Print();
        }

        private void rechthoekVerwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(list.Count > 0)
            {
                list.RemoveAt(list.Count - 1);
                this.Controls.RemoveAt(this.Controls.Count - 1);
                this.Print();
            }
            
            
        }
        private void Print()
        {
            
            int x = 0;
            int y = 0;
            int teller = 0;
            foreach (Button btn in list)
            {
                btn.MouseHover += new EventHandler(this.btn_MouseHover);
                btn.MouseLeave += new EventHandler(this.btn_MouseLeav);


                btn.Size = new Size(this.Size.Width, this.Size.Height);
                if (list.Count == 2)
                {
                    if (teller == 1)
                    {
                        x += this.Size.Width / 2;
                        btn.Location = new Point(x, y);
                    }

                    btn.Size = new Size(this.Size.Width / 2, this.Size.Height / 2);

                }
                else if (list.Count > 2 && list.Count < 5)
                {
                    btn.Size = new Size(this.Size.Width / 2, this.Size.Height / 2);

                    if (teller == 2)
                    {
                        x = 0;
                        y += this.Size.Height / 2;
                        teller = 0;
                    }

                    btn.Location = new Point(x, y);
                    x += this.Size.Width / 2;
                }
                else if (list.Count >= 5)
                {
                    btn.Size = new Size(this.Size.Width / 3, this.Size.Height / 3);


                    if (teller == 3)
                    {
                        x = 0;
                        y += this.Size.Height / 3;
                        teller = 0;
                    }

                    btn.Location = new Point(x, y);
                    x += this.Size.Width / 3;
                }
                this.Controls.Add(btn);

                teller++;
            }
        }

        Form2 form2 = new Form2();

        private void btn_MouseHover(object sender, EventArgs e)
        {
            

            
            if(!form2.Visible)
            {
                form2 = new Form2();
                form2.Show();
                form2.Focus();
            }
            Button button1 = sender as Button;
            form2.Location = new Point(button1.Bottom);
            
        }
        private void btn_MouseLeav(object sender, EventArgs e)
        {
            Button button1 = sender as Button;
            button1.BackColor = Color.FromArgb(form2.alpha, form2.rood, form2.groen, form2.blauw);

            form2.Close();
            
            
        }
    }
}
