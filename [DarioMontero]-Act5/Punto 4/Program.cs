using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se cuenta con la siguiente información:
● Las edades de 20 estudiantes del turno mañana.
● Las edades de 30 estudiantes del turno tarde.
● Las edades de 15 estudiantes del turno noche.
Las edades de cada estudiante deben ingresarse por teclado.
a) Obtener el promedio de las edades de cada turno (tres promedios)
b) Imprimir dichos promedios (promedio de cada turno)
c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
promedio de edades menor.*/
            int i;
            float valor, suma;
            float promedioMañana, promedioTarde, promedioNoche;
            string linea;
            valor = 0;
            suma = 0;
            for (i = 1; i <= 20; i++) {
                Console.WriteLine("Escribe la edad del alumno numero " + i + " de la mañana");
                linea = Console.ReadLine();
                valor = float.Parse(linea);
                suma += valor;
            }
            promedioMañana = suma / 20;

            suma = 0;
            for (i = 1; i <= 30; i++) {

                Console.WriteLine("escribe la edad del alumno numero" + i + " de la tarde");
                linea = Console.ReadLine();
                valor = float.Parse(linea);
                suma += valor;
            }
            promedioTarde = suma / 30;
            suma = 0;
            for (i = 1; i <= 15; i++) {

                Console.WriteLine("escribe la edad del alumno numero " + i + " de la noche");
                linea = Console.ReadLine();
                valor = float.Parse(linea);
                suma += valor;

            }
            promedioNoche = suma / 15;

            Console.WriteLine(promedioMañana);
            Console.WriteLine(promedioTarde);
            Console.WriteLine(promedioNoche);

            if (promedioMañana < promedioNoche && promedioMañana < promedioTarde)
            {
                Console.WriteLine("los que tienen menor promedio de edad son los de la mañana");
            }
            else if (promedioTarde < promedioMañana && promedioTarde < promedioNoche)
            { 
                Console.WriteLine("los que tienen menor promedio de edad son los de la tarde");
            }
            else if (promedioNoche < promedioMañana && promedioNoche < promedioTarde)
            {
                Console.WriteLine("los que tienen menor promedio de edad son los de la noche");
            }

            Console.ReadKey();
        }
    }
}
