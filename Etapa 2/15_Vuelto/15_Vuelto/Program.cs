using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Vuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el monto total de la compra: ");
            double total = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el dinero entregado: ");
            double entregado = double.Parse(Console.ReadLine());

            if (entregado < total)
            {
                Console.WriteLine("Dinero insuficiente.");
            }
            else
            {
                double vuelto = entregado - total;
                Console.WriteLine("El vuelto total es: $" + vuelto);

                double[] billetes = { 10000, 2000, 1000, 500, 200, 100, 50, 20, 10 };
                int i = 0;

                while (i < billetes.Length)
                {
                    int cantidad = (int)(vuelto / billetes[i]);
                    if (cantidad > 0)
                    {
                        Console.WriteLine(cantidad + " billete(s) de $" + billetes[i]);
                        vuelto = vuelto % billetes[i];
                    }
                    i++;
                }
                Console.ReadKey();
            }
}
