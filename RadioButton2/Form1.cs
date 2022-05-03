using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                label2.Text = radioButton1.Text;
                button1.ForeColor = Color.White;
                button1.BackColor = Color.Black;  
            }

            else if (radioButton2.Checked == true)
            {
                label2.Text = radioButton2.Text;
                button1.ForeColor = Color.White;
                button1.BackColor = Color.Green;
            }

            else if (radioButton3.Checked == true)
            {
                label2.Text = radioButton3.Text;
                button1.ForeColor = Color.White;
                button1.BackColor = Color.DarkCyan;
            }

            else if (radioButton4.Checked == true)
            {
                label2.Text = radioButton4.Text;
                button1.ForeColor = Color.White;
                button1.BackColor = Color.DarkMagenta;
            }

            else if (radioButton5.Checked == true)
            {
                label2.Text = radioButton5.Text;
                button1.ForeColor = Color.White;
                button1.BackColor = Color.Gold;
                this.BackColor = Color.DarkSalmon;
            }


        }
    }
}
