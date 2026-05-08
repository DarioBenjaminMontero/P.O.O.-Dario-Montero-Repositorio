using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Lista
    {
        private List<int> numeros = new List<int>();
        private int sumatotal; 
        public void cargar() {
            
            string linea;

            do
            {

                Console.WriteLine("Escribe numeros, si escribis 0, el programa termina");
                linea = Console.ReadLine();
                if (int.Parse(linea) == 0)
                {
                    return;
                }
                numeros.Add(int.Parse(linea));
            }
            while (int.Parse(linea) != 0);
        }

        public void mostrarNumeros() {
            for (int i = 0; i < numeros.Count; i++) {
                Console.WriteLine(numeros[i]);
            }
        }

        public void suma() {
            sumatotal = 0;
            for (int i = 0; i < numeros.Count; i++)
            {
                sumatotal += numeros[i];
            }
        }

        public void mostrarSumaYCantidad() {
            Console.WriteLine(sumatotal);
            Console.WriteLine(numeros.Count);
        }

        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.cargar();
            lista.mostrarNumeros();
            lista.suma();
            lista.mostrarSumaYCantidad();
            Console.ReadKey();
        }
    }
}
