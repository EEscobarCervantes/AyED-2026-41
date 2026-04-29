using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese numero1: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.Write("ingrese numero2: ");
            float numero2 = float.Parse(Console.ReadLine());
            Console.Write("ingrese numero3: ");
            float numero3 = float.Parse(Console.ReadLine());
            float promedio = numero1 + numero2 + numero3;
            Console.Write("el promedio de los 3 numeros es: ");
            Console.WriteLine(promedio);
            Console.ReadKey();
        }
    }
}
