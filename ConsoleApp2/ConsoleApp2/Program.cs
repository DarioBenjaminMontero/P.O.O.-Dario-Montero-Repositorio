using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace plactica
{
    class Vehiculo
    {
        public string Marca { get; }
        public int VelocidadActual { get; private set; }
        public int LimiteVelocidad { get; }

        public Vehiculo (string marca, int velocidadActual , int LimiteVelocidad)
        {
            Marca = marca;
            VelocidadActual = velocidadActual;
            LimiteVelocidad = 0;
        }

        public virtual string Acelelar (int kms)
        {
            VelocidadActual += kms;

            if(VelocidadActual > LimiteVelocidad)
            {
                VelocidadActual = LimiteVelocidad;
            }

            return $"Avanzando a {VelocidadActual} km/h";
        }



    }

    class Auto : Vehiculo
    {
        public string Modelo {  get; }
        public Auto(string marca , string modelo) : base(marca , 100)
        {
            Modelo = modelo ;
        }
        public override string Acelelar(int kms)
        {
            string mensaje = base.Acelelar(kms);

            if(VelocidadActual == LimiteVelocidad)
            {
                return $"ya llego el Limite !! Avanzado a {VelocidadActual} km/h";
            }

            return mensaje ;

        }
        
    }

    class Moto : Vehiculo
    {
        public string Cilindrada { get; }
        public Moto(string marca, string cilindrada) : base(marca, 120)
        {
            Cilindrada = cilindrada;
        }

        public override string Acelelar(int kms)
        {
            string mensaje = base.Acelelar(kms);

            if(VelocidadActual == LimiteVelocidad)
            {
                return $"Atencion ! Avazando a {VelocidadActual} km/h";
            }
            return mensaje;
        }
        
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo[] flota =
            {
                new Auto("Jeep" , "223"),
                new Auto("Audi", "353"),
               new Moto("Nose" , "2563"),
               new Moto("LOSE" , "2626")

            };

            Console.WriteLine(""


        }
    }
}
