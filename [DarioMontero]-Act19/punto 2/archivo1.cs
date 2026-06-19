using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    partial class Libro
    {
        private string titulo, autor;
        private int paginas;

        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }
        }
        public string Autor
        {
            set { autor = value; }
            get { return titulo; }
        }
        public int Paginas
        {
            set { paginas = value; }
            get { return paginas; }
        }
        public Libro() {
            string linea;
            Console.WriteLine("escribe el Titulo del libro");
            titulo = Console.ReadLine();
            Console.WriteLine("escribe el nombre del autor del libro");
            autor = Console.ReadLine();
            Console.WriteLine("ahora escribi la cantidad de paginas (tiene que ser mayor a 10)");
            while (paginas < 10) { 
            linea = Console.ReadLine();
                paginas = int.Parse(linea);
                if (paginas < 10) {
                    Console.WriteLine("hay menos de 10 paginas");
                }
            }
           
        }
        
    }
}
