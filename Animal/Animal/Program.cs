using System;
using System.Collections.Generic;

namespace Vehiculo
{
    class Motor
    {
        public int Caballos { get; set; }
        public int Modelos {  get; set; }
    }

    class miAuto
    {
        Motor motor = new Motor();

        miAuto()
            {
            motor.Caballos = 150;
            motor.Modelos = 2025;
        }
    }

    class Conductor
    {
        public string Nombre { get; }
        public string Edad {  get; }

        public Conductor(string nombre , string edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }

    class Colectivo
    {
        Colectivo(Conductor conductor)
        {
            Conductor conductor = new Conductor(conductor);
            Colectivo colectivo = new Colectivo(conductor);
        }
    }
}