using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palíndromos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribi una palabra: ");
            string palabra = Console.ReadLine();

            string invertida = "";

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                invertida = invertida + palabra[i];
            }

            Console.WriteLine("Palabra al revés: " + invertida);
        }
    }
}
