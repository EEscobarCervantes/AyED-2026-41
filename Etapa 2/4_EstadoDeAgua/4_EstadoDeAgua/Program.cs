using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingresa una cantidad de grados celsius: ");
            int grados = int.Parse(Console.ReadLine());
            if (grados <= 0)
            {
                Console.WriteLine("su agua se congela a los ");
            }
            if (grados >= 100)
            {
                Console.WriteLine("su agua hierve a los ");
            }
            if (grados >= 1 && grados <= 99)
                Console.WriteLine("su agua esta en estado liquido ");
            Console.ReadKey();
        }
    }
}
