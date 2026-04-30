using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class matriz
    {

        /*Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
componentes por columna (es decir primero ingresar toda la primer
columna, luego la segunda columna y así sucesivamente)
Imprimir luego la matriz.*/

        private int[,] mat;
        
        public void cargar() {
            string linea;
            mat = new int[2, 5];
            for (int c = 0; c <5; c++) {
                for (int f = 0; f < 2; f++) {
                    Console.WriteLine("ingresa el valor numero " + f + " de la columna nuemero " + c);
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }
        public void mostrar() {
            for (int f = 0; f < mat.GetLength(0); f++) {
                for (int c = 0; c < mat.GetLength(1); c++) {
                    Console.Write(mat[f, c] + " ");
                    
                }
                 Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            matriz mat = new matriz();
            mat.cargar();
            mat.mostrar();
            Console.ReadKey();

        }
    }
}
