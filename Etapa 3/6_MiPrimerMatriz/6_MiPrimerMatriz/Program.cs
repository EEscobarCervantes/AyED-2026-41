using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un numero-fila: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("ingrese un numero-columna: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];
            Console.WriteLine("matriz:");
            for ( int i = 0;  i < n ; i ++)
            {
                for (int j = 0; j < m ; j ++)
                {
                    Console.Write(matriz[i, j]+ " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
