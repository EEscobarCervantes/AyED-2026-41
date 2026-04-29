using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la medida en metros: ");
            double metros = double.Parse(Console.ReadLine());
            double cm= metros * 100;
            double mm = metros * 1000;
            Console.WriteLine(metros + " me equivale a " + cm + " cem y "+mm+" mm");
            Console.ReadKey();


        }
    }
}
