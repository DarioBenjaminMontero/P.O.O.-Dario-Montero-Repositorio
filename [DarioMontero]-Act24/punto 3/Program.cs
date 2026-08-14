using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    class Estudiante
    {
        private string nombre;
        private double calificacion;
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public double Calificacion
        {
            set { calificacion = value; }
            get { return calificacion; }
        }
        public Estudiante(string nom, double cal) { 
        nombre  = nom;
            calificacion = cal;
        }
    }

    class GestionAcademica
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        public void CargarEstudiantes()
        {
            string nombre, linea;
            double calificacion = 0;
            do {
                Console.WriteLine("escribi el nombre del estudiante, si se escribe 'FIN' la carga de estudiantes termina");
                nombre = Console.ReadLine();
                if (nombre == "FIN")
                {
                    Console.WriteLine("carga terminada");
                }
                else {
                    for (int i = 0; i < 1; i++) {
                        Console.WriteLine("escribi ahora su calificacion, no puede ser menor a 0 ni mayor a 10");
                        linea = Console.ReadLine();
                        calificacion = double.Parse(linea);
                        if (calificacion < 0 || calificacion > 10)
                        {
                            Console.WriteLine("Calificacion invalida, intente de nuevo");
                            i--;
                        }
                        
                    }
                    Estudiante e = new Estudiante(nombre, calificacion);
                    estudiantes.Add(e);
                }
            }
            while (nombre != "FIN");
        }
        public void ListarEstudiantes() {
            Console.WriteLine("informacion de estudiantes:");
            foreach (Estudiante e in estudiantes) {
                Console.WriteLine("Nombre del estudiante: " + e.Nombre + ". Calificacion del estudiante: " + e.Calificacion);
            }
            Console.WriteLine("CANTIDAD DE INSCRIPTOS: " + estudiantes.Count);
        }
        public void FiltrarAprobados() {
            Console.WriteLine("informacion de estudiantes aprobados:");
            foreach (Estudiante e in estudiantes) {
                if (e.Calificacion >= 6) {
                    Console.WriteLine("Nombre del estudiante: " + e.Nombre + ". Calificacion del estudiante: " + e.Calificacion);
                }
            }
        }
        public void DarDeBaja() {
            string nombre;
            Console.WriteLine("escribi el nombre del alumno a dar de baja");
            nombre = Console.ReadLine();
            estudiantes.RemoveAll(e => e.Nombre == nombre);
        }
        static void Main(string[] args)
        {
            GestionAcademica g = new GestionAcademica();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("1 para agregar estudiantes, 2 para mostrar estudiantes, 3 para filtrar aprobados, 4 para eliminar un estudiante,5 para acabar el programa.");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------");
                if (numero < 1 || numero > 5)
                {
                    Console.WriteLine("Numero invalido, intente otra vez");
                    i--;
                }
                else if (numero == 1)
                {
                    g.CargarEstudiantes();
                    i--;
                }
                else if (numero == 2)
                {
                    g.ListarEstudiantes();
                    i--;
                }
                else if (numero == 3)
                {
                    g.FiltrarAprobados();
                    i--;
                }
                else if (numero == 4)
                {
                    g.DarDeBaja();
                    i--;
                }
                else if (numero == 5)
                { }
            }
            Console.ReadKey();
        }
    }
}
