using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Punto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
//$500, realizar un programa que lea los sueldos que cobra cada empleado e
//informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
//de $300.Además el programa deberá informar el importe que gasta la empresa
//en sueldos al personal.
            int empleados, x, sueldo, entre100y300, masde300, sumadesueldos;
            string linea;
            Console.WriteLine("escribe la cantidad de usuarios que hay en la empresa: ");
            linea = Console.ReadLine();
            empleados = int.Parse(linea);

            x = 1;
            entre100y300 = 0;
            masde300 = 0;
            sumadesueldos = 0;

            while (x <= empleados) {

                Console.WriteLine("Escribe el sueldo del empleado" + x + ": ");
                linea = Console.ReadLine();
                sueldo = int.Parse(linea);

                if (sueldo > 100 && sueldo <= 500)
                {

                    if (sueldo > 100 && sueldo <= 300)
                    {

                        entre100y300 = entre100y300 + 1;

                    }
                    if (sueldo > 300)
                    {

                        masde300 += 1;
                    }

                    sumadesueldos = sumadesueldos + sueldo;

                }
                else {
                    Console.WriteLine("el sueldo no es valido.");
                }
                x = x + 1;
            };

            Console.WriteLine("la cantidad de empleados que cobran entre 100 y 300 dolares es de " + entre100y300);
            Console.WriteLine("la cantidad de empleados que cobran mas de 300 dolares es de " + masde300);
            Console.WriteLine("la cantidad de dinero que la empresa gasta en sueldos es de " + sumadesueldos);
            Console.ReadKey();






        }
    }
}
