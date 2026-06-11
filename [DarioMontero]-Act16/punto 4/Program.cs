using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
    class Animal {
        private string especie;
        public Animal() {
            especie = "mamifero";

            Console.WriteLine("la especie es " + especie + ". esta informacion viene de Animal");
        }
        public string Especie {
            set { especie = value; } get { return especie; }
        }
    }
    class Mamifero : Animal{
       private string tipoAlimentacion;

        public Mamifero() {
            tipoAlimentacion = "comida xd";
            Console.WriteLine("el tipo de alimentacion es " + tipoAlimentacion + ". esta informacion viene de Mamifero");
        }

        public string TipoAlimentacion
        {
            set { tipoAlimentacion = value; }
            get { return tipoAlimentacion; }
        }
    }

    internal class Perro : Mamifero
    {
        private string nombre;
        public Perro() {
            nombre = "chufo";
            Console.WriteLine("el nombre es " + nombre + ". esta informacion viene de Perro");
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        static void Main(string[] args)
        {
            Animal perro = new Perro();
            Console.ReadKey();
        }
    }
}
