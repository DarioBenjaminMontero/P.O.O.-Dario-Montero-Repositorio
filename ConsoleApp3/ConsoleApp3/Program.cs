using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PadronElectoral
    {
        List<Persona> personas = new List<Persona>();
        public void AgregarPersona(string nombre, string apellido)
        {
            personas.Add(new Persona(nombre, apellido));
        }

        public void Listar()
        {
            foreach (Persona p in personas)
            {
                Console.WriteLine($"{p.Nombre}, {p.Apellido}");
            }
        }

        public Persona Buscar(string apellido)
        {
            Persona persona = null;
            foreach (Persona p in personas)
            {
                if (apellido == p.Apellido)
                {
                    persona = p;
                    break;
                }
            }

            return persona;
        }
        public void Borrar(Persona persona)
        {
            foreach (Persona p in personas)
            {
                if (p == persona)
                {
                    personas.Remove(p);
                    break;
                }
            }
        }
    }

    class Mascota
    {
        public string Nombre { get; set; }

        public Mascota(string nombre)
        {
            Nombre = nombre;
        }
    }

    class Persona
    {
        List<Mascota> mascotas = new List<Mascota>();
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public void Adoptar(string nombre)
        {
            Mascota m = new Mascota(nombre);
            mascotas.Add(m);
        }

        public void ListarMascotas()
        {
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre);
            }
        }

        public int CantidadMascotas()
        {
            return mascotas.Count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PadronElectoral padron;
            Persona p;

            padron = new PadronElectoral();
            padron.AgregarPersona("Pablo1", "Fiscella1");
            padron.AgregarPersona("Pablo2", "Fiscella2");
            padron.AgregarPersona("Pablo3", "Fiscella3");
            padron.AgregarPersona("Pablo4", "Fiscella4");
            padron.Listar();
            Console.WriteLine(" ");
            p = padron.Buscar("Fiscella4");
            if (p != null)
            {
                p.Adoptar("Felipe");
                p.Adoptar("Bruna");
                p.CantidadMascotas();

                Console.WriteLine($"se encontro: {p.Apellido}, {p.Nombre}");
                Console.WriteLine($"Tiene {p.CantidadMascotas()} y son:");
                p.ListarMascotas();

            }
            else
            {
                Console.WriteLine("no esta");
            }


            if (p != null)
            {
                padron.Borrar(p);
                padron.Listar();
            }
            else
            {
                Console.WriteLine("no esta");
            }
        }
    }
}