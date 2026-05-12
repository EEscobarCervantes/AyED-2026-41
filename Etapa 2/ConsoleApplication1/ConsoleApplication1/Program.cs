using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = { 200, 150, 100, -50, 300 };// Un array de 5 números enteros
            int suma; // Un entero que será su suma
            suma = numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4]; // Hallamos la suma
            Console.WriteLine("Su suma es {0}", suma);
            Console.ReadKey();
        }
    }
}
