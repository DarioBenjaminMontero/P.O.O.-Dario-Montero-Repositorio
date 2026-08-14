using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{

    class Medicamento {
        private string nombre;
        private int stock;
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int Stock {
            set { stock = value; }
            get { return stock; }
        }
        public Medicamento(string nom, int stk) {
            nombre = nom;
            stock = stk;
        }
    }
    class ControlFarmacia
    {
        List<Medicamento> medicamentos = new List<Medicamento>();

        public ControlFarmacia() {
            string nombre, linea;
            int stock;
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("Escriba el nombre del medicamento a agregar");
                nombre = Console.ReadLine();
                Console.WriteLine("Escriba el stock que tiene ese medicamento.");
                linea = Console.ReadLine();
                stock = int.Parse(linea);
                Medicamento m = new Medicamento(nombre, stock);
                medicamentos.Add(m);
            }
        }
        public void ListarStock() {
            foreach (Medicamento m in medicamentos) {
                Console.WriteLine("Medicamento: " + m.Nombre + ". Stock disponible: " + m.Stock);
            } 
        }
        public void RemoverAgotados() {
            medicamentos.RemoveAll(m => m.Stock == 0);
            Console.WriteLine("Todos los medicamento cuyo stock era 0 fueron borrados del listado.");
        }
        public void MostrarMedicamentosDisponibles() {
            Console.WriteLine("medicamentos restantes: ");
            int total = 0;
            foreach (Medicamento m in medicamentos)
            {
                Console.WriteLine("Medicamento: " + m.Nombre + ". Stock disponible: " + m.Stock);
                
            }
            Console.WriteLine("La cantidad total de medicamentos que hay es: " + medicamentos.Count);
        }

        static void Main(string[] args)
        {
            ControlFarmacia c = new ControlFarmacia();
            c.ListarStock();
            Console.WriteLine("--------------------------------------------");
            c.RemoverAgotados();
            Console.WriteLine("--------------------------------------------");
            c.MostrarMedicamentosDisponibles();
            Console.WriteLine("--------------------------------------------");
            Console.ReadKey();
        }
    }
}
