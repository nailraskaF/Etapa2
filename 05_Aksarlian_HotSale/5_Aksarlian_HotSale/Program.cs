using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Aksarlian_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.Write("Ingrese la cantidad de productos vendidos durante el Hot Sale: ");
            int cantidadProductos = int.Parse(Console.ReadLine());

            
            int[] precios = new int[cantidadProductos];

            
            for (int i = 0; i < cantidadProductos; i++)
            {
                Console.Write($"Ingrese el precio del producto {i + 1}: ");
                precios[i] = int.Parse(Console.ReadLine());
            }

            int precioMasAlto = precios[0];
            int precioMasBajo = precios[0];

            for (int i = 1; i < cantidadProductos; i++)
            {
                if (precios[i] > precioMasAlto)
                {
                    precioMasAlto = precios[i];
                }
                if (precios[i] < precioMasBajo)
                {
                    precioMasBajo = precios[i];
                }
            }

            
            Console.WriteLine($"El precio más alto registrado durante el evento es: {precioMasAlto}");
            Console.WriteLine($"El precio más bajo registrado durante el evento es: {precioMasBajo}");
            Console.ReadKey();
        }
    }
}