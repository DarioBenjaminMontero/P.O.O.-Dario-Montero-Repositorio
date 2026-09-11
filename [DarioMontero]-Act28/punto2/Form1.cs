using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double numero;
            numero = double.Parse(textBox1.Text);

            double fahrenheit = (numero * 9 / 5) + 32;
            label1.Text = fahrenheit.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double fahrenheit = double.Parse(textBox1.Text);
            double celsius = (fahrenheit - 32) * 5 / 9;
            label1.Text = celsius.ToString();
        }
    }
}
