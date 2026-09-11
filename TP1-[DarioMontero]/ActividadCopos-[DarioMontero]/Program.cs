using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ActividadCopos__DarioMontero_
{

    class Configuracion {
        private int velocidad;
        private int filas;
        private int columnas;

        public int Velocidad{
            set { velocidad = value; }
            get { return velocidad; }
        }
        public int Filas {
            set { filas = value; }
            get { return filas; }
        }
        public int Columnas
        {
            set { columnas = value; }
            get { return columnas; }
        }

        public Configuracion(int velocidad, int filas, int columnas) { 
        
        this.velocidad = velocidad;
            this.filas = filas;
            this.columnas = columnas;
        }
    }

    class Copo
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Copo(int x)
        {
            X = x;
            Y = 0;
        }
        public void Caer() {
            Y++;
        }
        public void Mostrarse() {
            if (Y > 0)
            {
                Console.SetCursorPosition(X, Y - 1);
                Console.Write(" ");
            }
            Console.SetCursorPosition(X, Y);
            Console.Write("*");
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Random aleatorio = new Random();
            List<Copo> copos = new List<Copo>();
            Configuracion configuracion = new Configuracion(150, 10, 20);
            string[,] matriz;
            matriz = new string[configuracion.Filas, configuracion.Columnas];
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int f = 0; f < matriz.GetLength(1); f++)
                {
                    matriz[i, f] = " ";
                }
            }
            
            while (true) {
                Copo copo = new Copo(aleatorio.Next(0, configuracion.Columnas));
                copos.Add(copo);
                foreach (Copo c in copos) {
                    c.Mostrarse();
                    if (c.Y + 1 == configuracion.Filas)
                    {
                        Console.SetCursorPosition(c.X, configuracion.Filas-1);
                        matriz[c.Y, c.X] = "*";
                        Console.Write("*");
                        continue;
                    }
                    else if (matriz[c.Y + 1, c.X] == "*") {
                        Console.SetCursorPosition(c.X, configuracion.Filas-1);
                        Console.Write("*");
                        matriz[c.Y, c.X] = "*";
                        continue;
                    }
                    else
                    {
                        
                        c.Caer();
                        if (c.Y > 0) {
                            matriz[c.Y - 1, c.X] = " ";
                        }
                        
                    }
                }
                
                int numero = 0;
                for (int f = 0; f < matriz.GetLength(1); f++)
                {
                    if (matriz[configuracion.Filas - 1, f] == "*")
                    {
                        numero++;
                        if (numero == configuracion.Columnas)
                        {
                            for (int i = 0; i < configuracion.Columnas ; i++)
                            {
                                matriz[configuracion.Filas - 1 ,i] = " ";
                                Console.SetCursorPosition(i, configuracion.Filas-1) ;
                                Console.Write(" ");
                            }
                        }
                    }
                }
                Thread.Sleep(1);
            }


            
        }
    }
}
