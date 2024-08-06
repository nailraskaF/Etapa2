using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Aksarlian_ElRayoCarreraVeloz
{
    class Program
    {
        static void Main(string[] args)
        {
            int vueltas;
            Console.WriteLine("cuantas vueltas dió el rayo?");
            vueltas = int.Parse(Console.ReadLine());
            int[] LasVueltas = new int[vueltas];
            int[] tiempo = new int[vueltas];
            int record = 1000000000;
            int total = 0;
            int promedio = 0;
            for (int i = 0; i<vueltas; i++)
            {
                Console.WriteLine("cuanto tiempo tardo en la vuelta " + (i+1) + "?");
                tiempo[i] = int.Parse(Console.ReadLine());
                if (tiempo[i] < record)
                {
                    record = tiempo[i];
                }
                total = total + tiempo[i];
            }
            promedio = total / vueltas;
            Console.WriteLine("el mejor tiempo fue de " + record + " segundos");
            Console.WriteLine("el promedio de tiempo por vuelta fue de " + promedio + " segundos");
            Console.WriteLine("el tiempo total fue de " + total + " segundos");
            Console.ReadKey();
                
        }
    }
}
