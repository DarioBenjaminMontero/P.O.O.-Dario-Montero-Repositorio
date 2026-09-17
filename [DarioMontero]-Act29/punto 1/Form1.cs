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
        /*Consigna: Disponer tres CheckBox con productos y precios fijos. Un Button
"Calcular Total" debe evaluar los controles seleccionados (Checked == true), sumar
sus costos y mostrar el monto final en un Label.*/
        private void button1_Click(object sender, EventArgs e)
        {
            double total =0;
            if (checkBox1.Checked == true) {
                total += 50;
            }
            if (checkBox2.Checked == true)
            {
                total += 20;
            }
            if (checkBox3.Checked == true)
            {
                total += 200;
            }

            label1.Text = "El precio total es: " + total.ToString();
        }
    }
}
