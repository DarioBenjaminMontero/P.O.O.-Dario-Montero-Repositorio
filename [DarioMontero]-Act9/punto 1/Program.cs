using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    internal class NotasEstudiantes
    { /*1. Se desea desarrollar un programa que permita registrar los nombres y las
calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
máxima o mínima.*/
        private string[] estudiantes;
        private int[] notas;
        private int notamaxima, notaminima;
        public void cargar() {
            estudiantes = new string[6];
            notas = new int[6];
            string linea;
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("Por favor, ingrese el nombre de un estudiante");
                linea = Console.ReadLine();
                estudiantes[i] = linea;
                Console.WriteLine("ahora ingrese una nota para ese mismo estudiante");
                linea = Console.ReadLine();
                notas[i] = int.Parse(linea);
            }
        }
        public void conseguirMinimoYMaximo() {
            notaminima = notas[0];
            notamaxima = notas[0];
            for (int i = 0; i < notas.Length; i++) {
                if (notas[i] > notamaxima)
                {
                    notamaxima = notas[i];
                }
                else if (notas[i] < notaminima) {
                    notaminima = notas[i];
                }
            }
        }
        public void mostrarAlumnos() {
            int cantNotaMaxima=0;
            string linea ="el alumno ";
            string linea2 = "el alumno ";
            int cantNotaMinima=0;
            for (int i = 0; i < notas.Length; i++) {
                if (notas[i] == notamaxima)
                {
                    
                   linea +=estudiantes[i]+", ";
                    cantNotaMaxima++;
                }
                else if (notas[i] == notaminima) {
                    linea2 += estudiantes[i] + ", ";
                cantNotaMinima++;
                }
            }
            if (cantNotaMaxima > 1) {
                Console.WriteLine("hay mas de 1 alumno con la nota maxima");
            }
            if (cantNotaMinima > 1) {
                Console.WriteLine("hay mas de un alumno con la nota minima");
            }
            linea += " tiene la nota maxima de " + notamaxima;
            linea2 += " tiene la nota minima de " + notaminima;
            Console.WriteLine(linea);
            Console.WriteLine(linea2);
        }
        static void Main(string[] args)
        {
            NotasEstudiantes noEst = new NotasEstudiantes();
            noEst.cargar();
            noEst.conseguirMinimoYMaximo();
            noEst.mostrarAlumnos();
            Console.ReadKey();
        }
    }
}
