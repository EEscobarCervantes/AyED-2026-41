using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelciusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la temperatura:");
            Double Celsius = double.Parse(Console.ReadLine());
            Double Fahrenheit = Celsius * 1.8 + 32;
            Double Kelvin = Celsius + 273.15;
            Console.WriteLine("grados celsius a kelvin:" + Kelvin);
            Console.WriteLine("entoces en fahrenheit es igual a: " + Fahrenheit);
            Console.ReadKey();


        }
    }
}
