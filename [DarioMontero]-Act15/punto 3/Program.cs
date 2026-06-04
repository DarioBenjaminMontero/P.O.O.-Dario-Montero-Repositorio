using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    class ReservaNatural {
        private string nombreReserva;
        private int[,] avistamientos;

        public ReservaNatural() {
            string linea;
            avistamientos = new int[3, 3];
            Console.WriteLine("escribe el nombre de la reserva: ");
            nombreReserva = Console.ReadLine();
            for (int i = 0; i < avistamientos.GetLength(0); i++) {
                for (int f = 0; f < avistamientos.GetLength(1); f++) {
                    Console.WriteLine("escribe por favor el numero de avistamientos que se hicieron en el sector de la fila numero " + i + " con la columna numero " + f);
                    linea = Console.ReadLine();
                    avistamientos[i, f] = int.Parse(linea);
                }
            }
        }

        public string devolverNombre() {
            return nombreReserva;
        }
        public int[,] devolverAvistamientos() { 
        return avistamientos;
        }
    }

    class CentroEcologico
    {
        ReservaNatural[] reservas;

        public CentroEcologico() {
            reservas = new ReservaNatural[3];
            for (int i = 0; i < reservas.Length; i++) {
                reservas[i] = new ReservaNatural();
            }
        }

        public void mostrarAvistamientos() {
            int sumaTotal = 0;
            for (int i = 0; i < reservas.Length; i++) {
                sumaTotal = 0;
                int[,]avistamientos = new int[3, 3];
                avistamientos = reservas[i].devolverAvistamientos();
                for (int f = 0; f < avistamientos.GetLength(0); f++) {
                    for (int y = 0; y < avistamientos.GetLength(1); y++) {
                        sumaTotal += avistamientos[f, y];
                    }                
                }
                Console.WriteLine("la reserva " + reservas[i].devolverNombre() + " tuvo " + sumaTotal + " avistamientos totales");
            }
        }

        public void masAvistamientos() {
            int mayor = -1;
            int filaMayor =-1;
            int columnaMayor =-1;
            string nombreReserva = "";
            for (int i = 0; i < reservas.Length; i++)
            {
                int[,] avistamientos = new int[3, 3];
                avistamientos = reservas[i].devolverAvistamientos();
                
                for (int f = 0; f < avistamientos.GetLength(0); f++)
                {
                    for (int y = 0; y < avistamientos.GetLength(1); y++)
                    {
                        if (avistamientos[f, y] > mayor) {
                        mayor = avistamientos[f, y];
                            filaMayor = f;
                            columnaMayor = y;
                            nombreReserva = reservas[i].devolverNombre();
                        }
                    }
                }
            }

            Console.WriteLine("la reserva " + nombreReserva + " tuvo la cantidad mas grande de todas las reservas con " + mayor + " y fue en la fila " + filaMayor + " y columna " + columnaMayor);
        }

        static void Main(string[] args)
        {
            CentroEcologico centro = new CentroEcologico();
            centro.mostrarAvistamientos();
            centro.masAvistamientos();
            Console.ReadKey();
        }
    }
}
