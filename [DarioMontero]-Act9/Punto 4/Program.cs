using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class evaluacionDoc
    { /*4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
sus nombres y puntajes promedio obtenidos (de 1 a 10).
Cargar sus datos en vectores paralelos, mostrar docente con calificación más
alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
desaprobaron (tomando como base que se aprueba con una nota mayor o igual
a 6)*/

        private string[] docentes;
        private float[] puntuaciones;
        private string stringPuntuacionMin, stringPuntuacionMax;
        private float puntuacionMaxima, puntuacionMinima;
        private int cantAprobada, cantDesaprobada;
        public void cargar() {
            docentes = new string[6];
            puntuaciones = new float[6];
            string linea;

            for (int i = 0; i < puntuaciones.Length; i++) {

                Console.WriteLine("escribe el nombre de un docente");
                linea = Console.ReadLine();
                docentes[i] = linea;
                Console.WriteLine("Ahora escribi una puntuacion de 1 a 10");
                linea = Console.ReadLine();
                puntuaciones[i] = float.Parse(linea);
                if (puntuaciones[i] < 1 || puntuaciones[i] > 10) {
                    Console.WriteLine("Escribe una puntuacion de 1 a 10, intentalo de nuevo");
                    i--;
                }
            }
        }

        public void conseguirMasAltaYMasBaja() {

            puntuacionMaxima = puntuaciones[0];
            puntuacionMinima = puntuaciones[0];
            for (int i = 0; i < puntuaciones.Length; i++) {
                if (puntuaciones[i] > puntuacionMaxima)
                {
                    puntuacionMaxima = puntuaciones[i];
                }
                if (puntuaciones[i] < puntuacionMinima) {
                    puntuacionMinima = puntuaciones[i];
                }
            }
        }
        public void compararPuntuaciones()
        {
            stringPuntuacionMax = "el o los profesores con la puntuacion mas alta es/son : ";
            stringPuntuacionMin = "el o los profesores con la puntuacion mas baja es/son : ";
            for (int i = 0; i < puntuaciones.Length; i++)
            {
                if (puntuaciones[i] == puntuacionMaxima)
                {
                    stringPuntuacionMax += docentes[i] + ", ";
                }
                if (puntuaciones[i] == puntuacionMinima)
                {
                    stringPuntuacionMin += docentes[i] + ", ";
                }

            }
        }
        public void aprobados()
        {
            cantAprobada = 0;
            cantDesaprobada = 0;
            for (int i = 0; i < docentes.Length; i++)
            {
                if (puntuaciones[i] >= 6)
                {
                    cantAprobada++;
                }
                else if (puntuaciones[i] < 6)
                {
                    cantDesaprobada++;
                }
            }
        }
        public void ordenarVectores()
        {
            float auxPunt;
            string auxDoc;

            for (int i = 0; i < puntuaciones.Length; i++)
            {
                for (int f = 0; f < puntuaciones.Length - 1 - i; f++)
                {
                    if (puntuaciones[f] < puntuaciones[f + 1])
                    {
                        auxPunt = puntuaciones[f + 1];
                        puntuaciones[f + 1] = puntuaciones[f];
                        puntuaciones[f] = auxPunt;
                        auxDoc = docentes[f + 1];
                        docentes[f + 1] = docentes[f];
                        docentes[f] = auxDoc;
                    }
                }
            }
        }
        public void mostrarTodo()
        {
            Console.WriteLine(stringPuntuacionMax);
            Console.WriteLine(stringPuntuacionMin);

            Console.WriteLine("la cantidad de docentes que aprobaron es de: ");
            Console.WriteLine(cantAprobada);
            Console.WriteLine("la cantidad de docentes que desaprobaron es de: ");
            Console.WriteLine(cantDesaprobada);

            Console.WriteLine("el orden de mayor a menor de los dos vectores es de: ");
            for (int i = 0; i < puntuaciones.Length; i++) {
                Console.WriteLine(docentes[i] + " tiene una puntuacion de: " + puntuaciones[i]);
            }
        }
        static void Main(string[] args)
        {
            evaluacionDoc evDoc = new evaluacionDoc();
            evDoc.cargar();
            evDoc.conseguirMasAltaYMasBaja();
            evDoc.compararPuntuaciones();
            evDoc.aprobados();
            evDoc.ordenarVectores();
            evDoc.mostrarTodo();
            Console.ReadKey();
        }
    }
}
