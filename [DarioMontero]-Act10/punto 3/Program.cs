using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class vertices
    {/*Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
etc.)*/
        private int[,] mat;
        private int filas, columnas;
        public void cargar() {
            string linea;
            
            Console.WriteLine("Por favor escribe las filas que va a tener la matriz");
            linea = Console.ReadLine();
            filas = int.Parse(linea);
            Console.WriteLine("Por favor escribe las columnas que va a tener la matriz");
            linea = Console.ReadLine();
            columnas = int.Parse(linea);
            mat = new int[filas, columnas];
            Console.WriteLine();
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.WriteLine("por favor, escribi el valor que va tener la matriz en la fila " + f + " y en la columna " + c);
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }
        public void mostrar() {
            Console.WriteLine("Valor de la matriz en la posicion 0,0");
            Console.WriteLine(mat[0, 0]);
            Console.WriteLine("Valor de la matriz en la posicion " + (filas-1) + ",0");
            Console.WriteLine(mat[filas-1, 0]);
            Console.WriteLine("Valor de la matriz en la posicion 0, " +(columnas-1));
            Console.WriteLine(mat[0, columnas-1]);
            Console.WriteLine("Valor de la matriz en la posicion " + (filas-1) + "," + (columnas-1));
            Console.WriteLine(mat[filas-1, columnas-1]);
        }


        static void Main(string[] args)
        {
            vertices ver = new vertices();
            ver.cargar();
            ver.mostrar();
            Console.ReadKey();
        }
    }
}
