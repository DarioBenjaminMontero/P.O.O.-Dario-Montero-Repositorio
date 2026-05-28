using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4__Objetos_
{

    class Jugador {

        public string nombre;
        public int vida;
        public int nivel;
    }
    internal class Programa
    {


        static void Main(string[] args)
        {
            Jugador jugador = new Jugador();
            jugador.nombre = "benja";
            jugador.vida = 100;
            jugador.nivel = 67;
            Jugador jugador2 = new Jugador();
            jugador2.nombre = "emiliano";
            jugador2.vida = 100;
            jugador2.nivel = 100;
            Jugador jugador3 = new Jugador();
            jugador3.nombre = "santi";
            jugador3.vida = 100;
            jugador3.nivel = 89;

            Console.WriteLine("Jugador 1: " + jugador.nombre);
            Console.WriteLine("Vida: " + jugador.vida);
            Console.WriteLine("Nivel: " + jugador.nivel);

            Console.WriteLine();

            Console.WriteLine("Jugador 2: " + jugador2.nombre);
            Console.WriteLine("Vida: " + jugador2.vida);
            Console.WriteLine("Nivel: " + jugador2.nivel);

            Console.WriteLine();

            Console.WriteLine("Jugador 3: " + jugador3.nombre);
            Console.WriteLine("Vida: " + jugador3.vida);
            Console.WriteLine("Nivel: " + jugador3.nivel);


        }
    }
}
