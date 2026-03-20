using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //4.Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.

            int numero1;
            int numero2;
            int numero3;
            string linea;
            Console.Write("Ingrese el precio del articulo: ");
            linea = Console.ReadLine();
            numero1 = int.Parse(linea);
            Console.WriteLine("Ingrese la cantidad que lleva el cliente: ");
            linea = Console.ReadLine();
            numero2 = int.Parse(linea);

            if (numero1 > 0 && numero2 > 0)
            {
                numero3 = numero1 * numero2;
                Console.WriteLine("lo que debe abonar es: ");
                Console.WriteLine(numero3);
                
            }
            Console.ReadKey();
        }
        
    }
}
