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

            //Escribir un programa que pida ingresar la coordenada de un punto en el plano, es decir dos valores enteros x e y (distintos a cero).
            //Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0). 
            int x, y;
            string linea;
            Console.Write("escribe una coordenada x: ");
            linea = Console.ReadLine();
            x = int.Parse(linea);
            Console.Write("escribe una coordenada y: ");
            linea = Console.ReadLine();
            y = int.Parse(linea);

            if (x != 0 && y != 0) {

                if (x > 0 && y > 0) {
                    Console.Write("Cuadrante 1");
                }
                if (x < 0 && y > 0) {
                    Console.Write("Cuadrante 2");
                }
                if (x < 0 && y < 0) {
                    Console.Write("Cuadrante 3");
                }
                if (x > 0 && y < 0)
                {
                    Console.Write("Cuadrante 4");
                }


            }
            Console.ReadKey();
        }
    }
}
