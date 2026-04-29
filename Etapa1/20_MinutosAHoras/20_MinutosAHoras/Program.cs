using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MinutosAHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese cantidad de minutos: ");
            int totalmin=int.Parse(Console.ReadLine());
            int horas = totalmin / 60;
            int minRestantes = totalmin % 60;
            Console.WriteLine(totalmin + "minutos son " + horas + " horas y " + minRestantes + " minutos");
            Console.ReadKey();

            



        }
    }
}
