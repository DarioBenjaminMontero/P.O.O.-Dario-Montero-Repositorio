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
            /*Realizar un programa que lea los lados de n triángulos, e informar:
a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
b) Cantidad de triángulos de cada tipo.
c) Tipo de triángulo que posee menor cantidad.*/

            string linea, textoTriangulo;
            int lado1, lado2, lado3, i, cantTriangulos, cantIsosceles, cantEquilateros, cantEscalenos;
            lado1 = 0;
            lado2 = 0;
            lado3 = 0;
            textoTriangulo = "";
            cantEscalenos = 0;
            cantIsosceles = 0;
            cantEquilateros =0;
            
            
            Console.WriteLine("cuantos triangulos vas a escribir...?");
            linea = Console.ReadLine();
            cantTriangulos = int.Parse(linea);

            for (i = 1; i <= cantTriangulos; i++) {

                Console.WriteLine("Este es el triangulo numero " + i);
                Console.WriteLine("escribe la medida del Primer lado");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);
                Console.WriteLine("escribe la medida del segundo lado");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);
                Console.WriteLine("escribe la medida del tercer lado");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);
                if (lado1 == lado2 && lado2 == lado3)
                {
                    textoTriangulo += "El triangulo numero " + i + " es un equilatero. \n";
                    cantEquilateros++;
                }
                else if ((lado1 == lado2 && lado2 != lado3) || (lado1 != lado2 && lado2 == lado3))
                {
                    textoTriangulo += "El triangulo numero " + i + " es un isosceles. \n";
                    cantIsosceles++;
                }
                else if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1) {
                    textoTriangulo += "El triangulo numero " + i + " es un escaleno. \n";
                    cantEscalenos++;
                }
            }
            Console.WriteLine("Los datos de todos los triangulos son: ");
            Console.WriteLine(textoTriangulo);
            Console.WriteLine("la cantidad de triangulos equilateros es de: " + cantEquilateros);
            Console.WriteLine("la cantidad de triangulos isosceles es de: " + cantIsosceles);
            Console.WriteLine("la cantidad de triangulos escalenos es de: " + cantEscalenos);
            if (cantEquilateros < cantIsosceles && cantEquilateros < cantEscalenos)
            {
                Console.WriteLine("Los triangulos con menor cantidad son los equilateros");
            }
            else if (cantIsosceles < cantEquilateros && cantIsosceles < cantEscalenos)
            {
                Console.WriteLine("Los triangulos con menor cantidad son los isosceles");
            }
            else if (cantEscalenos < cantEquilateros && cantEscalenos < cantIsosceles)
            {
                Console.WriteLine("Los triangulos con menor cantidad son los escalenos");
            }
            Console.ReadKey();
        }
    }
}
