using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    internal class Program
    { /*1. Plantear una clase parcial ReservaHotel.
En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
noches sea mayor a 0. Estos valores son cargados desde la consola.
En el segundo archivo, agregar un método que calcule el total a pagar según la
habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
noche).
Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.*/
        private ReservaHotel[] reservas;
        public Program() { 
        reservas = new ReservaHotel[3];
            for (int i = 0; i < reservas.Length; i++)
            {
                reservas[i] = new ReservaHotel();
            }
        }
        public void todasLasReservas() {
            Console.WriteLine("todas las reservas son: ");
            for (int i = 0; i < reservas.Length; i++) {
                Console.WriteLine("nombre: " + reservas[i].NombreCliente + ". cantidad de noches reservadas:  " + reservas[i].CantidadNoches + ". tipo de habitacion: " + reservas[i].TipoHabitacion + ". total a pagar: " + reservas[i].Total);
               
            }
        }
        public void mayorPaga() {
            int mayor = reservas[0].Total;
            for (int i = 0; i < reservas.Length; i++) {
                if (reservas[i].Total > mayor) { 
                mayor = reservas[i].Total;
                }
            }
            for (int i = 0; i < reservas.Length; i++) {
                if (reservas[i].Total == mayor) {
                    Console.WriteLine("el cliente de nombre " + reservas[i].NombreCliente + " tiene que pagar la mayor cantidad de dinero con " + mayor + " pesos");
                }
            }
        }
        static void Main(string[] args)
        {
            Program program  = new Program();
            program.todasLasReservas();
            program.mayorPaga();
            Console.ReadKey();
        }
    }
}
