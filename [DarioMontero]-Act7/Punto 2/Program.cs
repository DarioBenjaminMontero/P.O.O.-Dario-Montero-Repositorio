using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Valores
    {
        /*Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
tercer vector del mismo tamaño. Sumar componente a componente.*/
        private int[] vector1;
        private int[] vector2;
        private int[] vector3;

        public void Carga() {
            vector1 = new int[4];
            vector2 = new int[4];
            vector3 = new int[4];
            string linea;
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("Escribe un valor para el vector 1 en la posicion " + i);
                linea = Console.ReadLine();
                vector1[i] = int.Parse(linea);
                Console.WriteLine("Escribe un valor para el vector 2 en la posicion " + i);
                linea = Console.ReadLine();
                vector2[i] = int.Parse(linea);
            }
        }
        public void sumarValores() {

            for (int i = 0; i < 4; i++) { 
                vector3[i] = vector1[i] + vector2[i];
            }

        }
        public void mostrarValores() {

            Console.WriteLine("los valores del vector son: ");
            for (int i = 0; i < 4; i++) {

                Console.WriteLine(vector3[i]);
            }
            
        }
        static void Main(string[] args)
        {
            Valores valores = new Valores();
            valores.Carga();
            valores.sumarValores();
            valores.mostrarValores();
            Console.ReadKey();

        }
    }
}
