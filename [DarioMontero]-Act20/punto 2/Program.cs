using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    class Paquete {
        private int codigo;
        private float peso;
        private string destino;
        public int Codigo {
            set { codigo = value; }
            get { return codigo; }
        }
        public float Peso
        {
            set { peso = value; }
            get { return peso; }
        }
        public string Destino
        {
            set { destino = value; }
            get { return destino; }
        }

        public Paquete()
        {
            string linea;
            Console.WriteLine("ingrese el codigo del paquete");
            linea  = Console.ReadLine();
            codigo = int.Parse(linea);
            Console.WriteLine("ingrese el peso del paquete ");
            linea = Console.ReadLine();
            peso = float.Parse(linea);
            Console.WriteLine("ingrese el destino");
            destino = Console.ReadLine();
        }
    }
    class Despachador
    {
        List<Paquete> paquetes;

        public void cargarPaquete() { 
        Paquete p = new Paquete();

        }
        static void Main(string[] args)
        {
            
        }
    }
}
