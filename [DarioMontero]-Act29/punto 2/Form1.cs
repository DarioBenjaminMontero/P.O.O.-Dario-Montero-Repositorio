using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numero1, numero2, numero3;

        private void button1_Click(object sender, EventArgs e)
        {
            numero1 = (int)numericUpDown1.Value;
            numero2 = (int)numericUpDown2.Value;
            numero3 = (int)numericUpDown3.Value;

            BackColor = Color.FromArgb(numero1, numero2, numero3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 250;
            numericUpDown1.Minimum = 0;
            numericUpDown2.Maximum = 250;
            numericUpDown2.Minimum = 0;
            numericUpDown3.Maximum = 250;
            numericUpDown3.Minimum = 0;
            numero1 = (int)numericUpDown1.Value;
            numero2 = (int)numericUpDown2.Value;
            numero3 = (int)numericUpDown3.Value;
            BackColor = Color.FromArgb(numero1, numero2, numero3);
        }
        
        
    }
}
