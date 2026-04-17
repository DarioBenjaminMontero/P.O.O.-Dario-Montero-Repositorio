using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class Program
    { /*4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
sus nombres y puntajes promedio obtenidos (de 1 a 10).
Cargar sus datos en vectores paralelos, mostrar docente con calificación más
alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
desaprobaron (tomando como base que se aprueba con una nota mayor o igual
a 6)*/

        private string[] docentes;
        private float[] puntuaciones;

        public void cargar(){
            docentes = new string[6];
            puntuaciones = new float[6];
            string linea;

            for (int i = 0; i < puntuaciones.Length; i++) {

                Console.WriteLine("escribe el nombre de un docente");
                linea = Console.ReadLine();
                docentes[i] = linea;
                Console.WriteLine("Ahora escribi una puntuacion de 1 a 10");
                linea = Console.ReadLine();
                puntuaciones[i] = int.Parse(linea);
                if (puntuaciones[i] < 1 || puntuaciones[i] > 10) {
                    Console.WriteLine("Escribe una puntuacion de 1 a 10, intentalo de nuevo");
                    i--;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
