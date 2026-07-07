using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalificacionesEstudiantiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la cantidad de alumnos: ");
            int n = int.Parse(Console.ReadLine());
            string[,] estudiantes = new string [n, 3];
            for (int i=0; i < n; i++)
            {
                Console.WriteLine("estudiante" + (i + 1));
                Console.Write("Nombre: ");
                estudiantes[i, 0] = Console.ReadLine();
                Console.Write("Edad: ");
                estudiantes[i, 1] = Console.ReadLine();
                Console.Write("Calificación: ");
                estudiantes[i, 2] = Console.ReadLine();
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("           Lista de estudiantes         ");
            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nombre: " + estudiantes[i, 0] +" | Edad: " + estudiantes[i, 1] +" | Calificación: " + estudiantes[i, 2]);
            }
            Console.ReadKey();





        }
    }
}
