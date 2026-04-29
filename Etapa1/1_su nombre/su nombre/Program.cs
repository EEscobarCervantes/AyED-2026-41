using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace su_nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            Console.Write("ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Su nombre es: ");
            Console.WriteLine(nombre);
            Console.ReadKey();

        }
    }
}
