using System;

namespace Ej05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;

            while (true)
            {
                Console.Write("Ingrese un nombre: ");
                s = Console.ReadLine();

                if (s != "")
                {
                    char primera = s[0];
                    int contador = 0;

                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == primera)
                        {
                            contador++;
                        }
                    }

                    Console.WriteLine("Primera letra: " + primera);
                    Console.WriteLine("Se repite: " + contador);
                }


            }
        }
    }
}