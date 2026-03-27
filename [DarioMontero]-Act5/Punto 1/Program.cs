using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
 muestre la tabla de multiplicar del mismo (los primeros 13 términos)
 Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el
 39.*/
            int i, valor;
            string linea;
            Console.WriteLine("escribe un valor del uno al diez");
            linea = Console.ReadLine();
            valor = int.Parse(linea);
            for (i = 1; i <= 13; i++) {
                Console.WriteLine(valor * i);
            }

            Console.ReadKey();
        }
    }
}
