using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0) 
            {
                Console.WriteLine("El numero ingresado es par");
            }
            else
            {
                Console.WriteLine("el numero ingresado es impar");
            }
            Console.ReadKey();

        }
    }
}
