using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Realizar un programa que acumule (sume) valores ingresados por teclado hasta
            //ingresar el 9999(no sumar dicho valor, indica que ha finalizado la carga).Imprimir el
            //valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.

            int suma, numero;
            string linea;
            suma = 0;



            do {
                Console.WriteLine("Escribe un numero, si es 9999 el programa acaba");
                linea = Console.ReadLine();
                numero = int.Parse(linea);
                if (numero != 9999)
                {
                    suma = suma + numero;

                }
                else {
                    Console.WriteLine("el programa acabó");
                    Console.WriteLine("la cantidad total sumada es de: ");
                    Console.WriteLine(suma);
                    if (suma > 0) {
                        Console.WriteLine("la suma es mayor a 0");
                    }
                    if (suma == 0) {
                        Console.WriteLine("la suma da 0");
                    }
                    if (suma < 0) {
                        Console.WriteLine("la suma de menos de 0");
                    
                    }
                }
            }
            while (numero != 9999);

            Console.ReadKey();
        }
    }
}
