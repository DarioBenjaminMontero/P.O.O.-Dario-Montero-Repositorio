using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.
            //(No se ingresan valores por teclado)
            int x, suma;
            x = 1;
            suma = 0;
            while (x <= 25) {
                suma = suma + 11;
                Console.WriteLine(suma);
                x = x+ 1;
            
            }

        }
    }
}
