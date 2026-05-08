using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class Faltas
    {
        /*3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
empresa.
Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
irregular para cargar los días que han faltado cada empleado (cargar el número de día que
faltó)
Cada fila de la matriz representa los días de cada empleado.
a. Mostrar los empleados con la cantidad de inasistencias.
b. Cuál empleado faltó menos días.*/

        private string[] empleados;
        private int[][] faltas;
        private int menor;

        public void crear() {
            empleados = new string[3];
            faltas = new int[3][];
            string linea;
            for (int i = 0; i < empleados.Length; i++) {
                Console.WriteLine("por favor, escribe el nombre del empleado: ");
                empleados[i] = Console.ReadLine();
                Console.WriteLine("ahora escribe cuantos dias faltó este empleado: ");
                linea = Console.ReadLine();
                if (int.Parse(linea) >=0) {
                    faltas[i] = new int[int.Parse(linea)];
                }
            }
        }
        public void cargar() {
            string linea;
            for (int i = 0; i < faltas.GetLength(0); i++) {
                for (int f = 0; f < faltas[i].Length; f++) {
                    Console.WriteLine("por favor escribe el NUMERO del dia que faltó el empleado " + empleados[i]);
                    linea = Console.ReadLine();
                    faltas[i][f] = int.Parse(linea);
                }
            }
        }
        public void mostrar() {
            menor = faltas[0].Length;
            for (int i = 0; i < faltas.GetLength(0); i++) {
                if (menor > faltas[i].Length) {
                menor = faltas[i].Length;
                }
                Console.WriteLine("el empleado " + empleados[i] + " faltó " + faltas[i].Length + " dias");
            }
        }
        public void mostrarMenor(){
            for (int i = 0; i < faltas.GetLength(0); i++) {
                if (faltas[i].Length == menor)
                {
                    Console.WriteLine("el empleado " + empleados[i] + " fue el que faltó menos dias, con " + faltas[i].Length);
                }
            }
        }
        static void Main(string[] args)
        {
            Faltas faltas = new Faltas();
            faltas.crear();
            faltas.cargar();
            faltas.mostrar();
            faltas.mostrarMenor();
            Console.ReadKey();
        }
    }
}
