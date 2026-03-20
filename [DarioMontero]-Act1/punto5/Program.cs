using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //5. Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo (La circunferencia se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).

            
            float numero1, circunferencia, area;
            string linea;
            double pi = Math.PI;
            Console.WriteLine("ingresa el radio del circulo: ");
            linea = Console.ReadLine();
            numero1 = float.Parse(linea);
            circunferencia = numero1 * 2 * (float)pi;
            Console.WriteLine("La circunferencia es: ");
            Console.WriteLine(circunferencia);
            area = (float)(pi * Math.Pow(numero1, 2));
            Console.WriteLine("el area es: ");
            Console.WriteLine(area);
            Console.ReadKey();

        }
    }
}
