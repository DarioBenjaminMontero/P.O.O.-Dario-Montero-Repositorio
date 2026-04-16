using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraynumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;

            while (true)
            {
                int[] x = { 1, 2, 31, 40, 5 };

                Console.WriteLine("1. Suma total");
                Console.WriteLine("2. Promedio ");
                Console.WriteLine("3. Cuanto pares");
                Console.WriteLine("4. Cuantos mayores 10");
                Console.WriteLine("5. Salir");
                tecla = Console.ReadKey();
                if (tecla.KeyChar == '1')
                {

                }
                if (tecla.Key == ConsoleKey.D1)
                {

                }

                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        return;
                }
            }
        }
    }
}
