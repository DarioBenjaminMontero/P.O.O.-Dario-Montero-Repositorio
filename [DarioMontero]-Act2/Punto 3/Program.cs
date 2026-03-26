using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando
            //si el número tiene uno o dos dígitos.(Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)
            string linea;
            int cantidaddigitos, numero;

            Console.WriteLine("escribe un numero pa:");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            if (numero > 99)
            {
                Console.Write("escribe un numero de 2 digitos pa");
            }
            else {
                if (numero <= 9)
                {
                    if (numero >= 0) {
                        Console.WriteLine("Escribiste un numero de una cifra");
                    }
                    

                }
                else {
                    Console.WriteLine("Escribiste un numero de dos cifras");
                }
            
            }


            Console.ReadKey();

        }
    }
}
