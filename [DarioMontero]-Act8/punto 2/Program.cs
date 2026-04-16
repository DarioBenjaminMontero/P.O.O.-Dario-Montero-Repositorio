using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    internal class Paises
    {/*2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
algoritmo de ordenamiento alfabético.*/

        private string[] vector;

        public void cargar() {
            string linea;
            
            vector = new string[5];
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Escribe un pais");
            linea = Console.ReadLine();
                vector[i] = linea;
            }
        }

        public void comparar() {
            string auxPais;
            for (int k = 0; k < vector.Length; k++) //cuantas veces se repetira el proceso de comparar
            {

                for (int f = 0; f < vector.Length - 1 - k; f++)//recorrer el vector y comparar los espacios
                { //se le resta 1 por que asi no comparas con el ultimo espacio y le quitas la cantidad de
                    //veces que ya repetiste el anterior for para no comparar numeros que ya estan en su espacio correspondiente
                    if (vector[f].CompareTo(vector[f + 1]) > 0)
                    {
                        auxPais = vector[f + 1];
                        vector[f + 1] = vector[f];
                        vector[f] = auxPais;
                    }


                }
            }
        }

        public void mostrar() {
            for (int i = 0; i < vector.Length; i++) {
            Console.WriteLine(vector[i]);
            }
        
        }

        static void Main(string[] args)
        {
          Paises paises = new Paises();
            paises.cargar();
            paises.comparar();
            paises.mostrar();
            Console.ReadKey();
        }
    }
}
