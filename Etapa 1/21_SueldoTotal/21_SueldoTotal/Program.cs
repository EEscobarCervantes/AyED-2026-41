using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la cantidad de horas trabajadas: ");
            double horas = double.Parse(Console.ReadLine());
            Console.Write("ingrese el valor por horas: ");
            double valor = double.Parse(Console.ReadLine());
            double sueldo = horas * valor;
            Console.WriteLine("sueldo total es $" + sueldo);
            Console.ReadKey();

        }
    }
}
