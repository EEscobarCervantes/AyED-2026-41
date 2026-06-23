using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.Write("cantidad de participantes: ");
            int cant_participantes = int.Parse(Console.ReadLine());
            int[] puntajes = new int[cant_participantes];
            for (int i = 0; i < cant_participantes ; i ++)
            {
                Console.Write("ingrese el puntaje del jugador " + (i + 1) + ": ");
                puntajes[i] = int.Parse(Console.ReadLine());
            }
           
            double mayor = 0;
            double menor = 0;
            for (int i=0; i < cant_participantes; i ++)
            {
                if (puntajes[i] < mayor)
                {
                    menor = puntajes[i];
                }
               if (puntajes[i] > menor )
                {
                    mayor = puntajes[i];
                }
            }
            Console.WriteLine("el primer lugar: "+ mayor);
            Console.WriteLine("el ultimo lugar: "+ menor);
            Console.ReadKey();

        }

    }
}
