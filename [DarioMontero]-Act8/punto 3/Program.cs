using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class Program
    {/*3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
(el orden lo pueden elegir ustedes).*/
        private int[] vector;


        public void cargar() {
            int numero;
            string linea;
            Console.WriteLine("¿Cuantos espacios tendrá tu vector?");
            linea = Console.ReadLine();
            numero = int.Parse(linea);
            vector = new int[numero];
            for (int i = 0; i < vector.Length; i++) {
                Console.WriteLine("Escribe un numero para la posicion " + i +" del vector");
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
            }
        }

        public void comparar() {
            int aux;
            for (int k = 0; k < vector.Length; k++) {
            
                for(int f = 0; f < vector.Length -1 -k; f++) {
                    if (vector[f] > vector[f + 1]) {
                        aux = vector[f+1];
                        vector[f + 1] = vector[f];
                        vector[f] = aux;
                    }
                }
            }
        }
        public void mostrar() {
            Console.WriteLine("El orden de menor a mayor de los numeros es de: ");
            for (int i = 0; i < vector.Length; i++) {
                Console.WriteLine(vector[i]);
            }

        }
        static void Main(string[] args)
        {
            Program programa = new Program();
            programa.cargar();
            programa.comparar();
            programa.mostrar();
            Console.ReadKey();

        }
    }
}
