using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    class ClaseGimnasio
    {
        private string nombreClase;
        private DateTime horaInicio, horaFin;

        private int hora;
        private int minuto;
        private int segundo;

        public string NombreClase {

            set { nombreClase = value; }
            get { return nombreClase; }

        }

        public DateTime HoraInicio {

            set { horaInicio = value; }
            get { return horaInicio; }
        }
        public DateTime HoraFin
        {

            set { horaFin = value; }
            get { return horaFin; }
        }

        ClaseGimnasio(string nombre, int hora, int minuto, int segundo, int horaFinal, int minutoFinal, int segundoFinal)
        {
            this.nombreClase = nombre;
            this.hora = hora;
            this.minuto = minuto;
            this.segundo = segundo;

            horaInicio = new DateTime(2026, 7, 3, this.hora, this.minuto, this.segundo);

            horaFin = new DateTime(2026, 7, 3, horaFinal, minutoFinal, segundoFinal);



        }

        ClaseGimnasio() {
            Console.WriteLine("escribe el nombre del gym, bro");
            nombreClase = Console.ReadLine();
            Console.WriteLine("escribe la hora de inicio");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("escribe el minuto de inicio");
            minuto = int.Parse(Console.ReadLine());
            Console.WriteLine("escribe el segundo de inicio");
            segundo = int.Parse(Console.ReadLine());
            horaInicio = new DateTime(2026, 7, 3, hora, minuto, segundo);

            Console.WriteLine("escribe la hora del final");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("escribe el minuto final");
            minuto = int.Parse(Console.ReadLine());
            Console.WriteLine("escribe el segundo final");
            segundo = int.Parse(Console.ReadLine());

            horaFin = new DateTime(2026, 7, 3, hora, minuto, segundo);


        }

        public TimeSpan calcularTiempoDeClase() {

            TimeSpan tiempoClase = horaFin - horaInicio;
            return tiempoClase;
        }


        static void Main(string[] args)
        {
            ClaseGimnasio[] vector = new ClaseGimnasio[3];
            vector[0] = new ClaseGimnasio("esto tilin", 12, 30, 00, 14, 30, 00);
            vector[1] = new ClaseGimnasio("es la que va broder", 12, 30, 00, 15, 30, 00);
            vector[2] = new ClaseGimnasio();
            TimeSpan mayor = vector[0].calcularTiempoDeClase();
            DateTime menor = vector[0].HoraInicio;
            for (int i = 0; i < vector.Length; i++) {
                if (vector[i].calcularTiempoDeClase() > mayor) {
                    mayor = vector[i].calcularTiempoDeClase();
                }
                if (vector[i].HoraInicio < menor) { 
                menor = vector[i].HoraInicio;
                }
            }
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i].calcularTiempoDeClase() == mayor)
                {
                    Console.WriteLine("la clase del gimnasio " + vector[i].NombreClase + "fue la que mas duró");
                }
                if (vector[i].HoraInicio == menor)
                {
                    Console.WriteLine("la clase del gimnasio " + vector[i].NombreClase + "fue la que mas temprano comenzó");
                }
            }
            Console.ReadKey();
        }
    }
}
