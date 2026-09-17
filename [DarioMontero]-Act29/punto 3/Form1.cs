using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            button1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                button1.Enabled = true;
            }
            else { 
            button1.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox2.Text == "admin123")
                {
                    label3.Text = "Muy bien pibe, podes pasar";
                }
                else
                {
                    label3.Text = "Muy mal pibe, no podes pasar.";
                }
            }
            else {
                label3.Text = "Falta el usuario o la contraseña bobi";
            }
        }

        
    }
}
