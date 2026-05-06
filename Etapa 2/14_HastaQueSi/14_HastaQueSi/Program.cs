using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HastaQueSi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿desea terminar el programa? ");
            string respuesta = Console.ReadLine();
            while (respuesta == "SI")
            {
                Console.Write("¿desea terminar el programa? ");
                respuesta = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
