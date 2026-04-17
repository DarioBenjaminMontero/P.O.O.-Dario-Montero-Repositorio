using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    internal class Negocio
    { /*2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
vectores paralelos, ordenar los datos de mayor a menor según las ventas,
imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
el que menos vendió de los 5 empleados.*/
        private string[] vendedores;
        private int[] ventas;
        private int ventasMinimas;

        public void cargar() {
            vendedores = new string[5];
            ventas = new int[5];
            string linea;
            for (int i = 0; i < vendedores.Length; i++) {
                Console.WriteLine("escrtibe el nombre de un vendedor por favor");
                linea = Console.ReadLine();
                vendedores[i] = linea;
                Console.WriteLine("escribe la cantidad de ventas de este vendedor por favor");
                linea = Console.ReadLine();
                ventas[i] = int.Parse(linea);
            }
        
        }

        public void ordenSegunVentas() {
            int auxVenta;
            string auxVendedor;
            for (int k = 0; k < ventas.Length; k++) {

                for (int f = 0; f < ventas.Length - 1 - k; f++) {
                    if (ventas[f] < ventas[f+1]) {
                        auxVenta = ventas[f + 1];
                        ventas[f + 1] = ventas[f];
                        ventas[f] = auxVenta;
                        auxVendedor = vendedores[f + 1];
                        vendedores[f + 1] = vendedores[f];
                        vendedores[f] = auxVendedor;
                    }
                }
            }
            ventasMinimas = ventas[ventas.Length - 1];
        }

        public void Imprimir(){

            Console.WriteLine("Estos son todos los vendedores:");
            for (int i = 0; i < vendedores.Length; i++) {
                Console.WriteLine("el vendedor " + vendedores[i] + " hizo " + ventas[i] + " ventas");
            }
            for (int i = 0; i < vendedores.Length; i++) {
                if (ventas[i] == ventasMinimas) {

                    Console.WriteLine("el vendedor " + vendedores[i] + " fue uno de los que menos vendió");
                }
            
            }
        
        }

        static void Main(string[] args)
        {

            Negocio negocio = new Negocio();
            negocio.cargar();
            negocio.ordenSegunVentas();
            negocio.Imprimir();
            Console.ReadKey();
        }
    }
}
