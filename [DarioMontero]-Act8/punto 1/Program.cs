using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    internal class Elementos
    {
        private int[] vector;
        private int min;
        public void Cargar() {
            string linea;
            Console.WriteLine("cuantos elementos vas a colocar en este vector?");
            linea = Console.ReadLine();
            string linea2;
            int numero = int.Parse(linea);
            vector = new int[numero];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("coloca el numero en la posicion " + i);
                linea2 = Console.ReadLine();
                vector[i] = int.Parse(linea2);
                if (i == 0)
                {
                    min = vector[i];
                    Console.WriteLine("ahora el numero menor es " + vector[i]);
                }
                else if (vector[i] < min)
                {
                    min = vector[i];
                    Console.WriteLine("ahora el menor es " + min);
                }
                else if (vector[i] == min)
                {
                    Console.WriteLine("el numero se repitio");
                }
            }
        }
        static void Main(string[] args)
        {
            Elementos elemento = new Elementos();
            elemento.Cargar();
            Console.ReadKey();
        }
    }
}
