using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Resctangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el ancho del rectangulo: ");
            Double ancho = Double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese altura del rectangulo:");
            Double altura = Double.Parse(Console.ReadLine());
            Double perimetro = 2 * (ancho + altura);
            Double area = ancho * altura;
            Double diagonal = Math.Sqrt(Math.Pow(ancho, 2) + Math.Pow(altura, 2));
            Console.ReadKey();




        }
    }
}
