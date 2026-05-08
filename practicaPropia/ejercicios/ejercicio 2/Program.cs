using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class cargarNombres
    {
        private List<string> nombres = new List<string>();

        public void cargar() {
            string linea;
            do
            {

                Console.WriteLine("escribe un nombre, al escribir 'fin' termina el programa");
                linea = Console.ReadLine();
                if (linea == "fin")
                {
                    return;
                }
                nombres.Add(linea);
            } while (linea != "fin");
        }

        public void mostrar() {

            Console.WriteLine("nombre en la primera posicion " + nombres[0]);
            Console.WriteLine("nombre en la ultima posicion: " + nombres[nombres.Count - 1]);
            for (int i = 0; i < nombres.Count; i++) {
                if (nombres[i].Length > 5) {
                    Console.WriteLine("el nombre: " + nombres[i] + " tiene mas de 5 letras");
                }
            }
        
        }

        static void Main(string[] args)
        {
            cargarNombres nom = new cargarNombres();
            nom.cargar();
            nom.mostrar();
            Console.ReadKey();

        }
    }
}
