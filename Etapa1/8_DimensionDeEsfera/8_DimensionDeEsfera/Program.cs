using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DimensionDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double superficie;
            double volumen;
            double radio;
            Double PI;
            PI = 3.14159;  
            Console.Write("ingrese la radio: ");
            radio = double.Parse(Console.ReadLine());
            superficie = 4 * PI * Math.Pow(radio, 2);
            volumen = 4/3 * PI * Math.Pow(radio, 3);
            Console.Write("ingrese la superficie: " );
            Console.WriteLine(superficie);
            Console.Write("ingrese el volumen: " );
            Console.WriteLine(volumen);
            Console.ReadKey();





        }
    }
}
