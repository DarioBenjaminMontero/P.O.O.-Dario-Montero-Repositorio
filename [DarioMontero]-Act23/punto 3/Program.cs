using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
   class MonitoreoCostero
    {
        private List<string>especiesDetectadas = new List<string>();
        public void CargarAvistamientos() {
            string linea;
            for (int i = 0; i < 1; i++) {
                Console.WriteLine("Por favor, ingrese el nombre de un animal marino. El proceso se repetirá hasta que escriba 'FIN'");
                linea = Console.ReadLine();
                if (linea != "FIN" && linea != "fin" && linea != "Fin")
                {
                    especiesDetectadas.Add(linea);
                    Console.WriteLine("AGREGADO CON EXITO");
                    i--;
                }
                else { 
                
                }
            }
            
        }
        public void MostrarReporteOrdenado() {
            especiesDetectadas.Sort();
            foreach (string e in especiesDetectadas) {
                Console.WriteLine("Se avistó: " + e + " durante el dia");
            }
        }
        public void MostrarReporteInvertido() {
            especiesDetectadas.Sort();
            especiesDetectadas.Reverse();
            Console.WriteLine("lista de los avistamientos revertida: ");
            foreach (string e in especiesDetectadas) {
                Console.WriteLine("durante el dia se avistó: " + e);
            }
        }
        public void BuscarEspecie() {
            string linea;
            Console.WriteLine("Escribe el nombre del animal que querés saber si se avistó");
            linea = Console.ReadLine();
            string especie = especiesDetectadas.Find(e => e == linea);
            if (especie == null)
            {
                Console.WriteLine("no se avistó el animal");
            }
            else {
                Console.WriteLine("el animal " + especie + " se ha avistado");
            }
        }
        static void Main(string[] args)
        {
            MonitoreoCostero monitoreo = new MonitoreoCostero();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("1 para agregar, 2 para mostrar la lista ordenada, 3 para mostrar la lista al reves, 4 para buscar una especie ,5 para acabar el programa.");
                int numero = int.Parse(Console.ReadLine());
                if (numero < 1 || numero > 5)
                {
                    Console.WriteLine("Numero invalido, intente otra vez");
                    i--;
                }
                else if (numero == 1)
                {
                    monitoreo.CargarAvistamientos();
                    i--;
                }
                else if (numero == 2)
                {
                    monitoreo.MostrarReporteOrdenado();
                    i--;
                }
                else if (numero == 3)
                {
                    monitoreo.MostrarReporteInvertido();
                    i--;
                }
                else if (numero == 4)
                {
                    monitoreo.BuscarEspecie();
                    i--;
                }
                else if (numero == 5)
                { }
            }
            Console.ReadKey();
        }
    }
}
