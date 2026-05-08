using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3__listas_
{
    internal class Programa
    {

        private List<int>numeros = new List<int>();

        public void opciones()
        {
            string linea;
            int opcion;
            bool continuar = true;
            while (continuar) {
                Console.WriteLine("Que deseas hacer?");
                Console.WriteLine("elige 1 para agregar un numero, elige 2 para eliminar alguno en una posicion especifica, elige 3 para ver toda la lista, u opcion 4 para terminar");
                linea = Console.ReadLine();
                if (int.Parse(linea) > 4 || int.Parse(linea) < 1)
                {
                    Console.WriteLine("Opcion no aceptada");
                    opciones();
                }
                if (!int.TryParse(linea, out opcion)) {
                    Console.WriteLine("Opcion invalida");
                    continue;
                }

                    switch (opcion)
                    {

                        case 1:
                            agregar();
                            break;
                        case 2:
                            eliminar();
                            break;
                        case 3:
                            verLista();
                            break;
                        case 4:
                            continuar = false;
                            break;


                    }
            }
            
        }
        public void agregar() {
            string linea;
            int numero;
            Console.WriteLine("Elegiste agregar un numero");
            Console.WriteLine("cual es le numero que queres agregar? este se agregará en la ultima posicion");
            linea = Console.ReadLine();
            if (!int.TryParse(linea, out numero)) {
                Console.WriteLine("Opcion no aceptada");
                opciones();
            }
            numeros.Add(int.Parse(linea));
            
        }
        public void eliminar() {
            string linea;
            int numero;
            Console.WriteLine("elegiste eliminar un numero");
            Console.WriteLine("escribe la posicion del numero que quieres eliminar");
            linea = Console.ReadLine();
            if (!int.TryParse(linea, out numero)) {
                Console.WriteLine("Opcion no aceptada");
                opciones();
            }
            numeros.RemoveAt(int.Parse(linea));
            Console.WriteLine("numero eliminado de forma exitosa");
            
        }
        public void verLista() {
            Console.WriteLine("aca está la lista completa de numeros");
            for (int i = 0; i < numeros.Count; i++) {
                Console.WriteLine("en la posicion " + i + " está el numero: " + numeros[i]);
            }
            
        }
        
        

        static void Main(string[] args)
        {
            Programa programa = new Programa();
            programa.opciones();
            Console.ReadKey();
            
        }
    }
}
