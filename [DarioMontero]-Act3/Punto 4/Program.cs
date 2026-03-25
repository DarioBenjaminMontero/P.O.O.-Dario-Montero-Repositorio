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
            int num1, num2, num3;
            string linea;
            Console.WriteLine("ingresa el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("ingresa el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("ingresa el tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 < 10 || num2 < 10 || num3 < 10)
            {
                Console.WriteLine("Alguno de los numeros es menor a 10");
            }



        }
    }
}
