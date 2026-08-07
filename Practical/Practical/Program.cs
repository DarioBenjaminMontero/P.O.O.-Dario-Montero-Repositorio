using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_23___parte_2
{
    internal class Program
    {
        class Alumno
        {
            public string Nombre { get; set; }
            public string Materia { get; set; }

            public Alumno(string nombre, string materia)
            {
                Nombre = nombre;
                Materia = materia;
            }
        }

        static void Main(string[] args)
        {
            var alumnos = new List<Alumno>
            {
                new Alumno("Ana", "Matemáticas"),
                new Alumno("Luis", "Historia"),
                new Alumno("Carlos", "Matemáticas"),
                new Alumno("Marta", "Historia"),
                  new Alumno("Juan", "Historia")
            };

            var agrupadosPorCurso = alumnos.OrderBy(a => a.Nombre).GroupBy(a => a.Materia);

            foreach (var grupo in agrupadosPorCurso)
            {
                Console.WriteLine($"Curso: {grupo.Key}");
                foreach (var alumno in grupo)
                {
                    Console.WriteLine($" - {alumno.Nombre}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("//Aggregate");


            var numeros = new List<int> { 1, 2, 3, 4, 5 };


            // 1. Replicar un Sum() con Aggregate (para entender la lógica)
            //int suma = numeros.Aggregate(0, (acumulado, siguiente) => acumulado + siguiente); // Resultado: 15
            int suma = numeros.Aggregate((acumulado, siguiente) => acumulado + siguiente); // Resultado: 15
            Console.WriteLine(suma);

            // 2. Multiplicar todos los números (producto)
            int producto = numeros.Aggregate(1, (acumulado, siguiente) => acumulado * siguiente); // Resultado: 120
            Console.WriteLine(producto);

            // 3. Concatenar strings en un solo texto
            var palabras = new List<string> { "C#", "es", "genial" };
            string frase = palabras.Aggregate((acc, next) => $"{acc} {next}"); // Resultado: "C# es genial"
            Console.WriteLine(frase);


            Console.WriteLine();
            Console.WriteLine("//Any All");
            numeros = new List<int> { 2, 4, 6, 8, 10 };

            bool tieneNegativos = numeros.Any(n => n < 0);        // false
            bool todosSonPares = numeros.All(n => n % 2 == 0);    // true

            Console.WriteLine($"¿Tiene negativos?: {tieneNegativos}");
            Console.WriteLine($"¿Todos son pares?: {todosSonPares}");
            Console.ReadKey();



        }
    }
}