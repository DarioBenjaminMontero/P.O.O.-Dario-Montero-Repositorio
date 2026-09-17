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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            DateTime ahora = DateTime.Now;

            int resultado = ahora.Year - fecha.Year;

            if (ahora.Month < fecha.Month ||(ahora.Month == fecha.Month && ahora.Day < fecha.Day))
            {
                resultado--;
            }
            label1.Text = resultado.ToString();
        }
    }
}
