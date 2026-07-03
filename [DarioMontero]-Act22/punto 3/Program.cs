using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    class Entrenamiento
    {
        string deportista;
        int duracion;
        public string Deportista
        {
            set { deportista = value; }
            get { return deportista; }
        }
        public int Duracion
        {
            set { duracion = value;  }
            get { return duracion; }
        }

        public void RegistrarDuracion(int horas, int minutos) {
            Console.WriteLine("escribe le nombre del deportista que hizo ese tiempo");
            deportista = Console.ReadLine();
            duracion = minutos + horas * 60;
        }
        public void RegistrarDuracion(int minutos)
        {
            Console.WriteLine("escribe le nombre del deportista que hizo ese tiempo");
            deportista = Console.ReadLine();
            duracion = minutos;

        }

        static void Main(string[] args)
        {
            List<Entrenamiento> entrenamientos = new List<Entrenamiento>();
            for (int i = 0; i < 5; i++) {
                entrenamientos.Add(new Entrenamiento());
            }
            for (int i = 0; i < 5; i++) {
                if (i >= 3)
                {
                    Console.WriteLine("escribe una cantidad de minutos");
                    int minutos = int.Parse(Console.ReadLine());
                    entrenamientos[i].RegistrarDuracion(minutos);
                }
                else {
                    Console.WriteLine("escribe una cantidad de minutos");
                    int minutos = int.Parse(Console.ReadLine());
                    Console.WriteLine("escribe una cantidad de horas");
                    int horas = int.Parse(Console.ReadLine());
                    entrenamientos[i].RegistrarDuracion(horas, minutos);
                }
                
                
            }

            int mayorDuracion = entrenamientos[0].Duracion;
            int menorDuracion = entrenamientos[0].Duracion;

            foreach (Entrenamiento e in entrenamientos) {
                if (e.Duracion > mayorDuracion) {
                    mayorDuracion = e.Duracion;
                }
            }
            foreach (Entrenamiento e in entrenamientos) {
                if (e.Duracion < menorDuracion) {
                    menorDuracion = e.Duracion;
                }
            }
            foreach(Entrenamiento e in entrenamientos)
            {
                if (e.Duracion == mayorDuracion) {
                    Console.WriteLine("el deportista de nombre " + e.Deportista + " hizo el mayor tiempo con " + mayorDuracion);
                }
                if (e.Duracion == menorDuracion)
                {
                    Console.WriteLine("el deportista de nombre " + e.Deportista + " hizo el menor tiempo con " + menorDuracion);
                }
            }

            Console.ReadKey();

        }
    }
}
