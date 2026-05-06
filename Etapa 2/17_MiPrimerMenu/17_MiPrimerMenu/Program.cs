using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDOS");
            Console.WriteLine("-- Menu de restaurante --");
            int opcion = 0;
            Console.WriteLine("opcion 1");
            Console.WriteLine("opcion 2");
            Console.WriteLine("opcion 3");
            switch (opcion)
            {
                case 1:
                    Console.Write("haz seleccionado la opcion 1, ¡increible!");
                    break;
                case 2:
                    Console.Write("haz seleciionado la opcion 2, ¡increible!");
                    break;
                case 3:
                    Console.Write("haz seleccionado la opcion 3, ¡increible!");
                    break;

            }

            Console.ReadKey();


        }
    }
}
