using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;
            Console.WriteLine("¿tienes un refugio? ");
            bool refugio = Console.ReadLine().ToLower() == "si";
            Console.WriteLine("¿tienes comida? ");
            bool comida = Console.ReadLine().ToLower() == "si";
            Console.WriteLine("¿tienes algo para defenderte? ");
            bool bate = Console.ReadLine().ToLower() == "no";
            if (refugio && comida && bate) 
            {
                Console.WriteLine("si puedes sobrevivir al apocalipsis ");
            }
            else
            {
                Console.WriteLine("no puedes sobrevivir al apocalipsis ");
            }
            Console.ReadKey();

        }
    }
}
