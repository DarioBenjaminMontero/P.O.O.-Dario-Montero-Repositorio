using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{

    class Pasajero {
        private string Nombre;
        private int DNI;
        private float EquipajeKilos;

        public Pasajero() {
            string linea;
            Console.WriteLine("escribe el nombre del pasajero");
            Nombre = Console.ReadLine();
            Console.WriteLine("escribe ahora el DNI del pasajero");
            linea = Console.ReadLine();
            DNI = int.Parse(linea);
            Console.WriteLine("ahora ingrese el peso de su equipaje en Kilogramos");
            linea = Console.ReadLine();
            EquipajeKilos = float.Parse(linea);
        }

        public string devolverNombre() {
            return Nombre;
        }
        public int devolverDNI() {
            return DNI;
        }
        public float devolvertPeso() {
            return EquipajeKilos;
        }
        
    }


    class Vuelo
    {
        private Pasajero[] Pasajeros;
        public Vuelo()
        {
            Pasajeros = new Pasajero[4];
            for (int i = 0; i < Pasajeros.Length; i++) {
                Pasajeros[i] = new Pasajero();
            }
        }

        public void devolverDatos() {
        
        }
        static void Main(string[] args)
        {



        }
    }
}
