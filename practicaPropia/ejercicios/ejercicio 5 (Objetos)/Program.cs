using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5__Objetos_
{

    internal class Jugador {

        public string nombre;
        public int vida;
        public int nivel;

    }

    internal class Program
    {
        public List<Jugador> listaJugadores = new List<Jugador>();
        private int mayor;
        private int mayorVida;
        private float suma;
        private float promedio;
        public void ListaDeJugadores(){
            string linea;
            int numero;
            string continuar ="si";
            do
            {
                Jugador jugador = new Jugador();
                Console.WriteLine("Escribe el nombre de un jugador");
                jugador.nombre = Console.ReadLine();
                Console.WriteLine("ahora su vida");
                jugador.vida = int.Parse(Console.ReadLine());
                Console.WriteLine("por ultimo, su nivel");
                jugador.nivel = int.Parse(Console.ReadLine());

                listaJugadores.Add(jugador);

                Console.WriteLine("desea continuar? escribe si / no");
                continuar = Console.ReadLine();

            } while (continuar == "si");
        }
        public void encontrarMayorNivel() {
            mayor = listaJugadores[0].nivel;

            foreach (Jugador jugadores in listaJugadores) {
                if (jugadores.nivel > mayor) {
                mayor = jugadores.nivel;
                }
            }
        }
        public void promedioNiveles()
        {
            suma = 0;
            foreach (Jugador jugadores in listaJugadores)
            {
                suma += jugadores.nivel;
            }
            promedio = suma / listaJugadores.Count;
        }
        public void encontrarMayorVida()
        {
            mayorVida = listaJugadores[0].vida;

            foreach (Jugador jugadores in listaJugadores)
            {
                if (jugadores.vida > mayorVida)
                {
                    mayorVida = jugadores.vida;
                }
            }
        }
        public void mostrar() {
            foreach (Jugador jugadores in listaJugadores) {
                if (jugadores.nivel == mayor) {
                    Console.WriteLine("el jugador " + jugadores.nombre + " tiene el nivel maximo de: " + mayor);
                }
            }
            foreach (Jugador jugadores in listaJugadores)
            {
                if (jugadores.vida == mayorVida)
                {
                    Console.WriteLine("el jugador " + jugadores.nombre + " tiene la vida maxima de: " + mayorVida);
                }
            }
            Console.WriteLine("el promedio es: " + promedio);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ListaDeJugadores();
            program.encontrarMayorNivel();
            program.promedioNiveles();
            program.encontrarMayorVida();
            program.mostrar();
            Console.ReadKey();

        }
    }
}
