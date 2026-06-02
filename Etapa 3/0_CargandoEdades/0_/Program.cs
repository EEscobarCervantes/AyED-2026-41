using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[5];
            for (int i = 0; i < edades.Length; i++)
            {
                Console.Write("ingrese la edad de cada estudiante: " + (i+1) + ":");
                edades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("edades cargadas:");
            for (int i =0; i < edades.Length; i ++)
            {
                Console.WriteLine(edades[i]);
            }
            Console.ReadKey();
           
        }
    }
}
