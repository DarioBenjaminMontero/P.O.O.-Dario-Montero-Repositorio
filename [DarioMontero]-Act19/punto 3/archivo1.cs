using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    partial class JuegoArcade
    {
        private string nombreJuego;
        private int puntajeMaximo, nivelDificultad;

        public string NombreJuego
        {
            set { nombreJuego = value; }
            get { return nombreJuego; }
        }
        public int PuntajeMaximo
        {
            set { puntajeMaximo = value; }
            get { return puntajeMaximo; }
        }
        public int NivelDificultad
        {
            set { nivelDificultad = value; }
            get { return nivelDificultad; }
        }

        public JuegoArcade() {
            
            Console.WriteLine("ingrese el nombre del juego");
            nombreJuego = Console.ReadLine();
            Console.WriteLine("ingrese el puntaje maximo");
            puntajeMaximo = int.Parse(Console.ReadLine());
            Console.WriteLine("por ultimo, su nivel de dificultad (del 1 al 5)");
            while (nivelDificultad > 5 || nivelDificultad < 1) { 
            nivelDificultad = int.Parse(Console.ReadLine());
                if (nivelDificultad > 5 || nivelDificultad < 1) {
                    Console.WriteLine("la restriccion es que solo es del 1 al 5");
                }
            }

        }
        
    }
}
