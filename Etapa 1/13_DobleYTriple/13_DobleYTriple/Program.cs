using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DobleYTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            int numX2 = num * 2;
            int numX3 = num * 3;
            Console.WriteLine("el doble de " + num + " es " + numX2 + " y el triple es " + numX3);
            Console.ReadKey();

        }
    }
}
