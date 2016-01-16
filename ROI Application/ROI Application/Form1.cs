using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ROI_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double result = 0.00;

                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox4.Text);

                result = ((c - (b + a)) / (b + a)) * 100;

                double res = Math.Round(result,2);
                
                label5.Text = res.ToString() + "%";

                if (res < 0.00)
                {
                    label7.Text = "Loss of " + ((c - (b + a))).ToString();
                }
                else if (res > 0.00)
                {
                    label7.Text = "Profit of " + ((c - (b + a))).ToString();
                }
                else
                    label7.Text = "Break Even";
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Supply a number");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                label5.Text = "";
                label7.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            label5.Text = "";
            label7.Text = "";
        }
              
    }
}
