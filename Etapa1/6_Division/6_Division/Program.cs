using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double resultado;
            Console.Write("ingresa el numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("ingresa elsegundo numero: ");
            num2 = double.Parse(Console.ReadLine());
            resultado = num1 / num2;
            Console.Write("la division da: ");
            Console.WriteLine(resultado);
            Console.ReadKey();



        }
    }
}
