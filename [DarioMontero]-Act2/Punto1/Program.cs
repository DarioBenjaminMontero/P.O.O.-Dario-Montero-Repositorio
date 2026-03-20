using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, suma, diferencia, producto, cociente;
            string linea;
            Console.Write("ingresa un numero: ");
            linea = Console.ReadLine();
            numero1 = int.Parse(linea);
            Console.WriteLine("ingresa el segundo numero: ");
            linea= Console.ReadLine();
            numero2 = int.Parse(linea);

            if (numero1 > numero2)
            {

                suma = numero1 + numero2;
                diferencia = numero1 - numero2;

                Console.WriteLine("la suma es: ");
                Console.WriteLine(suma);

                Console.WriteLine("la diferencia es: ");
                Console.WriteLine(diferencia);
            }
            else {
                producto = numero1 * numero2;
                cociente = numero1 / numero2;

                Console.WriteLine("el producto es: ");
                Console.WriteLine(producto);

                Console.WriteLine("el cociente es: ");
                Console.WriteLine(cociente);

            }


        }


        
    }
}
