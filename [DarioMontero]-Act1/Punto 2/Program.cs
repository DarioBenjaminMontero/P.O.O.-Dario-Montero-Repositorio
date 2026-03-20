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

            //2. Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.

            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int suma;
            int producto;
            string linea;
            Console.Write("Ingrese el primer numero: ");
            linea = Console.ReadLine();
            numero1 = int.Parse(linea);
            Console.WriteLine("Ingrese el segundo numero: ");
            linea = Console.ReadLine();
            numero2 = int.Parse(linea);
            Console.WriteLine("Ingrese el tercer numero: ");
            linea = Console.ReadLine();
            numero3 = int.Parse(linea);
            Console.WriteLine("Ingrese el cuarto numero: ");
            linea = Console.ReadLine();
            numero4 = int.Parse(linea);

            suma = numero1 + numero2;
            producto = numero3 * numero4;

            Console.WriteLine("la suma es: ");
            Console.WriteLine(suma);
            Console.WriteLine("El producto es: ");
            Console.WriteLine(producto);

            Console.ReadKey();



        }
    }
}
