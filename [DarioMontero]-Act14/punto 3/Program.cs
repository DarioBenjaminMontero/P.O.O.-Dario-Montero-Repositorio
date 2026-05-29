using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{/*3. Competencia de Atletismo
Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
Definir los siguientes métodos en la clase Carrera:
Un constructor que cargue los datos de los 3 atletas de la carrera.
Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
Un método que calcule e imprima el tiempo promedio de la carrera.
Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
Un método que muestre a los atletas que superaron el promedio.
*/
    class Atleta
    {
        private string Nombre;
        private float TiempoSegundos;
        public Atleta()
        {
            string linea;
            Console.WriteLine("Escribe el nombre del Atleta");
            Nombre = Console.ReadLine();
            Console.WriteLine("escribe el Tiempo en segundos");
            linea = Console.ReadLine();
            TiempoSegundos = float.Parse(linea);
        }

        public string devolverNombre()
        {
            return Nombre;
        }
        public float devolverTiempo()
        {
            return TiempoSegundos;
        }
    }

    class Carrera
    {
        private Atleta atleta1, atleta2, atleta3;
        private float tiempoPromedio = 0;
        public Carrera()
        {
            atleta1 = new Atleta();
            atleta2 = new Atleta();
            atleta3 = new Atleta();
        }

        public void marcasTiempo()
        {
            Console.WriteLine("marcas de tiempo: ");
            Console.WriteLine("el atleta " + atleta1.devolverNombre() + " tiene un tiempo de " + atleta1.devolverTiempo());
            Console.WriteLine("el atleta " + atleta2.devolverNombre() + " tiene un tiempo de " + atleta2.devolverTiempo());
            Console.WriteLine("el atleta " + atleta3.devolverNombre() + " tiene un tiempo de " + atleta3.devolverTiempo());
        }
        public void TiempoPromedio()
        {
            tiempoPromedio += atleta1.devolverTiempo();
            tiempoPromedio += atleta2.devolverTiempo();
            tiempoPromedio += atleta3.devolverTiempo();
            tiempoPromedio = tiempoPromedio / 3;
            Console.WriteLine("el tiempo promedio es " + tiempoPromedio);
        }
        public void menorTiempo()
        {
            float tiempoMenor = atleta1.devolverTiempo();
            if (atleta2.devolverTiempo() < tiempoMenor)
            {
                tiempoMenor = atleta2.devolverTiempo();
            }
            if (atleta3.devolverTiempo() < tiempoMenor)
            {
                tiempoMenor = atleta3.devolverTiempo();
            }

            if (atleta1.devolverTiempo() == tiempoMenor)
            {
                Console.WriteLine("el atleta " + atleta1.devolverNombre() + " tiene el tiempo record con " + tiempoMenor);
            }
            if (atleta2.devolverTiempo() == tiempoMenor)
            {
                Console.WriteLine("el atleta " + atleta2.devolverNombre() + " tiene el tiempo record con " + tiempoMenor);
            }
            if (atleta3.devolverTiempo() == tiempoMenor)
            {
                Console.WriteLine("el atleta " + atleta3.devolverNombre() + " tiene el tiempo record con " + tiempoMenor);
            }
        }

        public void promedioSuperado()
        {
            if (atleta1.devolverTiempo() < tiempoPromedio)
            {
                Console.WriteLine("el atleta " + atleta1.devolverNombre() + "superó el promedio");
            }
            if (atleta2.devolverTiempo() < tiempoPromedio)
            {
                Console.WriteLine("el atleta " + atleta2.devolverNombre() + "superó el promedio");
            }
            if (atleta3.devolverTiempo() < tiempoPromedio)
            {
                Console.WriteLine("el atleta " + atleta3.devolverNombre() + " superó el promedio");
            }
        }

        static void Main(string[] args)
        {
            Carrera carrera = new Carrera();
            carrera.marcasTiempo();
            carrera.TiempoPromedio();
            carrera.menorTiempo();
            carrera.promedioSuperado();
            Console.ReadKey();

        }
    }
}
