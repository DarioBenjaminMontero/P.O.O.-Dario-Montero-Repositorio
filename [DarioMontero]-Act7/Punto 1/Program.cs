using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Valores
    {/*Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
El valor acumulado de todos los elementos del vector.
El valor acumulado de los elementos del vector que sean mayores a 36.
Cantidad de valores mayores a 50.*/

        private int[] valores;
        private int sumavalortotal, cantValoresMayoresA50, sumaValoresMayoresA36;
        
        public void Cargar() {
            valores = new int[8];
            string linea;
            int i;
            for (i = 0; i < 8; i++) {
                Console.WriteLine("Ingresa un valor para la posicion " + i + " del vector");
                linea = Console.ReadLine();
                valores[i] = int.Parse(linea);
            }

        }
        public void ValorAcumulado() {
             
            for (int f = 0; f < 8; f++) {
            sumavalortotal += valores[f];
            }
        
        }
        public void ValorAcumuladoMayorA50Y36() {
            sumaValoresMayoresA36 = 0;
            cantValoresMayoresA50 = 0;
            for (int i = 0; i < 8; i++) {
                 
                if (valores[i] >= 36) {
                    if (valores[i] > 50)
                    {
                        cantValoresMayoresA50 ++;
                    }
                    sumaValoresMayoresA36 += valores[i];

                }
            }
        }
        public void ImprimirValores()
        {
            Console.WriteLine("el valor acumulado de todos los valores del vector es de: ");
            Console.WriteLine(sumavalortotal);
            Console.WriteLine("el valor acumulado de todos los valores del vector que son mayores a 36 es de: ");
            Console.WriteLine(sumaValoresMayoresA36);
            Console.WriteLine("la cantidad total de valores que son mayores a 50 en este vector es de: ");
            Console.WriteLine(cantValoresMayoresA50);
       }
        static void Main(string[] args)
        {
            Valores valores = new Valores();
            valores.Cargar();
            valores.ValorAcumulado();
            valores.ValorAcumuladoMayorA50Y36();
            valores.ImprimirValores();
            Console.ReadKey();
        }
    }
}
