using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JuegoArcade juego = new JuegoArcade();
            juego.partida();
            juego.partida();
            juego.partida();
            juego.partida();
            Console.ReadKey();
        }
    }
}
