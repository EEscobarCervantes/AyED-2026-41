using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Ingrese valor de columnas y filas: ");
                int n = int.Parse(Console.ReadLine());

                int[,] matriz = new int[n, n];
                int[] diagonal = new int[n];

                Random random = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matriz[i, j] = random.Next(1, 101);
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    diagonal[i] = matriz[i, i];
                }

                Console.WriteLine("Matriz:");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine("Diagonal principal:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(diagonal[i] + " ");

                    Console.ReadKey();
    
         }
      }
   }
}
