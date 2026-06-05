using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopcionMascotas
{
    public class Animal
    {
        public string Nombre { get; }
        public string Raza { get; }

        public Animal(string nombre, string raza)
        {
            this.Nombre = nombre;
            this.Raza = raza;
        }

        public virtual string HacerSonido()
        {
            return "sonidoGenerico";
        }
    }
    public class Perro : Animal
    {
        public Perro(string nombre, string raza) : base(nombre, raza) { }

        public override string HacerSonido()
        {
            return "Wof";
        }
    }

    public class Gato : Animal
    {
        public Gato(string nombre, string raza) : base(nombre, raza) { }

        public override string HacerSonido()
        {
            return "Miau";
        }
    }

    public class Persona
    {
        public string Nombre { get; }
        public string Dni { get; }

        public List<Animal> MascotasAdoptadas { get; }

        public Persona(string nombre, string dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.MascotasAdoptadas = new List<Animal>();
        }
    }
    internal class Program
    {
        static List<Animal> animalesDisponibles = new List<Animal>();
        static List<Persona> personasRegistradas = new List<Persona>();
        static void Main(string[] args)
        {
            animalesDisponibles.Add(new Perro("Boby", "Bulldog"));
            animalesDisponibles.Add(new Gato("Paca", "Rex"));
            animalesDisponibles.Add(new Gato("Fito", "Gato Europeo"));

            personasRegistradas.Add(new Persona("Juan Chiriff", "1234"));
            personasRegistradas.Add(new Persona("Simon Basante", "5678"));

            string opcion = "";
            while (opcion != "5")
            {
                Console.WriteLine("Menú del centro de adopción.");
                Console.WriteLine("1. Mostrar animales disponibles");
                Console.WriteLine("2. Registrar nueva persona");
                Console.WriteLine("3. Adoptar una mascota");
                Console.WriteLine("4. Mostrar adoptantes");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Animales disponible: ");
                        for (int i = 0; i < animalesDisponibles.Count; i++)
                        {
                            Animal a = animalesDisponibles[i];
                            Console.WriteLine($"[{i}] Nombre: {a.Nombre} | Raza: {a.Raza} | Sonido: {a.HacerSonido()}");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Registro de persona.");
                        Console.Write("Nombre: ");
                        string nom = Console.ReadLine();
                        Console.Write("DNI: ");
                        string dni = Console.ReadLine();

                        personasRegistradas.Add(new Persona(nom, dni));
                        Console.WriteLine("Persona registrada.");
                        break;

                    case "3":
                        Console.WriteLine("Adopción.");
                        Console.Write("Ingrese el DNI de la persona: ");
                        string dniBuscado = Console.ReadLine();

                        Persona personaEncontrada = null;
                        foreach (var p in personasRegistradas)
                        {
                            if (p.Dni == dniBuscado) personaEncontrada = p;
                        }

                        if (personaEncontrada == null)
                        {
                            Console.WriteLine("La persona no existe.");
                            break;
                        }

                        Console.Write("Ingrese el número del animal (Se ve cuando se muestran los animales disponibles): ");
                        int indice = int.Parse(Console.ReadLine());

                        if (indice < 0 || indice >= animalesDisponibles.Count)
                        {
                            Console.WriteLine("Ese animal no existe.");
                            break;
                        }

                        Animal animalElegido = animalesDisponibles[indice];
                        personaEncontrada.MascotasAdoptadas.Add(animalElegido);
                        animalesDisponibles.RemoveAt(indice);

                        Console.WriteLine($"{personaEncontrada.Nombre} adoptó a {animalElegido.Nombre}.");
                        break;

                    case "4":
                        Console.WriteLine("Adoptantes.");
                        foreach (var p in personasRegistradas)
                        {
                            Console.WriteLine($"Adoptante: {p.Nombre} | DNI: {p.Dni}");
                        }
                        break;

                    case "5":
                        break;
                }
            }
        }
    }
}