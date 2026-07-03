using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    class ElementoPantalla
    {
        private string nombre;
        private int posX, posY;

        public string Nombre {

            set { nombre = value; }
            get { return nombre; }
        }
        public int PostX
        {
            set { posX = value; }
            get { return posX; }

        }
        public int PosY
        {
            set { posY = value; }
            get { return posY; }
        }


        public ElementoPantalla() {
            Console.CursorVisible = true;
            Console.WriteLine("carga un nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("escribe en que coordenadas (x) querés que se escriba");
            posX = int.Parse(Console.ReadLine());
            Console.WriteLine("escribe en que coordenadas (y) querés que se escriba");
            posY = int.Parse(Console.ReadLine());
        }

        public void Mostrar() {
           
            Console.SetCursorPosition(posX, posY);
            Console.CursorVisible = false;
            Console.WriteLine(nombre);
            Console.SetCursorPosition(0, 0);
        }

        static void Main(string[] args)
        {
            ElementoPantalla[] vector = new ElementoPantalla[4];
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = new ElementoPantalla();
                
            }
            for (int i = 0; i < vector.Length; i++) {
                vector[i].Mostrar();
            }

            Console.ReadKey();
        }
    }
}
