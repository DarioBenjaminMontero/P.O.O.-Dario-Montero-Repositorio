using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    internal class matrizIrregular
    {
        /*2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
(crearla sin la intervención del operador)
Realizar la carga por teclado e imprimir posteriormente.*/


        private int[][] irregular;

        public void creacion() {
            irregular = new int[5][];
            for (int i = 0; i < irregular.GetLength(0); i++) {
                irregular[i] = new int[i+1];
            }
        }
        public void cargar() {
            string linea;
            for (int i = 0; i < irregular.GetLength(0); i++) {
                for (int f = 0; f < irregular[i].GetLength(1); i++) {
                    Console.WriteLine("escribe el valor de la fila " + (i + 1) + " en la columna " + (f+1)); 
                    linea = Console.ReadLine();
                    irregular[i][f] = int.Parse(linea);
                }
            }
        }
        public void imprimir()
        {
            for (int i = 0; i < irregular.GetLength(0); i++)
            {
                for (int f = 0; f < irregular[i].GetLength(1); i++)
                {
                    Console.Write(irregular[i][f] + "  ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            matrizIrregular mat = new matrizIrregular();
            mat.creacion();
            mat.cargar();
            mat.imprimir();
            Console.ReadKey(); 
        }
    }
}
