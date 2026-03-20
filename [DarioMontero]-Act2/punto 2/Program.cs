using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float numero1, numero2, numero3, numero4, numero5, numero6, promedio, suma;
            string linea;

            Console.WriteLine("La nota del alumno en matematica es");
            linea = Console.ReadLine();
            numero1 = float.Parse(linea);
            Console.WriteLine("La nota del alumno en lengua es");
            linea = Console.ReadLine();
            numero2 = float.Parse(linea);
            Console.WriteLine("La nota del alumno en fisica es");
            linea = Console.ReadLine();
            numero3 = float.Parse(linea);
            Console.WriteLine("La nota del alumno en computacion es");
            linea = Console.ReadLine();
            numero4 = float.Parse(linea);
            Console.WriteLine("La nota del alumno en historia es");
            linea = Console.ReadLine();
            numero5 = float.Parse(linea);
            Console.WriteLine("La nota del alumno en geografia es");
            linea = Console.ReadLine();
            numero6 = float.Parse(linea);

            suma = numero1 + numero2 + numero3 + numero4 + numero5 + numero6;
            promedio = suma / 6;

            Console.WriteLine("el promedio de notas que tiene el alumno es: ");
            Console.WriteLine(promedio);

            if (promedio >= 7) {
                Console.WriteLine("el alumno fue promocionado");
            }

        }
    }
}
