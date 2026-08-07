using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_6
{

    class Libro {
        private string titulo;
        private int anioPublicacion;
        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }

        }
        public int AnioPublicacion
        {
            set { AnioPublicacion = value; }
            get { return anioPublicacion; }
        }
        public Libro(string tit, int anio) {
            titulo = tit;
            anioPublicacion = anio;
        }
    }
    class BibliotecaCentral 
    {
        List<Libro> libros = new List<Libro>();

        public void CargarCatalogo()
        {
            string linea;
            string titulo;
            int anio;
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Por favor, ingrese el titulo de un libro. El proceso se repetirá hasta que escriba 'FIN'");
                titulo = Console.ReadLine();
                if (titulo == "FIN")
                {
                    Console.WriteLine("carga terminada");
                }
                else {
                    Console.WriteLine("ahora escriba el año en el que se publicó");
                    linea = Console.ReadLine();
                    anio = int.Parse(linea);
                    Libro libro = new Libro(titulo, anio);
                    libros.Add(libro);
                    i--;
                }
            }
        }
        public void ListarCatalogo() {
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (Libro l in libros) {
                Console.WriteLine("Titulo: " + l.Titulo + ". Año de publicacion: " + l.AnioPublicacion);
                Console.WriteLine("--------------------------------------------------------------------");
            }
            Console.WriteLine("la cantidad total de libros en la biblioteca es de " + libros.Count);
        }
        public void FiltrarPorAnio() {
            Console.WriteLine("escribe un año, y se buscarán todos los titulos publicados antes de ese año.");
            int anio = int.Parse(Console.ReadLine());
            List<Libro> resultado = libros.FindAll(x => x.AnioPublicacion < anio);
            if (resultado.Count > 0)
            {
                foreach (Libro l in resultado)
                {
                    Console.WriteLine("Libro: " + l.Titulo + ". Año en el que se publicó: " + l.AnioPublicacion);
                }
            }
            else {
                Console.WriteLine("no hay un libro que cumpla con la solicitud");
            }
        }
        public void RemoverLibro() {
            Console.WriteLine("Ingrese el titulo del libro que desea remover.");
            string titulo = Console.ReadLine();
            Libro libro = libros.Find(x => x.Titulo == titulo);
            libros.Remove(libro);
            Console.WriteLine("Se ha removido el libro: " + libro.Titulo + " publicado en el año " + libro.AnioPublicacion);
        }


        static void Main(string[] args)
        {
            BibliotecaCentral b = new BibliotecaCentral();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("1 para cargar libros, 2 para listar el catalogo, 3 para filtrar por año, 4 para Remover un libro ,5 para acabar el programa.");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------");
                if (numero < 1 || numero > 5)
                {
                    Console.WriteLine("Numero invalido, intente otra vez");
                    i--;
                }
                else if (numero == 1)
                {
                    b.CargarCatalogo();
                    i--;
                }
                else if (numero == 2)
                {
                    b.ListarCatalogo();
                    i--;
                }
                else if (numero == 3)
                {
                    b.FiltrarPorAnio();
                    i--;
                }
                else if (numero == 4)
                {
                    b.RemoverLibro();
                    i--;
                }
                else if (numero == 5)
                { }
            }
            Console.ReadKey();
        }
    }
}
