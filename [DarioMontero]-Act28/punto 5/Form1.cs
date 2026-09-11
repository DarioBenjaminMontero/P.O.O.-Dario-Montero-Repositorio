using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace punto_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-LL6T_PHKDosud3-hUwEUQjnaUpzzuuXkvPFgQB6wzA&s=10";

            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1FXjHxBjqyt1Gx6U-OCBHeA6oprbHYKwvF_3RZVpH7Q&s";

            }
            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTUVbAzWqGHoj25Ne5xW7sp81_b4292wmNoeC1385zipA&s=10";

            }
        }
    }
}
