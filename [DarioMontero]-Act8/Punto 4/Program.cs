using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class Program
    {/*4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
nuevamente.*/
        private string[] vectorPaises;
        private int[] vectorPoblacion;
        public void cargar() {

            vectorPaises = new string[5];
            vectorPoblacion = new int[5];
            string linea;
            for (int i = 0; i < vectorPaises.Length; i++)
            {
                Console.WriteLine("Escribe el nombre de un pais");
                linea = Console.ReadLine();
                vectorPaises[i] = linea;
                Console.WriteLine("ahora una poblacion para el mismo");
                linea = Console.ReadLine();
                vectorPoblacion[i] = int.Parse(linea);
            }
        }
        public void comparar(){
            string auxPaises;
            int auxPoblacion;
            for (int k = 0; k < vectorPaises.Length; k++) {

                for (int f = 0; f < vectorPaises.Length - 1 - k; f++) {

                    if (vectorPaises[f].CompareTo(vectorPaises[f + 1]) > 0) {

                        auxPaises = vectorPaises[f + 1];
                        vectorPaises[f + 1] = vectorPaises[f];
                        vectorPaises[f] = auxPaises ;
                        auxPoblacion = vectorPoblacion[f + 1];
                        vectorPoblacion[f + 1] = vectorPoblacion[f];
                        vectorPoblacion[f] = auxPoblacion;
                    }

                }

            }
        }
        public void mostrar() {
            Console.WriteLine("paises ordenados alfabeticamente con sus poblaciones respectivas:");
            for (int i = 0; i < vectorPaises.Length; i++) {
                Console.WriteLine("pais: " + vectorPaises[i]+ ". Poblacion: " + vectorPoblacion[i]);
            
            }
        
        }

        public void compararPoblaciones()
        {
            string auxPaises;
            int auxPoblacion;
            for (int k = 0; k < vectorPaises.Length; k++)
            {

                for (int f = 0; f < vectorPaises.Length - 1 - k; f++)
                {

                    if (vectorPoblacion[f] > vectorPoblacion[f+1])
                    {

                        auxPaises = vectorPaises[f + 1];
                        vectorPaises[f + 1] = vectorPaises[f];
                        vectorPaises[f] = auxPaises;
                        auxPoblacion = vectorPoblacion[f + 1];
                        vectorPoblacion[f + 1] = vectorPoblacion[f];
                        vectorPoblacion[f] = auxPoblacion;
                    }

                }

            }
        }

        public void mostrarPorPoblacion()
        {
            Console.WriteLine("paises ordenados por poblacion con sus poblaciones respectivas:");
            for (int i = 0; i < vectorPaises.Length; i++)
            {
                Console.WriteLine("pais: " + vectorPaises[i] + ". Poblacion: " + vectorPoblacion[i]);

            }

        }


        static void Main(string[] args)
        {
            Program programa = new Program();
            programa.cargar();
            programa.comparar();
            programa.mostrar();
            programa.compararPoblaciones();
            programa.mostrarPorPoblacion();
            Console.ReadKey();

        }
    }
}
