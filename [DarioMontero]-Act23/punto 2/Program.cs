using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    class Dron {
        private string codigo;
        private int bateria;

        public string Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public int Bateria
        {
            set { bateria = value; }
            get { return bateria; }
        }
        public Dron(string cod, int bat) {
            bateria = bat;
            codigo = cod;
        }
    }
    class CentroControl
    {
        List<Dron> Drones = new List<Dron>();

        public CentroControl() {
            string nombre;
            int bateria =0 ;
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("Ingrese el nombre del Dron");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la bateria que tiene el dron, tiene que ser mayor a 0 y menor a 100");
                for (int f = 0; f < 1; f++)
                {
                    bateria = int.Parse(Console.ReadLine());
                    if (bateria < 0 || bateria > 100)
                    {
                        Console.WriteLine("Bateria invalida, intente de nuevo");
                        f--;
                    }       
                }
                Dron dron = new Dron(nombre, bateria);
                Drones.Add(dron);
            }
        }
        public void ListarFlota() {
            foreach (Dron d in Drones) {
                Console.WriteLine("Codigo del dron: " + d.Codigo + ". Bateria del dron: " + d.Bateria);
            }
        }
        public void RemoverDronesBajos() {
            for (int i = Drones.Count-1; i > 0; i--) {
                if (Drones[i].Bateria < 15) {
                    Console.WriteLine("el dron con el codigo " + Drones[i].Codigo + " tiene una bateria de " + Drones[i].Bateria + " y necesita mantenimiento urgentemente");
                Drones.RemoveAt(i);
                }
            }
        }
        public void MostrarDronesRestantes() {
            foreach (Dron d in Drones) {
                Console.WriteLine("los drones que quedan activos son");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
