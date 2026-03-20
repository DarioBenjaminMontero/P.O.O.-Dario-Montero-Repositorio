using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).

            int numero1, perimetro;
            string linea;
            Console.WriteLine("ingresa la medida de la cara del cuadrado: ");
            
            linea = Console.ReadLine();
            numero1 = int.Parse(linea);
            perimetro = numero1 / 4;
            Console.WriteLine(perimetro);
            

        }
    }
}
