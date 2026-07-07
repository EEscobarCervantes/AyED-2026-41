using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write(" ingrese cantidad de filas: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("ingrese cantidad de columnas: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = random.Next(1,101);
                    Console.Write(matriz[i, j]);
                }
            Console.WriteLine(" ");
            Console.ReadKey();


           }
        }
    }
}

