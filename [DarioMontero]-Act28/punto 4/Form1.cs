using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numero;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            if (timer1.Enabled == false) { 
            timer1.Enabled = true;
            }
            numero++;
        }
        int tiempo = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo--;
            if (tiempo == 0) { 
            button1.Enabled = false;
                MessageBox.Show("NUMERO DE CLICKS: " + numero);
            }
        }
    }
}
