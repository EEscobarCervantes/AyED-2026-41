using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese cantidad de cilindros: ");
            double cilindros = double.Parse(Console.ReadLine());
            Console.Write("ingrese cantidad de pistas: ");
            double pistas = double.Parse(Console.ReadLine());
            Console.Write("ingrese sectorea por pista de un disco duro: ");
            double discoduro = double.Parse(Console.ReadLine());
            double kilobytes = (512 * cilindros * pistas * discoduro) / 1000;
            double megabytes = (512 * cilindros * pistas * discoduro) / 10000;
            double gigabytes = (512 * cilindros * pistas * discoduro) / 100000;
            Console.Write("la capacidad total en kilobytes es " + kilobytes + " ,en megabytes " + megabytes + " y en gigabytes " + gigabytes);
            Console.ReadKey();


        }
    }
}
