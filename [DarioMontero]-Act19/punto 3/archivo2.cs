using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    partial class JuegoArcade
    {
        private string nombre;
        private int puntaje;
        public void partida() {
            Console.WriteLine("escribe el nombre del jugador");
            nombre = Console.ReadLine();
            Console.WriteLine("escribe el puntaje que consiguio");
            puntaje = int.Parse(Console.ReadLine());

            if (puntaje > PuntajeMaximo) {
                Console.WriteLine("el jugador " + nombre + " superó el record de " + PuntajeMaximo + " con " + puntaje + " puntos");
            }
        }

    }
}
