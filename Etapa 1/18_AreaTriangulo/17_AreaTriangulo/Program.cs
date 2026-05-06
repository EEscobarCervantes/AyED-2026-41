using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la base: ");
            double basee = double.Parse(Console.ReadLine());
            Console.Write("ingrese la altura: ");
            double altura = double.Parse(Console.ReadLine());
            double area = (basee * altura) / 2;
            Console.WriteLine("el area del triangulo es " + area);
            Console.ReadKey();
        }
    }
}
