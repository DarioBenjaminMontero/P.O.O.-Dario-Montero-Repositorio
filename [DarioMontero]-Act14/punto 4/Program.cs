using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{

    class Articulo
    {
        private string nombreArticulo;
        private float precio;
        private int stockActual;

        public Articulo()
        {
            string linea;
            Console.WriteLine("escribe el nombre del producto");
            nombreArticulo = Console.ReadLine();
            Console.WriteLine("escribe su precio");
            linea = Console.ReadLine();
            precio = float.Parse(linea);
            Console.WriteLine("escrib el stock restante");
            linea = Console.ReadLine();
            stockActual = int.Parse(linea);
        }

        public string devolverNombre()
        {
            return nombreArticulo;
        }
        public float devolverPrecio()
        {
            return precio;
        }
        public int devolverStockActual()
        {
            return stockActual;
        }
    }


    class Sucursal
    {
        private Articulo[] articulos;
        private int numeroSucursal;
        public Sucursal()
        {
            string linea;
            articulos = new Articulo[3];
            Console.WriteLine("escribe el numero de la sucursal");
            linea = Console.ReadLine();
            numeroSucursal = int.Parse(linea);
            for (int i = 0; i < articulos.Length; i++)
            {
                articulos[i] = new Articulo();
            }
        }

        public void listaArticulos()
        {
            for (int i = 0; i < articulos.Length; i++)
            {
                Console.WriteLine("articulo: " + articulos[i].devolverNombre() + " precio total en el inventario: " + (articulos[i].devolverPrecio() * articulos[i].devolverStockActual()));
            }
        }

        public void articuloMasCaro()
        {
            float precioMasCaro = articulos[0].devolverPrecio();
            for (int i = 0; i < articulos.Length; i++)
            {
                if (articulos[i].devolverPrecio() > precioMasCaro)
                {
                    precioMasCaro = articulos[i].devolverPrecio();
                }
            }

            Console.WriteLine("el/los articulos con el precio mas caro son: ");
            for (int i = 0; i < articulos.Length; i++)
            {
                if (articulos[i].devolverPrecio() == precioMasCaro)
                {
                    Console.WriteLine(articulos[i].devolverNombre() + " con un precio de " + precioMasCaro);
                }
            }
        }

        public void reposicion()
        {
            for (int i = 0; i < articulos.Length; i++)
            {
                if (articulos[i].devolverStockActual() < 5)
                {
                    Console.WriteLine("el articulo " + articulos[i].devolverNombre() + " de la sucursal " + numeroSucursal + " necesita ser repuesto ");
                }
            }
        }
        static void Main(string[] args)
        {
            Sucursal sucursal = new Sucursal();
            sucursal.listaArticulos();
            sucursal.articuloMasCaro();
            sucursal.reposicion();
            Console.ReadKey();
        }

    }
}
