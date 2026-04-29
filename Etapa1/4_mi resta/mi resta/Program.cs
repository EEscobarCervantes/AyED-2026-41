using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mi_resta
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double resultado;
            Console.Write("ingrese el primer numero: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.Write("ingrese el segundo numero: ");
            numero2 = double.Parse(Console.ReadLine());
            resultado = numero1 / numero2;
            Console.Write("la division da como resultado: ");
            Console.WriteLine(resultado);
            Console.ReadKey();



        }
    }
}
