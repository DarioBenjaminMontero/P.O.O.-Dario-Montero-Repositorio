using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act24
{
    internal class Program
    {
        /*
        public class Cuenta
        {
            public string Titular { get; set; }
            public decimal Cantidad { get; set; }

            public Cuenta(string titular, decimal cantidad)
            {
                Titular = titular;
                Cantidad = cantidad;
            }

            public void ingresar(double cantidad)
            {
                Console.Write("Ingrese una cantidad a la cuenta: ");

                string dato
            }

            public void retirar(double cantidad)
            {

            }
        }
        */

        class Capturador
        {
            public void PedirDato()
            {
                Console.Write("Por favor, ingresa un dato: ");


                string datoIngresado = Console.ReadLine();

                Console.WriteLine($"El dato que ingresaste en la consola es: {datoIngresado}");
            }
        }
        static void Main(string[] args)
        {
            Capturador miCapturador = new Capturador();
            miCapturador.PedirDato();
        }
    }
}
