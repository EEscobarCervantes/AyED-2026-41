using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese temperatura en celsius");

            int celsius = int.Parse(Console.ReadLine());

            Console.WriteLine("su temperatura en grados fahrenheit es ");

            Console. WriteLine((celsius * 9 / 5) + 32);

            Console.ReadKey();
        }
    }
}
