using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
    class DispositivoInteligente {
        private string nombreDispositivo;
        private double consumoWatts;
        public string NombreDispositivo
        {
            set { nombreDispositivo = value; }
            get { return nombreDispositivo; }
        }
        public double ConsumoWatts
        {
            set { ConsumoWatts = value; }
            get { return consumoWatts; }
        }
        public DispositivoInteligente(string nom, double wat) {
            nombreDispositivo = nom;
            consumoWatts = wat;
        }
    }
    class PanelDomotico
    {
        List<DispositivoInteligente>dispositivos = new List<DispositivoInteligente>();

        public PanelDomotico() {
            
            
            for (int i = 0; i < 1; i++) {
                Console.WriteLine("escribe el nombre del dispositivo que queres agregar");
                string linea;
                string nombre;
                double consumo;
                nombre = Console.ReadLine();
                Console.WriteLine("ahora ingrese el consumo del dispositivo en watts");
                linea = Console.ReadLine();
                consumo = double.Parse(linea);
                DispositivoInteligente dis = new DispositivoInteligente(nombre, consumo);
                dispositivos.Add(dis);
                Console.WriteLine("desea agregar otro dispositivo? Escribe 's' para si, y 'n' para no");
                for (int f = 0; f < 1; f++) {
                    linea = Console.ReadLine();
                    if (linea != "s" && linea != "n")
                    {
                        Console.WriteLine("respuesta invalida, intente de nuevo");
                        f--;
                    }
                    else {

                        if (linea == "s")
                        {
                            i--;
                        }
                        else { 
                        
                        }
                    
                    }
                }
                
            }
            
        }
        public void MostrarDispositivos()
        {
            Console.WriteLine("todos los dispositivos: ");
            foreach (DispositivoInteligente d in dispositivos) {
                Console.WriteLine("Dispositivo: " + d.NombreDispositivo + ". Consumo: " + d.ConsumoWatts);
            }
        }
        public void CalcularConsumoTotal() {

            double total = 0;
            foreach (DispositivoInteligente d in dispositivos) {
                total = total + d.ConsumoWatts;
            }
            Console.WriteLine("El consumo total que hay entre todos los dispositivos de la casa es de: " + total + " watts");
        }
        public void DesconectarDispositivo()
        {

            Console.WriteLine("escriba el nombre del dispositivo a eliminar");
            string linea;
            linea = Console.ReadLine();
            dispositivos.RemoveAll(d => d.NombreDispositivo == linea);
            Console.WriteLine("se han eliminado los dispositivos con ese nombre");
        }
        static void Main(string[] args)
        {
            PanelDomotico panel = new PanelDomotico();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("1 para ver todos los dispositivos, 2 para calcular el consumo total de la casa, 3 para eliminar un dispositivo, 4 para acabar el programa.");
                int numero = int.Parse(Console.ReadLine());
                if (numero < 1 || numero > 4)
                {
                    Console.WriteLine("Numero invalido, intente otra vez");
                    i--;
                }
                else if (numero == 1)
                {
                    panel.MostrarDispositivos();
                    i--;
                }
                else if (numero == 2)
                {
                    panel.CalcularConsumoTotal();
                    i--;
                }
                else if (numero == 3)
                {
                    panel.DesconectarDispositivo();
                    i--;
                }
                else if (numero == 4)
                { }
            }
            Console.ReadKey();
        }
    }
}
