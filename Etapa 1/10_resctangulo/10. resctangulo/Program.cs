using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.resctangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el ancho de un rectangulo: ");
            Double ancho = Double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la altura de un rectangulo: ");
            Double altura = Double.Parse(Console.ReadLine());
            Double Perimetro = 2 * (ancho + altura);
            Double Area = ancho * altura;
            Double Diagonal = Math.Sqrt(Math.Pow(ancho,2 )+ Math.Pow(altura,2));
            Console.WriteLine("El preimetro es: " + Perimetro);
            Console.WriteLine("La altura es:" + altura);
            Console.WriteLine("La diagonal es:" + Diagonal);
            Console.ReadKey();

            
            


        }
    }
}
