using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{

    class Alumno {

        private string nombre;
        private float[] notas;
        public Alumno(){
            string linea;
            notas = new float[4];
            Console.WriteLine("cual es el nombre del alumno?");
            nombre = Console.ReadLine();
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("por favor escribe la nota numero " + i + " del alumno");
                linea = Console.ReadLine();
                notas[i] = float.Parse(linea);
            }
        }

        public string retornarNombre() {
            return nombre;
        }

        public float[] retornarNotas() {
            return notas;
        }
    }

     class Curso
    {
        private Alumno[] Alumnos;
        float[] promedios = new float[4];
        public Curso() { 
        Alumnos = new Alumno[4];
            for (int i = 0; i < Alumnos.Length; i++) {
                Alumnos[i] = new Alumno();
            }
        }
        public void nombreYPromedio()
        {
            float promedio;

            for (int i = 0; i < Alumnos.Length; i++)
            {
                float[] notas = Alumnos[i].retornarNotas();
                promedio = 0;
                for (int j = 0; j < notas.Length; j++)
                {
                    promedio += notas[j];
                }
                promedio = promedio / notas.Length;
                promedios[i] = promedio;
                Console.WriteLine("el nombre del alumno es: " + Alumnos[i].retornarNombre());
                Console.WriteLine("el promedio de sus notas es: " + promedio);
            }
        }

        public void promedioMasAlto() {
            float notaMasGrande = promedios[0];
            for (int i = 0; i < promedios.Length; i++) {
                if (promedios[i] > notaMasGrande) {
                    notaMasGrande = promedios[i];
                }
            }

            for (int i = 0; i < promedios.Length; i++) {
                if (promedios[i] == notaMasGrande) {
                    Console.WriteLine("el alumno " + Alumnos[i].retornarNombre() + " tiene la nota mas grande con " + promedios[i]);
                }
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
