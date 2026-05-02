using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    internal class intercambio
    {
        /*2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
primer fila con la segunda. Imprimir luego la matriz.*/
        private int[,] mat;

        public void cargar() {
            string linea;
            int filas, columnas;
            Console.WriteLine("Por favor escribe las filas que va a tener la matriz");
            linea = Console.ReadLine();
            filas = int.Parse(linea);
            Console.WriteLine("Por favor escribe las columnas que va a tener la matriz");
            linea = Console.ReadLine();
            columnas = int.Parse(linea);
            mat = new int[filas, columnas];
            Console.WriteLine();
            for (int f = 0; f < mat.GetLength(0); f++) {
                for (int c = 0; c < mat.GetLength(1); c++) {
                    Console.WriteLine("por favor, escribi el valor que va tener la matriz en la fila " + f + " y en la columna " + c);
                    linea = Console.ReadLine();
                    mat[f,c] = int.Parse(linea);
                }
            }
        }
        public void intercambiar() {
            int aux;
            if (mat.GetLength(0) < 2) {
                return;
             }
            
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (f == 0) {
                        aux = mat[f, c];
                        mat[f, c] = mat[f + 1, c];
                        mat[f + 1, c] = aux;
                    }
                }
            }
        }

        public void mostrar() {
            Console.WriteLine("fila 1 y 2 intercambiadas: ");
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            intercambio inter = new intercambio();
            inter.cargar();
            inter.intercambiar();
            inter.mostrar();
            Console.ReadKey();
        }
    }
}
