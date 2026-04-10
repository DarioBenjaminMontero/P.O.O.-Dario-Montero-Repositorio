using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
    internal class Vector
    {
        /*Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
ordenado de menor a mayor y de mayor a menor.*/

        private int[] vector;
        private int posicionesMenorMayor, posicionesMayorMenor;

        public void cargar() {
            vector = new int[10];
            string linea;
            for (int i = 0; i < vector.Length; i++) {
                Console.WriteLine("Escribi un valor para la posicion " + i);
                linea = Console.ReadLine();
            vector[i] = int.Parse(linea);
            }
        }
        public void verificar() {
            for (int i = 0; i < vector.Length-1; i++) {
                if (vector[i] < vector[i + 1])
                {
                    posicionesMenorMayor++;
                }
                else if (vector[i] > vector[i + 1]) {
                    posicionesMayorMenor++;
                }
            
            }
        }

        public void Mostrar() {
            if (posicionesMenorMayor == 9)
            {
                Console.WriteLine("está ordenado de menor a mayor");
            }
            else if (posicionesMayorMenor == 9) {
                Console.WriteLine("esta ordenado de mayor a menor");
            }
        
        }


        static void Main(string[] args)
        {
            Vector Vector = new Vector();
            Vector.cargar();
            Vector.verificar();
            Vector.Mostrar();
            Console.ReadKey();


        }
    }
}
