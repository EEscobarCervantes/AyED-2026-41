using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont1;

            Console.WriteLine("--- Impares entre 0 y 100 ---");
            cont1 = 0;
            while (cont1 <= 100)
            {
                if (cont1 % 2 != 0) Console.Write(cont1 + " ");
                cont1++;
            }

            Console.WriteLine("\n\n--- Pares entre 0 y 100 ---");
            cont1 = 0;
            while (cont1 <= 100)
            {
                if (cont1 % 2 == 0) Console.Write(cont1 + " ");
                cont1 ++;
            }

            Console.WriteLine("\n\n--- Del 0 al 100 ---");
            cont1 = 0;
            while (cont1 <= 100)
            {
                Console.Write(cont1 + " ");
                cont1++;
            }

            Console.WriteLine("\n\n--- Del 100 al 0 ---");
            cont1 = 100;
            while (cont1 >= 0)
            {
                Console.Write(cont1 + " ");
                cont1--;
            }

            Console.WriteLine("\n\n--- Multiplos de 3 entre 0 y 100 ---");
            cont1 = 0;
            while (cont1 <= 100)
            {
                if (cont1 % 3 == 0) Console.Write(cont1 + " ");
                cont1++;
            }
            Console.WriteLine("\n\n--- Multiplos de 3 y 2 entre 0 y 100 ---");
            cont1 = 0;
            while (cont1 <= 100)
            {
                if (cont1 % 3 == 0 && cont1 % 2 == 0) Console.Write(cont1 + " ");
                cont1++;
            }

            Console.ReadKey();



        }
    }
}
