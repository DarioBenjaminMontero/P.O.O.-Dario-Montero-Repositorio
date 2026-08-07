using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace punto_5
{
    class Vehiculo {

        private string patente;
        private double costoReparacion;
        public string Patente
        {
            set { patente = value; }
            get { return patente; }
        }
        public double CostoReparacion
        {
            set { costoReparacion = value; }
            get { return costoReparacion; }
        }

        public Vehiculo(string pat, double costo) {
            patente = pat;
            costoReparacion = costo;
        }

    }
    class GestionTaller
    {
        private List<Vehiculo>vehiculos = new List<Vehiculo>();
        public void IngresarVehiculo() {
            Console.WriteLine("por favor ingrese el nombre del vehiculo que quiere agregar");
            Console.WriteLine("--------------------------------------------------------------------");
            string nombre, linea;
            nombre = Console.ReadLine();
            Console.WriteLine("por favor ingrese el costo de reparacion que tiene el vehiculo");
            Console.WriteLine("--------------------------------------------------------------------");
            linea = Console.ReadLine();
            double costo;
            costo = double.Parse(linea);
            Vehiculo v = new Vehiculo(nombre, costo);
            vehiculos.Add(v);

        }
        public void BuscarVehiculo() {
            Console.WriteLine("ingrese la patente del vehiculo que quiere encontrar");
            Console.WriteLine("--------------------------------------------------------------------");
            string nombre;
            nombre = Console.ReadLine();
            Vehiculo vehiculo = vehiculos.Find(e => e.Patente == nombre);
            if (vehiculo != null)
            {
                foreach (Vehiculo ve in vehiculos)
                {
                    if (ve.Patente == nombre)
                    {
                        Console.WriteLine("El vehiculo se encuentra en el taller");
                        Console.WriteLine("su costo es de " + ve.CostoReparacion);
                        Console.WriteLine("--------------------------------------------------------------------");
                    }
                }
            }
            else {
                Console.WriteLine("ese vehiculo no está en el taller");
                    }
            
        }
        public void EntregarVehiculo() {
            Console.WriteLine("ingrese la patente del vehiculo que quiere entregar");
            Console.WriteLine("--------------------------------------------------------------------");
            string nombre = Console.ReadLine();
            vehiculos.RemoveAll(e => e.Patente == nombre);
            Console.WriteLine("vehiculo entregado");
            Console.WriteLine("--------------------------------------------------------------------");
        }
        public void CalcularRecaudacionPendiente() {
            Console.WriteLine("los vehiculos actualmente en reparacion son: ");
            Console.WriteLine("--------------------------------------------------------------------");
            double total =0;
            foreach (Vehiculo ve in vehiculos) {
                Console.WriteLine("vehiculo: " + ve.Patente + ". Costo de la reparacion: " + ve.CostoReparacion);
                Console.WriteLine("--------------------------------------------------------------------");
                total = total + ve.CostoReparacion;
            }
            Console.WriteLine("la cantidad de vehiculos que todavia estan en reparacion es: " + vehiculos.Count);
            Console.WriteLine("El total a cobrar de la reparacion de todos los vehiculos del taller es de: " + total);
            Console.WriteLine("--------------------------------------------------------------------");

        }

        static void Main(string[] args)
        {
            GestionTaller t = new GestionTaller();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("1 para ingresar un vehiculo, 2 para buscar un vehiculo, 3 para entregar un vehiculo, 4 para ver el total de recaudacion pendiente ,5 para acabar el programa.");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------");
                if (numero < 1 || numero > 5)
                {
                    Console.WriteLine("Numero invalido, intente otra vez");
                    i--;
                }
                else if (numero == 1)
                {
                    t.IngresarVehiculo();
                    i--;
                }
                else if (numero == 2)
                {
                    t.BuscarVehiculo();
                    i--;
                }
                else if (numero == 3)
                {
                    t.EntregarVehiculo();
                    i--;
                }
                else if (numero == 4)
                {
                    t.CalcularRecaudacionPendiente();
                    i--;
                }
                else if (numero == 5)
                { }
            }
            Console.ReadKey();
        }
    }
}
