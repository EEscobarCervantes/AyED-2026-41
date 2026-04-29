using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el valor de lado 1: ");
            double lado1 = double.Parse(Console.ReadLine());
            Console.Write("ingrese el valor de lado2: ");
            double lado2 = double.Parse(Console.ReadLine());
            Console.Write("ingrese el valor de lado3: ");
            double lado3 = double.Parse(Console.ReadLine());
            if (lado1 + lado2 > lado3 && lado1 - lado3 > lado2 && lado3 > lado1) 
            {
                Console.WriteLine("Tienes un triangulo ");
            }
            if (lado1 == lado2 && lado2 == lado3 && lado1 == lado3) ;
            {
                Console.WriteLine("tienes un triangulo equilatero ");
            }
            if (lado1 == lado2 && lado1 != lado3 )
            {
                Console.WriteLine("tienes un triangulo isosceles ");
            }
            if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                Console.WriteLine("tienes un triangulo escaleno ");
            }
            Console.ReadKey();

        }
    }
}
