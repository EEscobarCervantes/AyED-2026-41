using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese cantidad de n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[n, n];
            int[,] B = new int[n, n];
            int[,] C = new int[n, n];

            Console.WriteLine("Matriz A");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Valor: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz B");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Valor: ");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            Console.WriteLine("Matriz suma:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(C[i, j] + " ");
                }

                Console.WriteLine();

                Console.ReadKey();
            }
        }
    }
}
