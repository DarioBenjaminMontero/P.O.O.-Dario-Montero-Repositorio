using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
finalizar al ingresar un valor negativo en el número de cuenta.
Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
informe:
a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
que:
Estado de la cuenta:
○ “Acreedor” si el saldo es &gt;0.
○ “Deudor” si el saldo es &lt;0.
○ “Nulo” si el saldo es =0.
b) La suma total de los saldos acreedores.*/

            string texto, linea;
            int saldo = 0;
            int suma = 0;
            int numeroCuenta;
            texto = "";
            do
            {
                Console.WriteLine("Ingresa el numero de cuenta, si es negativo entonces termina: ");
                linea = Console.ReadLine();
                numeroCuenta = int.Parse(linea);
                if (numeroCuenta >= 0) {
                    texto = texto + "numero de Cuenta: ";
                    texto = texto + numeroCuenta.ToString();
                    Console.WriteLine("escribe un saldo para este Numero de cuenta");
                    linea = Console.ReadLine();
                    saldo = int.Parse(linea);
                    if (saldo > 0) {
                        texto += ". Estado de cuenta: acreedor. \n ";
                        suma = suma + saldo;

                    }
                    if (saldo < 0)
                    {
                        texto += ". Estado de cuenta: deudor.\n ";

                    }
                    if (saldo == 0)
                    {
                        texto += ". Estado de cuenta: nulo. \n";

                    }

                    

                }




            } while (numeroCuenta >= 0);

            Console.WriteLine(texto);
            Console.WriteLine(suma);

            Console.ReadKey();


        }
    }
}
