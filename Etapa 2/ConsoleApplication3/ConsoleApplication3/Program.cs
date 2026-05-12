using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int vehiculos = 0;
            int contador_recaudacion = 0;
            int opcion;

            do
            {
                Console.WriteLine(" 1 ingresar vehiculo");
                Console.WriteLine(" 2 retirar vehiculo");
                Console.WriteLine(" 3 estado");
                Console.WriteLine(" 4 salirr");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        if (vehiculos == 20)
                        {
                            Console.WriteLine("estacionam lleno");
                        }
                        else
                        {
                            vehiculos++;
                        }

                        break;
                    case 2:
                        if (vehiculos <= 0)
                        {
                            Console.WriteLine("no hay");
                        }
                        else
                        {
                            Console.WriteLine("ingr pago");
                            int pago = int.Parse(Console.ReadLine());

                            if (pago < 2500)
                                Console.WriteLine("insuficien");
                            else
                            {
                                vehiculos--;
                                contador_recaudacion = contador_recaudacion + 2500;
                                Console.WriteLine("vehiculo retirado");
                            }

                        }
                        break;
                    case 3:
                        Console.WriteLine("vehiculo" + vehiculos);

                        break;
                    case 4:
                        Console.WriteLine("sistema cerrado");
                        break;

                    default:

                        Console.WriteLine("op invalid");
                        break;
                }

            }
            while (opcion != 4);
            Console.ReadKey();
        }
    }
}
