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
            //3. Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.

            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int suma;
            float promedio;
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

            suma = numero1 + numero2 + numero3 + numero4;

            promedio = (float)suma / 4;
            Console.WriteLine("la suma es: ");
            Console.WriteLine(suma);

            Console.WriteLine("El promedio es: ");
            Console.WriteLine(promedio);

            Console.ReadKey();
        }

    }
    
}
