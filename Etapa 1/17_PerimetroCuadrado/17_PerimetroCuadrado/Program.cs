using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado, perimetro, superficie;

            Console.Write("Ingrese la longitud del lado del cuadrado: ");
            lado = double.Parse(Console.ReadLine());

            perimetro = lado * 4;
            superficie = lado * lado;

            Console.WriteLine("El perimetro es: " + perimetro);
            Console.WriteLine("La superficie es: " + superficie);

            Console.ReadKey();

        }
    }
}
