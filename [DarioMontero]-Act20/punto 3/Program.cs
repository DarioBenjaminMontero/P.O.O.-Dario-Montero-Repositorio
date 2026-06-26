using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class Program
    {

        

        static void Main(string[] args)
        {
            int[,] zonasArqueologicas;
            zonasArqueologicas = new int[3, 4];
            int[] totalPorZona;
            int total = 0;
            totalPorZona = new int[3];
            for (int i = 0; i < zonasArqueologicas.GetLength(0); i++) {
                Console.WriteLine("actualmente estás escrbiendo datos de la zona numero " + i);
                for (int f = 0; f < zonasArqueologicas.GetLength(1); f++) {
                    Console.WriteLine("escribe la cantidad de visitas que tuvo en el dia " + f);
                    zonasArqueologicas[i, f] = int.Parse(Console.ReadLine());
                    total = total + zonasArqueologicas[i, f];
                }
                totalPorZona[i] = total;
                total = 0;
            }
            for (int i = 0; i < zonasArqueologicas.GetLength(0); i++)
            {
                Console.Write("zona " + i + ": ");
                for (int f = 0; f < zonasArqueologicas.GetLength(1); f++)
                {
                    Console.Write( " | "+ zonasArqueologicas[i,f] +" visitas | ");
                }
                Console.WriteLine();
                
            }
            List<(string nombre, int visitas)> lista = new List<(string nombre, int visitas)>();

            for (int i = 0; i < zonasArqueologicas.GetLength(0); i++) {
                Console.WriteLine("escribe el nombre de la zona arqueologica numero " + i);
                lista.Add((nombre: Console.ReadLine(), visitas: totalPorZona[i]));
            }
            int mayor = lista[0].visitas;
            foreach (var espacio in lista) {
                Console.WriteLine("el nombre de la zona es " + espacio.nombre + " y su total de visitas es de " + espacio.visitas);
                if (espacio.visitas > mayor) { 
                mayor = espacio.visitas;
                }
            }
            foreach (var espacio in lista) {
                if (espacio.visitas == mayor) {
                    Console.WriteLine("la zona de nombre " + espacio.nombre + " tuvo la mayor cantidad de visitas con " + espacio.visitas);
                }
            }
                Console.ReadKey();
        }
    }
}
