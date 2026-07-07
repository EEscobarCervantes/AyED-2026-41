using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argentinian_Truck_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] encargos = new string[25, 5];

            int cantidad = 0;
            int opcion = 0;

            while (opcion != 8)
            {
                Console.WriteLine("----------ARGENTINIAN TRUCK SIMULATOR----------");
                Console.WriteLine("1. Crear nuevo encargo");
                Console.WriteLine("2. Mostrar todos los encargos");
                Console.WriteLine("3. Asignar camion");
                Console.WriteLine("4. Mostrar encargos asignados");
                Console.WriteLine("5. Promedio de ganancia por sede");
                Console.WriteLine("6. Mostrar encargo con mayor distancia");
                Console.WriteLine("7. Filtrar por codigo de camion");
                Console.WriteLine("8. Salir");

                Console.Write("Ingrese una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (cantidad < 25)
                        {
                            bool valido = false;
                            encargos[cantidad, 0] = " ";

                            while (!valido)
                            {
                                Console.Write("Ingrese la distancia: ");
                                int distancia = int.Parse(Console.ReadLine());

                                if (distancia > 0)
                                {
                                    encargos[cantidad, 1] = distancia.ToString();
                                    valido = true;
                                }
                                else
                                {
                                    Console.WriteLine("La distancia no puede ser negativa... Es ilegal que los camiones circulen en reversa.");
                                }
                            }
                            Console.Write("Ingrese la sede (1-BSAS 2-BB 3-MDQ): ");
                            encargos[cantidad, 2] = Console.ReadLine();

                            Console.Write("Ingrese la ganancia: ");
                            encargos[cantidad, 3] = Console.ReadLine();
                            encargos[cantidad, 4] = "0";
                            cantidad++;
                            Console.WriteLine("Encargo registrado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("No hay más espacio... ¡Estamos a Full!.");
                        }

                        break;

                    case 2:

                        if (cantidad == 0)
                        {
                            Console.WriteLine("No hay encargos registrados.");
                        }
                        else
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("\nEncargo " + (i + 1));

                                Console.WriteLine("Codigo camion: " + encargos[i, 0]);
                                Console.WriteLine("Distancia: " + encargos[i, 1]);

                                if (encargos[i, 2] == "1")
                                    Console.WriteLine("Sede: BSAS");
                                else if (encargos[i, 2] == "2")
                                    Console.WriteLine("Sede: BB");
                                else
                                    Console.WriteLine("Sede: MDQ");

                                Console.WriteLine("Ganancia: $" + encargos[i, 3]);

                                if (encargos[i, 4] == "1")
                                    Console.WriteLine("Asignado: SI");
                                else
                                    Console.WriteLine("Asignado: NO");
                            }
                        }
                        break;
                        case 3:
                        if (cantidad == 0)
                        {
                            Console.WriteLine("No hay encargos registrados.");
                            break;
                        }
                        Console.WriteLine("Encargos sin asignar:");
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (encargos[i, 4] == "0")
                            {
                                Console.WriteLine((i + 1) + ". Distancia: " + encargos[i, 1] + " km");
                            }
                        }
                        Console.Write("Seleccione el encargo: ");
                        int pos = int.Parse(Console.ReadLine()) - 1;

                        if (pos >= 0 && pos < cantidad)
                        {
                            if (encargos[pos, 4] == "1")
                            {
                                Console.WriteLine("El encargo seleccionado ya tiene un camión asignado.");
                            }
                            else
                            {
                                Console.Write("Ingrese el codigo del camion: ");
                                encargos[pos, 0] = Console.ReadLine().ToUpper();
                                encargos[pos, 4] = "1";
                                Console.WriteLine("Camion asignado correctamente.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Posicion invalida.");
                        }
                        break;
                    case 4:
                        if (cantidad == 0)
                        {
                            Console.WriteLine("No hay encargos registrados.");
                            break;
                        }
                        bool hayAsignados = false;
                        Console.WriteLine("Encargos asignados:");
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (encargos[i, 4] == "1")
                            {
                                Console.WriteLine("\nEncargo " + (i + 1));
                                Console.WriteLine("Camion: " + encargos[i, 0]);
                                Console.WriteLine("Distancia: " + encargos[i, 1]);
                                Console.WriteLine("Ganancia: $" + encargos[i, 3]);
                                if (encargos[i, 2] == "1")
                                    Console.WriteLine("Sede: BSAS");
                                else if (encargos[i, 2] == "2")
                                    Console.WriteLine("Sede: BB");
                                else
                                    Console.WriteLine("Sede: MDQ");
                                hayAsignados = true;
                            }
                        }
                        if (!hayAsignados)
                        {
                            Console.WriteLine("No hay encargos asignados.");
                        }
                        break;
                    case 5:
                        if (cantidad == 0)
                        {
                            Console.WriteLine("No hay encargos registrados.");
                            break;
                        }
                        double sumaBSAS = 0, sumaBB = 0, sumaMDQ = 0;
                        int contBSAS = 0, contBB = 0, contMDQ = 0;

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (encargos[i, 2] == "1")
                            {
                                sumaBSAS += double.Parse(encargos[i, 3]);
                                contBSAS++;
                            }
                            else if (encargos[i, 2] == "2")
                            {
                                sumaBB += double.Parse(encargos[i, 3]);
                                contBB++;
                            }
                            else if (encargos[i, 2] == "3")
                            {
                                sumaMDQ += double.Parse(encargos[i, 3]);
                                contMDQ++;
                            }
                        }
                        Console.WriteLine("Promedios por sede:");
                        if (contBSAS > 0)
                            Console.WriteLine("BSAS: " + (sumaBSAS / contBSAS));
                        if (contBB > 0)
                            Console.WriteLine("BB: " + (sumaBB / contBB));
                        if (contMDQ > 0)
                            Console.WriteLine("MDQ: " + (sumaMDQ / contMDQ));
                        break;
                    case 6:
                        if (cantidad == 0)
                        {
                            Console.WriteLine("No hay encargos registrados.");
                            break;
                        }

                        int mayor = int.Parse(encargos[0, 1]);
                        for (int i = 1; i < cantidad; i++)
                        {
                            if (int.Parse(encargos[i, 1]) > mayor)
                            {
                                mayor = int.Parse(encargos[i, 1]);
                            }
                        }
                        Console.WriteLine("Encargo(s) con mayor distancia:");
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (int.Parse(encargos[i, 1]) == mayor)
                            {
                                Console.WriteLine("\nEncargo " + (i + 1));
                                Console.WriteLine("Camion: " + encargos[i, 0]);
                                Console.WriteLine("Distancia: " + encargos[i, 1]);
                                if (encargos[i, 2] == "1")
                                    Console.WriteLine("Sede: BSAS");
                                else if (encargos[i, 2] == "2")
                                    Console.WriteLine("Sede: BB");
                                else
                                    Console.WriteLine("Sede: MDQ");
                                Console.WriteLine("Ganancia: $" + encargos[i, 3]);
                            }
                        }
                        break;
                    case 7:

                        if (cantidad == 0)
                        {
                            Console.WriteLine("No hay encargos registrados.");
                            break;
                        }
                        Console.Write("Ingrese el codigo del camion: ");
                        string codigo = Console.ReadLine().ToUpper();
                        bool encontrado = false;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (encargos[i, 0].ToUpper() == codigo)
                            {
                                Console.WriteLine("Encargo " + (i + 1));
                                Console.WriteLine("Distancia: " + encargos[i, 1]);

                                if (encargos[i, 2] == "1")
                                    Console.WriteLine("Sede: BSAS");
                                else if (encargos[i, 2] == "2")
                                    Console.WriteLine("Sede: BB");
                                else
                                    Console.WriteLine("Sede: MDQ");
                                Console.WriteLine("Ganancia: $" + encargos[i, 3]);
                                encontrado = true;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No se encontraron encargos para ese camion.");
                        }

                        break;

                    case 8:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }

}
