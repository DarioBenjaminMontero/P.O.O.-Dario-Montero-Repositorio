using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
    class Vuelo
    {

        private int codigo;
            private DateTime horaSalida, horaLlegada;

        public DateTime HoraSalida
        {
            set { horaSalida = value; }
            get { return horaSalida; }
        }
        public DateTime HoraLlegada
        {
            set { horaLlegada= value; }
            get { return horaLlegada; }
        }
        public int Codigo
        {
            set { codigo = value; }get{ return codigo; }
        }



        public Vuelo(int codigo, DateTime horaSalida, DateTime horaLlegada) {

            this.codigo = codigo;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }
        public TimeSpan duracionVuelo() {
            TimeSpan duracion = horaLlegada - horaSalida;
            return duracion;
        }

        static void Main(string[] args)
        {
            Vuelo[] vector = new Vuelo[4];


            vector[0] = new Vuelo(1, new DateTime(2026, 7, 3, 14, 30, 00), new DateTime(2026, 7, 3, 17, 30, 00));
            vector[1] = new Vuelo(2, new DateTime(2026, 7, 3, 14, 30, 00), new DateTime(2026, 7, 3, 19, 30, 00));
            vector[2] = new Vuelo(3, new DateTime(2026, 7, 3, 16, 30, 00), new DateTime(2026, 7, 3, 16, 45, 00));
            vector[3] = new Vuelo(4, new DateTime(2026, 7, 3, 17, 30, 00), new DateTime(2026, 7, 3, 18, 30, 00));
            vector[0].duracionVuelo();
            vector[1].duracionVuelo();
            vector[2].duracionVuelo();
            vector[3].duracionVuelo();
            TimeSpan mayor = vector[0].duracionVuelo();
            DateTime masTemprano = vector[0].HoraSalida;
            for (int i = 0; i < vector.Length; i ++) {
                if (vector[i].duracionVuelo() > mayor) { 
                mayor = vector[i].duracionVuelo();
                }
            }
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i].HoraSalida < masTemprano)
                {
                    masTemprano = vector[i].HoraSalida;
                }
            }
            for (int i = 0; i < vector.Length; i++) {
                if (vector[i].duracionVuelo() == mayor)
                {
                    Console.WriteLine("el vuelo de codigo " + vector[i].Codigo + " fue el que mas duró en tiempo con " + mayor);
                }
                if (vector[i].HoraSalida == masTemprano)
                {
                    Console.WriteLine("el vuelo de codigo " + vector[i].Codigo + " fue uno de los que mas temprano salio a las " + masTemprano);
                }
            }
            Console.ReadKey();
        }
    }
}

