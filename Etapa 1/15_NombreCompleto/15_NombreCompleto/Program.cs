using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NombreCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("escribir nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("escribe apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("su nombre completo es " + nombre + " "  + apellido);
            Console.ReadKey();

        }
    }
}
