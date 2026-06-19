using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace punto_2
{
    internal class Program
    {
        private Libro[] libros;
        public Program() {
            libros = new Libro[2];
            libros[0] = new Libro();
            libros[1] = new Libro();
            libros[0].resumen();
            libros[1].resumen();
        }
        public void masExtenso() {
            if (libros[0].Paginas > libros[1].Paginas)
            {
                Console.WriteLine("el libro mas extenso es " + libros[0].Titulo + ". del autor: " + libros[0].Autor + " con " + libros[0].Paginas + "paginas");
            }
            else {
                Console.WriteLine("el libro mas extenso es " + libros[1].Titulo + ". del autor: " + libros[1].Autor + " con " + libros[1].Paginas + "paginas");
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.masExtenso();
            Console.ReadKey();


        }
    }
}
