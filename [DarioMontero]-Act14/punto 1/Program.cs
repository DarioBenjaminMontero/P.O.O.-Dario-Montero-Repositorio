using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    class Vehiculo 
    {

        /*1. El Sistema de Peaje.
Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
La clase Vehiculo debe tener los siguientes atributos privados:
Patente (de tipo string).
Tipo (puede ser "Auto", "Camion" o "Moto").
Tarifa (un valor decimal que representa el costo de su pase).
El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
La clase CabinaPeaje debe tener como atributos privados:
El número o identificador de la cabina.
Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los siguientes métodos dentro de CabinaPeaje:
Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
Un método que muestre la patente del vehículo que pagó la tarifa más cara.
*/
        string patente;
        string tipo;
        float tarifa;
        public Vehiculo()
        {
            string linea;
            Console.WriteLine("escribe la patente del vehiculo");
            patente = Console.ReadLine();
            Console.WriteLine("escribe el tipo del vehiculo (Auto, Moto o Camion)");
            tipo = Console.ReadLine();
            Console.WriteLine("ahora escribe la tarifa a pagar");
            linea = Console.ReadLine();
            tarifa = float.Parse(linea);
        }

        public string devolverPatente() { 
        return patente;
        }
        public string devolverTipo()
        {
            return tipo;
        }
        public float devolverTarifa() {
            return tarifa;
        }

    }
    class CabinaPeaje
    {
        private int numeroCabina;
        private float recaudacion;
        private Vehiculo vehiculo, vehiculo2, vehiculo3;
        public CabinaPeaje() {
            string linea;
            Console.WriteLine("escribe el numero de la cabina");
            linea = Console.ReadLine();
            numeroCabina = int.Parse(linea);
        vehiculo = new Vehiculo();
            vehiculo2 = new Vehiculo();
            vehiculo3 = new Vehiculo();
        }

        public void patenteYTipo(){
            Console.WriteLine("la patente y el tipo del primer vehiculo son: ");
            Console.WriteLine("patente" + vehiculo.devolverPatente() + ". Tipo: " + vehiculo.devolverTipo());
            Console.WriteLine("la patente y el tipo del primer vehiculo son: ");
            Console.WriteLine("patente" + vehiculo2.devolverPatente() + ". Tipo: " + vehiculo2.devolverTipo());
            Console.WriteLine("la patente y el tipo del primer vehiculo son: ");
            Console.WriteLine("patente" + vehiculo3.devolverPatente() + ". Tipo: " + vehiculo3.devolverTipo());
        }
        public void Recaudacion() {
            recaudacion = 0;
            recaudacion += vehiculo.devolverTarifa() + vehiculo2.devolverTarifa() + vehiculo3.devolverTarifa();
            Console.WriteLine("la cantidad de dinero que recaudo la cabina numero " + numeroCabina + " es de " + recaudacion);
        }
        public void tarifaMasAlta() {
            float mayor = vehiculo.devolverTarifa();

            if (vehiculo2.devolverTarifa() > mayor) {
                mayor = vehiculo2.devolverTarifa();
            }
            if (vehiculo3.devolverTarifa() > mayor) {
                mayor = vehiculo3.devolverTarifa();
            }

            if (vehiculo.devolverTarifa() == mayor)
            {
                Console.WriteLine("el vehiculo con la patente " + vehiculo.devolverPatente() + " pago la tarifa mas alta");
            }
            if (vehiculo2.devolverTarifa() == mayor)
            {
                Console.WriteLine("el vehiculo con la patente " + vehiculo2.devolverPatente() + " pago la tarifa mas alta");
            }
            if (vehiculo3.devolverTarifa() == mayor)
            {
                Console.WriteLine("el vehiculo con la patente " + vehiculo3.devolverPatente() + " pago la tarifa mas alta");
            }

        }

        static void Main(string[] args)
        {
            CabinaPeaje cabina = new CabinaPeaje();
            cabina.patenteYTipo();
            cabina.Recaudacion();
            cabina.tarifaMasAlta();
            CabinaPeaje cabina2 = new CabinaPeaje();
            cabina2.patenteYTipo();
            cabina2.Recaudacion();
            cabina2.tarifaMasAlta();
            CabinaPeaje cabina3 = new CabinaPeaje();
            cabina3.patenteYTipo();
            cabina3.Recaudacion();
            cabina3.tarifaMasAlta();
            Console.ReadKey();
        }
    }
}
