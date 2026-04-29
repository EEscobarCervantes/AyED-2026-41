using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedasDelNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿cuantas monedas doradas tenes? ");
            int monedadorada = int.Parse(Console.ReadLine());
            Console.WriteLine("¿cuantas monedeas plateanas obtuviste? ");
            int monedaplateada = int.Parse(Console.ReadLine());
            int valormonedadorada = monedadorada *10;
            int valormonedaplateada = monedaplateada *2;
            int valortotal = valormonedadorada + valormonedaplateada;
            if (valortotal == 50) 
            {
                Console.WriteLine("nivel insuficiente");
            }
            if (valortotal >= 50 && valortotal <=99) 
            {
                Console.WriteLine("nivel superado");
            }
            if (valortotal >= 100)
            { 
                Console.WriteLine("nivel completado con bonus");
            }
            Console.ReadKey();



        }
    }
}
