using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuanPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("ingresar edad: ");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 19) 
            {
                Console.WriteLine("mayor de edad");
            }
            else
            {
                Console.WriteLine("menor de edad");
            }
        }
    }
}
