using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{

    class Vehiculo {
        string marca;
        float velocidadMaxima;
        public Vehiculo() {
        
        }


    }

    class Moto : Vehiculo 
    {
        private int cilindrada;
    }

    class Auto : Vehiculo 
    {
        private int numeroPuertas;
        public Auto():base(numeroPuertas) {
        
        }

        static void Main(string[] args)
        {
        }
    }
}
