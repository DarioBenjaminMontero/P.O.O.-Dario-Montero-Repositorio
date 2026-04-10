using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Punto_3
{
    internal class Puntos
    {

        /*Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
un videojuego. El programa debe:
 Mostrar la puntuación más alta y la más baja.
 Calcular el promedio de puntuación.
 Contar cuántas veces superó los 500 puntos.*/
        private int[] puntos;
        private int suma, promedio, max, min,numero, masDe500;

        public void cargarPuntos()
        {
            puntos = new int[6];
            string linea;
            for (int i = 0; i < 6; i++) {
                Console.WriteLine("carga los puntos en el espacio numero " + i);
                linea= Console.ReadLine();
                puntos[i] = int.Parse(linea);
            }
        }


        public void masAltaYbajaYMasDe500() {
            max = puntos[0];
            
            min = puntos[0];
            for (int i = 0; i < 6; i++) {
                numero = puntos[i];

                if (numero < min) {
                min = numero;
                }
                if (numero > max) {
                
                max = numero;
                }
                if (numero > 500) {

                    masDe500++;
                }
            
            }
        
        }
        public void SumaYPromedio() {
            for (int i = 0; i < 6; i++) {
                suma += puntos[i];
            }
            promedio = suma / 6;
        }

        public void Mostrar() {
            Console.WriteLine("El valor mas alto es: ");
            Console.WriteLine(max);
            Console.WriteLine("El mas bajo es: ");
            Console.WriteLine(min);
            Console.WriteLine("La cantidad de veces que el puntaje sobrepasó los 500 puntos es de: ");
            Console.WriteLine(masDe500);
            Console.WriteLine("la suma de todos los puntajes es de: ");
            Console.WriteLine(suma);
            Console.WriteLine("el promedio de los puntajes es de: ");
            Console.WriteLine(promedio);
        
        }


        static void Main(string[] args)
        {
            Puntos puntos = new Puntos();
            puntos.cargarPuntos(); 
            puntos.masAltaYbajaYMasDe500();
            puntos.SumaYPromedio();
            puntos.Mostrar();
            Console.ReadKey();

        }
    }
}
