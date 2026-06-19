using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    partial class Libro
    {

        public void resumen() {
            Console.WriteLine("el titulo es: " + Titulo + ". el autor del libro es: " + Autor + " y tiene " + Paginas + " paginas");
            if (Paginas < 100)
            {
                Console.WriteLine("es un libro corto");
            }
            else {
                Console.WriteLine("es un libro largo");
            }
        }

    }
}
