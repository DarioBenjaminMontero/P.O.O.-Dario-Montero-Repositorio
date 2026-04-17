using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class carrera
    {/*3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
carrera de 100 metros. El programa debe cargar los datos en dos vectores
paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
promedio.*/

        private string[] atletas;
        private float[] tiempos;
        private float promedio, suma, minimo, maximo;
        private string atletas2, atletas3;
        public void cargar()
        {
            atletas = new string[5];
            tiempos = new float[5];
            string linea;
            for (int i = 0; i < atletas.Length; i++)
            {
                Console.WriteLine("Por favor, Escriba el nombre de un atleta");
                linea = Console.ReadLine();
                atletas[i] = linea;
                Console.WriteLine("Ahora escriba el tiempo de ese atleta en segundos por favor");
                linea = Console.ReadLine();
                tiempos[i] = float.Parse(linea);
            }
        }
        public void CalcularPromedioTiempos() {
            for (int i = 0; i < tiempos.Length; i++) {
                suma += tiempos[i];
            }
            promedio = suma / tiempos.Length;
        }
        public void encontrarMinimoMaximo() {
            maximo = tiempos[0];
            minimo = tiempos[0];
            for (int i = 0; i < tiempos.Length; i++) {

                if (tiempos[i] > maximo) {
                    maximo = tiempos[i];
                }
                if (tiempos[i] < minimo) {
                minimo = tiempos[i];
                }
            }
        
        }
        public void mostrarMejorYPeorTiempo() {
            atletas2 = "los atletas con mayor tiempo es/son: ";
            atletas3 = "los atletas con menor tiempo es/son: ";
            for (int i = 0; i < tiempos.Length; i++)
            {
                if (tiempos[i] == maximo)
                {
                    atletas3 += atletas[i] + " con un tiempo de " + tiempos[i] + " segundos, ";
                }
                else if (tiempos[i] == minimo) { 
                atletas2 += atletas[i] + " con un tiempo de " + tiempos[i] + " segundos, ";
                }
           
            }
            Console.WriteLine(atletas2);
            Console.WriteLine(atletas3);
        }
        public void quienSuperoPromedio() {
            Console.WriteLine("el promedio es " + promedio);
            for (int i = 0; i < atletas.Length; i++) {

                if (tiempos[i]<promedio) {
                    Console.WriteLine("el atleta " + atletas[i] + " superó el promedio");
                }

            }

        }
        static void Main(string[] args)
        {
            carrera carrera = new carrera();
            carrera.cargar();
            carrera.CalcularPromedioTiempos();
            carrera.encontrarMinimoMaximo();
            carrera.mostrarMejorYPeorTiempo();
            carrera.quienSuperoPromedio();
            Console.ReadKey();
        }
    }
}
