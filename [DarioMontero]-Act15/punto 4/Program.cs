using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{

    class RobotEnsamblador {
        string modeloRobot;
        float[][] tiemposOperacion;

        public RobotEnsamblador() {
            string linea;
            string fase = "";
            tiemposOperacion = new float[4][];
            Console.WriteLine("escribe el nombre del modelo del robot");
            modeloRobot = Console.ReadLine();
            for (int i = 0; i < tiemposOperacion.GetLength(0); i++) {
                if (i == 0) { fase = " Estructura"; }
                if (i == 1) { fase = " Cableado"; }
                if (i == 2) { fase = " pintura"; }
                if (i == 3) { fase = " testeo"; }
                Console.WriteLine("escribe la cantidad de subtareas que este robot tuvo que realizar en la fase " + fase);
                linea  = Console.ReadLine();
                tiemposOperacion[i] = new float[int.Parse(linea)];
                for (int f = 0; f < tiemposOperacion[i].Length; f++) {
                    Console.WriteLine("escribe cuando tiempo tardó en completar la subtarea numero " + f + " (en segundos)");
                    linea = Console.ReadLine();
                    tiemposOperacion[i][f] = float.Parse(linea);
                }
            }
        }
        public string devolverModelo() {
            return modeloRobot;
        }
        public float[][] devolverTiempos() {
            return tiemposOperacion;
        }


    }
     class PlantaIndustrial
    {
        RobotEnsamblador[] robots;
        float[][] matrizTiempos;
        public PlantaIndustrial() {
        robots = new RobotEnsamblador[3];
            for (int i = 0; i < robots.Length; i++) {
            robots[i] = new RobotEnsamblador();
            }
        }

        public void tiempos() {
            string fase = "";
            for (int i = 0; i < robots.Length; i++) {
                matrizTiempos = robots[i].devolverTiempos();
                Console.WriteLine("los tiempos de operacion del robot con nombre " + robots[i].devolverModelo() + " son");
                for (int f = 0; f < matrizTiempos.GetLength(0); f++) {
                    if (f== 0) { fase = " Estructura"; }
                    if (f == 1) { fase = " Cableado"; }
                    if (f == 2) { fase = " pintura"; }
                    if (f == 3) { fase = " testeo"; }
                    Console.WriteLine("los tiempos de la fase " + fase + " en sus respectivas subtareas son: ");
                    for (int y = 0; y < matrizTiempos[f].Length; y++) {
                        Console.WriteLine("en la subtarea numero " + y + " tardó " + matrizTiempos[f][y] + " segundos");
                        Console.WriteLine();
                    }
                }
            }
        }

        public void promedioYEficiencia()
        {
            float promedio = 0;
            float promedioMasChico = 0;
            float[] promedios = new float[3];
            int suma = 0;
            for (int i = 0; i < robots.Length; i++)
            {
                promedio = 0;
                suma = 0;
                matrizTiempos = robots[i].devolverTiempos();
                for (int f = 0; f < matrizTiempos.GetLength(0); f++)
                {
                    for (int y = 0; y < matrizTiempos[f].Length; y++)
                    {
                        promedio += matrizTiempos[f][y];
                        suma++;
                    }
                }
                promedio = promedio / suma;
                promedios[i] = promedio;
            }

            promedioMasChico = promedios[0];

            for (int i = 0; i < promedios.Length; i++)
            {
                if (promedios[i] < promedioMasChico) {
                    promedioMasChico = promedios[i];
                }
            }

            for (int i = 0; i < promedios.Length; i++) {
                if (promedios[i] == promedioMasChico) {
                    Console.WriteLine("el robot mas eficiente con el mejor promedio de tiempo es el robot " + robots[i].devolverModelo());
                }
            }
        }
        static void Main(string[] args)
        {
            PlantaIndustrial pi = new PlantaIndustrial();
            pi.tiempos();
            pi.promedioYEficiencia();
            Console.ReadKey();
        }
    }
}
