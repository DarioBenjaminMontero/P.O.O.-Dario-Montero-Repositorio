using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{

    class Documento
    {
        private string nombreArchivo;
        private int cantidadDePaginas;
        public string NombreArchivo
        {
            set { nombreArchivo = value; }
            get { return nombreArchivo; }

        }
        public int CantidadDePaginas
        {
            set { cantidadDePaginas = value; }
            get { return cantidadDePaginas; }
        }
        public Documento(string nom, int pag)
        {
            nombreArchivo = nom;
            cantidadDePaginas = pag;
        }

    }
    class ServidorImpresion
    {
        List<Documento>Documentos = new List<Documento>();
        public void AgregarDocumento() {
            string linea, nombre;
            int cantPaginas;
            Console.WriteLine("Por favor, ingrese el nombre del archivo");
            nombre = Console.ReadLine();
            Console.WriteLine("Por favor, ingrese el numero de paginas que tiene el archivo");
            linea = Console.ReadLine();
            cantPaginas = int.Parse(linea);
            Documento documento = new Documento(nombre, cantPaginas);
            Documentos.Add(documento);
            Console.WriteLine("Agregado exitosamente el archivo " + nombre + " que tiene " + cantPaginas);
        }
        public void ImprimirSiguiente() {
            if (Documentos.Count == 0)
            {
                Console.WriteLine("no hay documentos pendientes a imprimir");
            }
            else {
                Console.WriteLine("El documento que se imprimió fue: " + Documentos[0].NombreArchivo);
                Console.WriteLine("El documento cuenta con " + Documentos[0].CantidadDePaginas + " paginas");
                Documentos.RemoveAt(0);
            }
        }
        public void MostrarColaPendiente() {
            if (Documentos.Count == 0)
            {
                Console.WriteLine("no hay documentos pendientes");
            }
            else {
                int cantidadDePaginas = 0;
                foreach (Documento d in Documentos)
                {
                    Console.WriteLine("Documento: " + d.NombreArchivo + ". Cantidad de Paginas: " + d.CantidadDePaginas);
                    cantidadDePaginas = cantidadDePaginas + d.CantidadDePaginas;
                }
                Console.WriteLine("la cantidad de Paginas en total son: " + cantidadDePaginas);
                Console.WriteLine("la cantidad de Documentos pendientes son: " + Documentos.Count);
            }
            
        }
        static void Main(string[] args)
        {
            ServidorImpresion servidor = new ServidorImpresion();
            for (int i = 0; i < 1; i++) {
                Console.WriteLine("1 para agregar, 2 para imprimir el siguiente documento, 3 para mostrar los pendientes, 4 para acabar el programa.");
                int numero = int.Parse(Console.ReadLine());
                if (numero < 1 || numero > 4)
                {
                    Console.WriteLine("Numero invalido, intente otra vez");
                    i--;
                }
                else if (numero == 1) {
                    servidor.AgregarDocumento();
                    i--;
                }
                else if (numero == 2)
                {
                    servidor.ImprimirSiguiente();
                    i--;
                }
                else if (numero == 3)
                {
                    servidor.MostrarColaPendiente();
                    i--;
                }
                else if (numero == 4)
                {}
            }
            Console.ReadKey();
            
        }
    }
}
