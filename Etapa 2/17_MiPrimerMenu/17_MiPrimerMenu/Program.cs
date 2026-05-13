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
            int opcion = 0;
            while (opcion != 4)
            {
                Console.WriteLine("¡BIENVENIDOS!");
                Console.WriteLine("-- Menu de restaurante --");
                Console.WriteLine("opcion 1");
                Console.WriteLine("opcion 2");
                Console.WriteLine("opcion 3");
                Console.WriteLine("---Salir---");
                Console.Write("selecciona una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("has seleccionado la opcion 1, ¡increíble!");
                        break;
                    case 2:
                        Console.WriteLine("no esta disponible");
                        break;
                    case 3:
                        Console.WriteLine("has seleccionado la opcion 3, ¡increíble!");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("Presione cualquier tecla para volver al menú");
                }
                Console.ReadKey();
        
            }
        }
    }
}
