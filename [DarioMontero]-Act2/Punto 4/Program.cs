using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.
            float numero1, numero2, numero3;
            string linea;
            Console.WriteLine("Ingresa 3 numeros: ");
            linea=Console.ReadLine();
            numero1= int.Parse(linea);
            linea=Console.ReadLine();
            numero2 = int.Parse(linea);
            linea =Console.ReadLine();
            numero3 = int.Parse(linea);


            if (numero1 > numero2)
            {

                if (numero1 > numero3)
                {
                    Console.WriteLine(numero1);
                }
                else
                {
                    if (numero3 > numero2)
                    {
                        Console.WriteLine(numero3);
                    }
                    else
                    {
                        Console.WriteLine(numero2);
                    }
                }
            }
            else {
                if (numero2 > numero3)
                {
                    Console.WriteLine(numero2);
                }
                else {
                    Console.WriteLine(numero3);
                }
            
            }
            Console.ReadKey();
        }
    }
}
