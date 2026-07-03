using System;
using System.Collections.Generic;

namespace simulacro
{
    public interface IBonificable
    {
        decimal CalcularBono();
    }

    abstract class Empleado
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }

        public Empleado (string nombre, decimal salariobase)
        {
            Nombre = nombre;
            SalarioBase = salariobase;
        }

        public abstract void Trabajar();
        public  void MostrarDetalles()
        {
            Console.WriteLine($"Nombre :{Nombre} - Salario{SalarioBase}");
        }

    }

    class Gerente: Empleado, IBonificable
    {
        public Gerente(string nombre, decimal salariobase) : base(nombre, salariobase)
        {
        }

        public override void Trabajar()
        {
            Console.WriteLine($"Planificado la estrategia");
        }

        public decimal CalcularBono()
        {
            return SalarioBase * 0.20m;
        }
    }

    class Desarrollador : Empleado 
    {
        public Desarrollador (string nombre, decimal salariobase) : base (nombre, salariobase)
        {

        }

        public override void Trabajar()
        {
            Console.WriteLine("Escribiendo el codigo");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado>empleados = new List<Empleado>();

            empleados.Add(new Gerente("Juan", 10000));
            empleados.Add(new Desarrollador("Pedro", 400));

            foreach ( Empleado e in empleados)
            {
                e.Trabajar();
                e.MostrarDetalles();
            
            if(e is IBonificable bonificable)
                {
                    Console.WriteLine($"Bono: {bonificable.CalcularBono()}");
                }

                Console.WriteLine();
            }
        }
    }
}
