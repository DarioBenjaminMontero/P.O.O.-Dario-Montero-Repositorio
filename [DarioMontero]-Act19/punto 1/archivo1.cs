using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    partial class ReservaHotel
    {
        private string nombreCliente, tipoHabitacion;
        private int cantidadNoches;
        public string NombreCliente
        {
            set { nombreCliente = value; }
            get { return nombreCliente; }
        }
        public int CantidadNoches
        {
            set { cantidadNoches = value; }
            get { return cantidadNoches; }
        }
        public string TipoHabitacion
        {
            set { tipoHabitacion = value; }
            get { return tipoHabitacion; }
        }
        public ReservaHotel() {
            string linea;
            Console.WriteLine("escribe el nombre del cliente: ");
            nombreCliente = Console.ReadLine();
            Console.WriteLine("escribe la cantidad de noches que el cliente reservó, el valor puesot debe ser mayor a 0");
            for (int i = 0; i < 1; i++) {
                linea = Console.ReadLine();
                cantidadNoches = int.Parse(linea);
                if (cantidadNoches > 0)
                {

                }
                else {
                    Console.WriteLine("la cantidad de noches debe ser estrictamente mayor a 0");
                    i--;
                }
            }
            Console.WriteLine("escribe el tipo de habitacion (simple, doble o suite)");
            
            for (int i = 0; i < 1; i++) {
                tipoHabitacion = Console.ReadLine();
                if (tipoHabitacion != "simple" && tipoHabitacion != "doble" && tipoHabitacion != "suite")
                {
                    Console.WriteLine("colocá simple, doble, o suite");
                    i--;
                }
            }
            totalAPagar();
        }

        

    }
}
