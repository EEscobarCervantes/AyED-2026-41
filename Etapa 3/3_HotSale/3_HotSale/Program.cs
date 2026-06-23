using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la cantidad de productos vendidos: ");
            int cantidad = int.Parse(Console.ReadLine());
            double[] precios = new double[cantidad];
            for (int i = 0; i < cantidad ;  i++)
            {
                Console.Write("precio de productos " + (i + 1) + ": ");
                precios[i] = int.Parse(Console.ReadLine());
            }

            double mayor = 0;
            double menor = 0;
            for (int i =0 ; i < cantidad; i++ )
            {
                if ( precios[i] < mayor )
                {
                    menor = precios[i];    
                }
                if (precios[i] > menor) 
                {
                    mayor = precios[i];
                }
            }
            Console.WriteLine("el precio mas alto fue " + mayor + "$");
            Console.WriteLine("el precio mas bajo fue " + menor + "$");


            Console.ReadKey();



        }
    }
}
