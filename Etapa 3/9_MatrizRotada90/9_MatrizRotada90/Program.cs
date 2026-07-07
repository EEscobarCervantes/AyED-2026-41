using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_MatrizRotada90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            int[,] rotada = new int[n, n];
            Console.WriteLine("Ingrese la matriz: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotada[j, n - 1 - i] = matriz[i, j];
                }
            }
            Console.WriteLine("Matriz rotada:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(rotada[i, j] + " ");
                }
                Console.WriteLine();
                Console.ReadKey();

           }
       }
   }
}


