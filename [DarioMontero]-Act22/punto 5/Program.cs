using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace punto_5
{

    class Carrera {

        private int codigo;
        private DateTime horaInicio, horaFin;
        private List<Corredor> corredores = new List<Corredor>();

        public int Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        private DateTime HoraFin
        {
            set { }
        }

        public Carrera() {

            Console.WriteLine("escribe el codigo de la carrera");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("escribe la hora de inicio");
            int hora = int.Parse(Console.ReadLine());
            horaInicio = new DateTime(2026, 7, 3, hora, 00, 00);
            Console.WriteLine("escribe la hora de Fin");
            hora = int.Parse(Console.ReadLine());
            horaFin = new DateTime(2026, 7, 3, hora, 00, 00);
        }
        public Carrera(int codigo, int horaInicio, int horaFin) {
            this.codigo = codigo;
            this.horaInicio = new DateTime(2026, 7, 3, horaInicio, 00, 00);
            this.horaFin = new DateTime(2026, 7, 3, horaFin, 00, 00);
        }

        public void agregarCorredor(Corredor corredor){
            corredores.Add(corredor);
        }
        public TimeSpan calcularDuracion() {
            TimeSpan duracion = horaFin - horaInicio;
            return duracion;
        }
    }
    class Corredor
    {
        private int numeroDorsal;
        private string nombre;
        TimeSpan tiempoTotal;
        static void Main(string[] args)
        {
        }
    }
}
