using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Calculator : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public Calculator()      
        {
            n2 = false;
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;

        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
     
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;

        }

        private void button31_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;

            }
            if (D == "*")
            {
                res = dn1 * dn2;
            }
            if (D == "/")
            {
                res = dn1 / dn2;
            }
            D = "=";
            n2 = true;
            textBox1.Text = res.ToString();

        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";

        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";

        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
             
            if (D == "+")
                label2.Text = "+" + textBox1.Text;
            if (D == "-")
                label2.Text = "-" + textBox1.Text;
            if (D == "*")
                label2.Text = "*" + textBox1.Text;
            if (D == "/")
                label2.Text = "/" + textBox1.Text;
            if (D == "=")
                label2.Text = "";


            else
                label2.Text = D + textBox1.Text;


        }
    }
    }

    



