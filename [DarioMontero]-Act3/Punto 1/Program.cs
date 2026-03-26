using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.
            int dia, mes, año;
            string linea;
            Console.Write("Escribe un dia: ");
            linea = Console.ReadLine();
            dia = int.Parse(linea);
            Console.Write("Escribe un mes: ");
            linea = Console.ReadLine();
            mes = int.Parse(linea);
            Console.Write("Escribe un año: ");
            linea = Console.ReadLine();
            año = int.Parse(linea);

            DateTime fecha = new DateTime(año, mes, dia);
            if (mes == 12 && dia == 25){
                Console.Write("Es navidad");
            }
            Console.ReadKey();
        }
    }
}
