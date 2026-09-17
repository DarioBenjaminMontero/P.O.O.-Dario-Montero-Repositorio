using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
            if (comboBox1.SelectedIndex == 1) { 
            checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = false;
            }
            if (comboBox1.SelectedIndex == 2) {
                checkBox1.Enabled = true;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
        }

        
    }
}
