using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    class Plato {
        private string nombrePlato;
        private double precio;
        public string NombrePlato
        {
            set { nombrePlato = value; }
            get { return nombrePlato; }
        }
        public double Precio
        {
            set { precio = value; }
            get { return precio; }
        }
        public Plato(string nom, double pre) {
            nombrePlato = nom;
            precio = pre;
        }
    }
    class GestionComandas 
    {
        List<Plato> platos = new List<Plato>();
        public void AgregarPlato() {
            Console.WriteLine("Por favor ingrese el nombre del plato");
            string nombre, linea;
            double precio;

            nombre = Console.ReadLine();
            Console.WriteLine("ahora escriba el precio");
            linea = Console.ReadLine();
            precio = double.Parse(linea);
            Plato plato = new Plato(nombre, precio);
            platos.Add(plato);
        }
        public void MostrarComanda() {
            Console.WriteLine("platos pedidos");
            foreach (Plato p in platos) { 
            Console.WriteLine("nombre del plato: " + p.NombrePlato + ". Precio: " + p.Precio);
            }
            Console.WriteLine("la cantidad total de platos pedidos es: " + platos.Count);
        }
        public void CalcularTotalMesa() {
            double total = 0;
            foreach (Plato p in platos) {
                total += p.Precio;
            }
            Console.WriteLine("el precio total que hay en la mesa es de: " + total);
        }
        public void CancelarPlato() {
            string nombre;
            bool existe = false;
            Console.WriteLine("Ingrese el nombre de un plato para eliminar");
            nombre = Console.ReadLine();
            for (int i = 0; i < platos.Count; i++) {
                if (platos[i].NombrePlato == nombre)
                {
                    existe = true;
                }
                else {
                    existe = false;
                }
            }
            if (existe)
            {
                platos.RemoveAll(e => e.NombrePlato == nombre);
                existe = false;
                Console.WriteLine("El plato ha sido eliminado");
            }
            else {
                Console.WriteLine("no se encontro el plato");
            } 
        }
        static void Main(string[] args)
        { 
            GestionComandas g = new GestionComandas();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("1 para agregar platos, 2 para mostrar comanda, 3 para calcular el total de la mesa, 4 para Remover un plato ,5 para acabar el programa.");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------");
                if (numero < 1 || numero > 5)
                {
                    Console.WriteLine("Numero invalido, intente otra vez");
                    i--;
                }
                else if (numero == 1)
                {
                    g.AgregarPlato();
                    i--;
                }
                else if (numero == 2)
                {
                    g.MostrarComanda();
                    i--;
                }
                else if (numero == 3)
                {
                    g.CalcularTotalMesa();
                    i--;
                }
                else if (numero == 4)
                {
                    g.CancelarPlato();
                    i--;
                }
                else if (numero == 5)
                { }
            }
            Console.ReadKey();
        }
    }
}
