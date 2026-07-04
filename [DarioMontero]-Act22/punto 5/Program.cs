using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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
        public DateTime HoraFin
        {
            set { horaFin = value;  }
            get { return horaFin; }
        }
        public DateTime HoraInicio {
            set { horaInicio = value;  }
            get { return horaInicio;  }
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
        public string Nombre
        {
            set { nombre = value;  }
            get { return nombre; }
        }

        public Corredor() {
            Console.WriteLine("escribe el numero de dorsal");
            numeroDorsal = int.Parse(Console.ReadLine());
            Console.WriteLine("escribe el nombre");
            nombre = Console.ReadLine();
        }
        public TimeSpan calcularDuracion(int minutos, int horas) {
            int minutosTotales = minutos + horas * 60;
            tiempoTotal = TimeSpan.FromMinutes(minutosTotales);
            return tiempoTotal;
        }
        public TimeSpan calcularDuracion(int minutos)
        {
       
            tiempoTotal = TimeSpan.FromMinutes(minutos);
            return tiempoTotal;
        }
        public TimeSpan TiempoTotal
        {
            get { return tiempoTotal; }
        }

        static void Main(string[] args)
        {
            Corredor[] corredores = new Corredor[8];
            for (int i = 0; i < 8; i++)
            {
                corredores[i] = new Corredor();

            }
            corredores[0].calcularDuracion(120);
                corredores[1].calcularDuracion(100);
            corredores[2].calcularDuracion(90);
            corredores[3].calcularDuracion(150);
            corredores[4].calcularDuracion(10,1);
                corredores[5].calcularDuracion(15, 2);
            corredores[6].calcularDuracion(10, 2);
            corredores[7].calcularDuracion(20, 1);
            Carrera[] carreras = new Carrera[4];
            carreras[0] = new Carrera();
            carreras[1] = new Carrera();
            carreras[2] = new Carrera(3, 14,16);
            carreras[3] = new Carrera(4,15,16);
            carreras[0].agregarCorredor(corredores[0]);
            carreras[0].agregarCorredor(corredores[1]);
            carreras[1].agregarCorredor(corredores[2]);
            carreras[1].agregarCorredor(corredores[3]);
            carreras[2].agregarCorredor(corredores[4]);
            carreras[2].agregarCorredor(corredores[5]);
            carreras[3].agregarCorredor(corredores[6]);
            carreras[3].agregarCorredor(corredores[7]);
            TimeSpan menorTiempo = corredores[0].TiempoTotal;
            for (int i = 0; i < corredores.Length; i++) {
                if (menorTiempo > corredores[i].TiempoTotal) {
                    menorTiempo = corredores[i].TiempoTotal;
                }
            }
            Console.Clear();
            int posiciony = 10;
            for (int i = 0; i < corredores.Length; i++)
            {
                if (menorTiempo == corredores[i].TiempoTotal)
                {
                    
                    Console.SetCursorPosition(0, posiciony);
                    Console.WriteLine("el corredor de nombre " + corredores[i].Nombre + "hizo el menor tiempo con " + menorTiempo);
                    posiciony += 10;
                }
            }
            DateTime masTemprano = carreras[0].HoraInicio;
            for(int i = 0; i<carreras.Length; i++){
                if (masTemprano > carreras[i].HoraInicio) {
                    masTemprano = carreras[i].HoraInicio;
                }
            }
            posiciony = 10;

            for (int i = 0; i < carreras.Length; i++)
            {
                if (masTemprano == carreras[i].HoraInicio)
                {
                    
                    Console.SetCursorPosition(40, posiciony);
                    Console.WriteLine("codiga de la mas temprana:" + carreras[i].Codigo);
                    posiciony += 10;
                }
            }



        }
    }
}
