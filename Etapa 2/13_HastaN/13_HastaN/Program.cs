using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un numero de finalizacion: ");
            double n = double.Parse(Console.ReadLine());
            double cont = 1;
            while  (cont <= n)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(cont);
                }
                cont = cont + 1;
            }
            Console.ReadKey();
        }
    }
}
