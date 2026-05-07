using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class temperaturas
    {
        /*1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
dato las temperaturas medias mensuales de dichos paises.
Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
mensuales.
Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
memoria.
a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
mismas.
c. Calcular la temperatura media trimestral de cada país.
d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
e. Imprimir el nombre del país con la temperatura media trimestral mayor.*/

        private string[] paises;
        private float[,] matTemperaturas;
        private float[] tempTrimestral;
        private float mayorTemp;
        public void cargar() {
            string linea;
            paises = new string[4];
            matTemperaturas = new float[4, 3];
            tempTrimestral = new float[4];
            for (int i = 0; i < paises.Length; i++) {
                Console.WriteLine("escribe un pais por favor");
                paises[i] = Console.ReadLine();
                for (int m = 0; m < matTemperaturas.GetLength(1); m++) {
                    Console.WriteLine("escribe la temperatura numero " + m + " del pais " + paises[i]);
                    linea = Console.ReadLine();
                    matTemperaturas[i,m] = float.Parse(linea);
                }
            }
        }
        public void mostrarTemperaturas() {
            for (int i = 0; i < paises.Length; i++) {
                Console.WriteLine("el pais: " + paises[i] + " tiene las temperaturas:");
                for (int m = 0; m < matTemperaturas.GetLength(1); m++)
                {
                    Console.WriteLine("en el mes "+m + " tuvo una temperatura de: " + matTemperaturas[i,m]);
                }
                Console.WriteLine();
            }
        }
        public void calcularMedia() {
            float media;
            float suma;
            for (int i = 0; i < paises.Length; i++)
            {
                suma = 0;
                for (int m = 0; m < matTemperaturas.GetLength(1); m++)
                {
                    suma += matTemperaturas[i, m];
                }
                media = suma / matTemperaturas.GetLength(1);
                tempTrimestral[i] = media;
            }
        }

        public void imprimirTrimes() {
            for (int i = 0; i < paises.Length; i++) {
                Console.WriteLine("el pais " + paises[i] + " tuvo una temperatura trimestral media de: " + tempTrimestral[i] + " grados");
            }
        }
        public void encontrarMayor() {
            mayorTemp = tempTrimestral[0];
            for (int i = 0; i < paises.Length; i++) {
                if (tempTrimestral[i] > mayorTemp) {
                mayorTemp= tempTrimestral[i];
                }
            }
        }
        public void imprimirMayor() {
            for (int i = 0; i < paises.Length; i++) {
                if (tempTrimestral[i] == mayorTemp) {
                    Console.WriteLine("el pais " + paises[i] + " tuvo la mayor temperatura trimestral con: " + tempTrimestral[i] + " grados");
                }
            }
        }


        static void Main(string[] args)
        {
            temperaturas temp = new temperaturas();
            temp.cargar();
            temp.mostrarTemperaturas();
            temp.calcularMedia();
            temp.imprimirTrimes();
            temp.encontrarMayor();
            temp.imprimirMayor();
            Console.ReadKey();
        }
    }
}
