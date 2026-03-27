using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
a) La cantidad de valores ingresados negativos.
b) La cantidad de valores ingresados positivos.
c) La cantidad de múltiplos de 15.
d) El valor acumulado de los números ingresados que son pares.*/

            int i, valor, cantPositivos, cantNegativos, cantMultiplos, sumaTotal;
            string linea;
            valor = 0;
            cantPositivos = 0;
            cantNegativos=0;
            cantMultiplos = 0;
            sumaTotal = 0;

            for (i = 0; i < 10; i++) {
            
                Console.WriteLine("Ingresa el valor numero " +i);
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor >= 0)
                {
                    cantPositivos++;
                }
                else if (valor < 0) {
                    cantNegativos++;
                }

                if (valor % 15 == 0) {
                    cantMultiplos++;
                }
                if (valor % 2 == 0) {
                sumaTotal = sumaTotal + valor;
                }


            
            
            }
            Console.WriteLine("la cantidad de positivos que escribiste contando 0's es de: " + cantPositivos);
            Console.WriteLine("la cantidad de negativos que escribiste es de: " + cantNegativos);
            Console.WriteLine("la cantidad de multiplos de 15 que escribiste es de: " + cantMultiplos);
            Console.WriteLine("la suma de todos los numeros pares que escribiste es de: " + sumaTotal);

            Console.ReadKey();
        }

    }
}
