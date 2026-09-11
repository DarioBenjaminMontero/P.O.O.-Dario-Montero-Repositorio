using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, promedio;

            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            num3 = double.Parse(textBox3.Text);

            promedio = (num1 + num2 + num3)/3 ;
            if (promedio > 6)
            {
                label1.ForeColor = Color.Green;
                label1.Text = promedio.ToString();
            }
            else {
                label1.ForeColor = Color.Red;
                label1.Text = promedio.ToString();
            }
        }
    }
}
