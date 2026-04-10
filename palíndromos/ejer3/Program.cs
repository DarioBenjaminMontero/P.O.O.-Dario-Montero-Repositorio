using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribi una palabra o frase: ");
            string frase = Console.ReadLine();

            string limpia = "";
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                    limpia = limpia + char.ToLower(frase[i]);
            }

            string invertida = "";
            for (int i = limpia.Length - 1; i >= 0; i--)
            {
                invertida = invertida + limpia[i];
            }

            if (limpia == invertida)
                Console.WriteLine("¡Es un palíndromo!");
            else
                Console.WriteLine("No es un palíndromo.");
        }
    }
}
