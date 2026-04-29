using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_mimultiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultado;
            Console.Write("ingresar el numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("ingresa el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 * num2;
            Console.Write("la multiplicacion da: " + resultado);
            Console.ReadKey();
        }
    }
}
