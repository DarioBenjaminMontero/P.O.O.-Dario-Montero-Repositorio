using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class Puntos
    {
        private int[] puntos;
        private int suma, promedio;

        public void cargarPuntos()
        {
            puntos = new int[6];
            string linea;
            for (int i = 0; i < 6; i++) {
                Console.WriteLine("carga los puntos en el espacio numero " + i);
                linea= Console.ReadLine();
                puntos[i] = int.Parse(linea);
            }
        }


        public void masAltaYbaja() {
        
        
        }
        public void SumaYPromedio() {
            for (int i = 0; i < 6; i++) {
                suma += puntos[i];
            }
            promedio = suma / 6;
        }
        


        static void Main(string[] args)
        {


        }
    }
}
