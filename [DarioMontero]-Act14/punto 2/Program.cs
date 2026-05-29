using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{

    class Pasajero
    {
        private string Nombre;
        private int DNI;
        private float EquipajeKilos;

        public Pasajero()
        {
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

        public string devolverNombre()
        {
            return Nombre;
        }
        public int devolverDNI()
        {
            return DNI;
        }
        public float devolverPeso()
        {
            return EquipajeKilos;
        }

    }


    class Vuelo
    {
        private Pasajero[] Pasajeros;
        private float pesoTotal;
        public Vuelo()
        {
            Pasajeros = new Pasajero[4];
            for (int i = 0; i < Pasajeros.Length; i++)
            {
                Pasajeros[i] = new Pasajero();
            }
        }

        public void mostrarDatos()
        {
            for (int i = 0; i < Pasajeros.Length; i++)
            {
                Console.WriteLine("el nombre del pasajero es: " + Pasajeros[i].devolverNombre() + " Y su DNI es: " + Pasajeros[i].devolverDNI());
                Console.WriteLine("el peso del equipaje del pasajero es: " + Pasajeros[i].devolverPeso());
                Console.WriteLine("____________________________");
            }
        }

        public void PesoTotal()
        {
            pesoTotal = 0;
            for (int i = 0; i < Pasajeros.Length; i++)
            {
                pesoTotal += Pasajeros[i].devolverPeso();
            }
            Console.WriteLine("el peso total que hay en el Vuelo es de: ");
            Console.WriteLine(pesoTotal);
            Console.WriteLine();
        }
        public void excedeLimite()
        {
            for (int i = 0; i < Pasajeros.Length; i++)
            {
                if (Pasajeros[i].devolverPeso() > 23)
                {
                    Console.WriteLine("el pasajero " + Pasajeros[i].devolverNombre() + " y con el DNI: " + Pasajeros[i].devolverDNI() + ". ha excedido el limite de peso");
                }
            }
        }
        static void Main(string[] args)
        {
            Vuelo vuelo = new Vuelo();
            vuelo.mostrarDatos();
            vuelo.PesoTotal();
            vuelo.excedeLimite();
            Console.ReadKey();

        }
    }
}
