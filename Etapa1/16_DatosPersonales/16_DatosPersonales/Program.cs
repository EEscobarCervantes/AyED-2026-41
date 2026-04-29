using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string ciudad;
            Console.Write("ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("ingrese su ciudad: ");
            ciudad = Console.ReadLine();
            Console.WriteLine("su nombre es " + nombre + ", tiene " + edad + " años y vive en " + ciudad);
            Console.ReadKey();
        




        }
    }
}
