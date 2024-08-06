using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Aksarlian_La_carrera_de_Homero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cuantos obstaculos va a tener homero en su carrera?");
            int obstaculos = int.Parse(Console.ReadLine());
            int[] LosObs = new int[obstaculos];
            int puntos = 0;
            for (int i = 0; i < obstaculos; i++)
            {
                Console.WriteLine("obstaculo " + i + " lo supera?");
                string papu = Console.ReadLine();
                if (papu == "si")
                {
                    LosObs[i] = 10;
                }
                else if (papu == "no")
                {
                    LosObs[i] = -5;
                }
                else if (!(papu == "si" || papu == "no"))
                {
                    Console.WriteLine("Homero supera el Obstaculo " + (i + 1));
                    String respuesta = Console.ReadLine();
                    if (respuesta == "si")
                    {
                        LosObs[i] = 10;
                    }
                    else if (respuesta == "no")
                    {
                        LosObs[i] = -5;
                    }
                }
                puntos = puntos + LosObs[i];
            }
            Console.WriteLine("homero termino la carrera con " + puntos + " puntos");

            Console.ReadKey();
        }
    }
}
