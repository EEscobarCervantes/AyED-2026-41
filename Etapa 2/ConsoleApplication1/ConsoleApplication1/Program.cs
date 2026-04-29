using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)

        {
            double horas;
            double valor;

            Console.Write("cuantas horas trabajó?: ");

            horas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("cuanto es su valor por hora?; ");

            valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("su sueldo total es; " + (valor / horas));

            Console.ReadKey();

        }
    }
}


           

        
       
