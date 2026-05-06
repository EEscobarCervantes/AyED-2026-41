using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un numero: ");
            Double numero = Double.Parse(Console.ReadLine());
            Double cuadrado = Math.Pow(numero, 2);
            Double cubo = Math.Pow(numero, 3);
            Console.Write(numero + " al cuadrado es " + cuadrado + " y al cubo es " + cubo);
            Console.ReadKey();



        }
    }
}
