using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int vehiculos = 0;
            int total = 0;
            int opcion;

            do
            {
                Console.WriteLine("1 Ingresar vehículo");
                Console.WriteLine("2 Retirar vehículo");
                Console.WriteLine("3 estado");
                Console.WriteLine("4 salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        if (vehiculos >= 20)
                        {
                            Console.WriteLine("estacionamiento lleno");
                        }
                        else
                        {
                            vehiculos++;

                            Console.WriteLine("vehículo ingresado");

                            Console.WriteLine("cupos restantes: " + (20 - vehiculos));
                        }

                        break;

                    case 2:

                        if (vehiculos == 0)
                        {
                            Console.WriteLine("estacionamiento vacío");
                        }
                        else
                        {
                            int pago;

                            do
                            {
                                Console.WriteLine("ingrese pago:");

                                pago = int.Parse(Console.ReadLine());

                                if (pago < 2500)
                                {
                                    Console.WriteLine("pago insuficiente");
                                }

                            } while (pago < 2500);

                            int vuelto = pago - 2500;

                            Console.WriteLine("salida registrada");

                            Console.WriteLine("su vuelto es: " + vuelto);

                            vehiculos--;

                            total = total + 2500;
                        }

                        break;

                    case 3:

                        Console.WriteLine("vehículos presentes: " + vehiculos + "/20");

                        Console.WriteLine("dinero en caja: " + total);

                        break;

                    case 4:

                        Console.WriteLine("ingrese clave:");

                        int clave = int.Parse(Console.ReadLine());

                        if (clave == 1234)
                        {
                            Console.WriteLine("caja cerrada");

                            Console.WriteLine("total del día: " + total);
                        }
                        else
                        {
                            Console.WriteLine("acceso denegado");

                            opcion = 0;
                        }

                        break;

                    default:

                        Console.WriteLine("Comando desconocido");

                        break;
                }

            } while (opcion != 4);

            Console.ReadKey();
        }
    }
}
   