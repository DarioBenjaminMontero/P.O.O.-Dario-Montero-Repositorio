using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Escribi una frase: ");
            string frase = Console.ReadLine();

            int contador = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                char min = char.ToLower(frase[i]);

                if (min == 'a' || min == 'e' || min == 'i' || min == 'o' || min == 'u')
                    contador = contador + 1;
            }

            Console.WriteLine("Total de vocales: " + contador);
        }
    }
}
