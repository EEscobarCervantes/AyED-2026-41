using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Ingrese la cantidad de invitados: ");
            int cant_invitados= int.Parse(Console.ReadLine());

            int[] comida = new int[cant_invitados];
            int suma = 0;

            for (int i = 0; i < comida.Length; i++)
            {
                do
                {
                    Console.Write("Cantidad de comida del invitado " + (i + 1) + " (1-100): ");
                    comida[i] = int.Parse(Console.ReadLine());
                }
                while (comida[i] < 1 || comida[i] > 100);

                suma += comida[i];
            }

            double promedio = (double)suma / cant_invitados;

            Console.WriteLine("Promedio de comida por invitado: " + promedio);
            Console.ReadKey();




        }
    }
}
