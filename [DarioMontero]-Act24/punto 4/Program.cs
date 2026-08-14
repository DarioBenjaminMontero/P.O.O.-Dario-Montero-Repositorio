using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
    class Ticket {
        private string patente;
        private int horasEstadia;
            public string Patente
        {
            set { patente = value; }
            get { return patente; }
        }
        public int HorasEstadia {
            set { horasEstadia = value; }
            get { return horasEstadia; }
        }

        public Ticket(string pat, int hrs) { 
        patente = pat;
            horasEstadia = hrs;
        }

    }

    class GestionEstacionamiento
    {
        List<Ticket> tickets = new List<Ticket>();
        public void RegistrarIngreso() {
            string patente, linea;
            int horas;
            Console.WriteLine("escribi la patente del vehiculo");
            patente = Console.ReadLine();
            Console.WriteLine("escribe las horas que estuvo en estadia");
            linea = Console.ReadLine();
            horas = int.Parse(linea);
            Ticket t = new Ticket(patente, horas);
            tickets.Add(t);
        }
        public void ProcesarSalida() {
            if (tickets.Count > 0)
            {
                Console.WriteLine("salio el vehiculo de la pantente " + tickets[0].Patente + " que estuvo " + tickets[0].HorasEstadia + " horas en la playa");
                tickets.RemoveAt(0);
            }
            else {
                Console.WriteLine("no hay vehiculos esperando para salir");
            }
            
        }
        public void MostrarVehiculosEstacionados() {
            foreach (Ticket t in tickets) {
                Console.WriteLine("patente del Vehiculo: " + t.Patente + ". Horas que se quedó: " + t.HorasEstadia);
            }
            Console.WriteLine("la cantidad de unidades presentes es de " + tickets.Count);
        }
        static void Main(string[] args)
        {
            GestionEstacionamiento g = new GestionEstacionamiento();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("1 para registrar ingresos, 2 para procesar la salida de una unidad, 3 para mostrar los vehiculos estacionados, 4 para acabar el programa.");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------");
                if (numero < 1 || numero > 4)
                {
                    Console.WriteLine("Numero invalido, intente otra vez");
                    i--;
                }
                else if (numero == 1)
                {
                    g.RegistrarIngreso();
                    i--;
                }
                else if (numero == 2)
                {
                    g.ProcesarSalida();
                    i--;
                }
                else if (numero == 3)
                {
                    g.MostrarVehiculosEstacionados();
                    i--;
                }
                
                else if (numero == 4)
                { }
            }

            Console.ReadKey();
        }
    }
}
