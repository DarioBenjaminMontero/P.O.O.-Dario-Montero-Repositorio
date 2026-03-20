using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Escribir un programa que lea el peso (en kilogramos)
            //y la altura (en metros) de una persona, y mostrar por pantalla su índice de masa corporal (IMC) (El IMC se calcula dividiendo el peso entre el cuadrado de la altura).

            float peso, altura, cuadradoAltura, imc;
            string linea;
            Console.WriteLine("ingresar peso en kilogramos: ");
            linea= Console.ReadLine();
            peso = int.Parse(linea);
            
            Console.WriteLine("Ingresar altura en metros: ");
            linea = Console.ReadLine();
            altura = float.Parse(linea);

            cuadradoAltura = (float)(Math.Pow(altura, 2));

            imc = peso / cuadradoAltura;
            Console.WriteLine("el indice de masa corporal es: " + imc);
            Console.ReadKey();

        }
    }
}
