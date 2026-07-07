using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CentroPM
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vidasPokemones = new int[6];
            int cantidad = 0;
            int opcion = 0;
            while (opcion != 13)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("|           CENTRO POKÉ-REMEDIO        |");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("1. Registrar un  pokemon");
                Console.WriteLine("2. Mostrar vidas");
                Console.WriteLine("3. Curar un pokemon");
                Console.WriteLine("4. Dañar un pokemon");
                Console.WriteLine("5. Curar a todos los pokemones");
                Console.WriteLine("6. Mostrar los pokemones debilitados");
                Console.WriteLine("7. Mostrar el pokemon con mayor vida");
                Console.WriteLine("8. Mostrar velpokemon con menor vida");
                Console.WriteLine("9. Calcular el promedio del equipo");
                Console.WriteLine("10. Ordenar pokemones con mayor vida ");
                Console.WriteLine("11. Ordenar pokemones con menor vida");
                Console.WriteLine("12. Simular ataque enemigo a todo el equipo");
                Console.WriteLine("13. Salir");

                Console.Write("Ingrese opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (cantidad < 6)
                        {
                            int vida;

                            while (true)
                            {
                                Console.Write("ingrese la vida del pokemon (0-100): ");
                                vida = int.Parse(Console.ReadLine());
                                if (vida >= 0 && vida <= 100)
                                    break;
                            }

                            vidasPokemones[cantidad] = vida;
                            cantidad++;

                            Console.WriteLine("pokemon registrado correctamente en la posicion "+ cantidad);
                        }
                        else
                        {
                            Console.WriteLine("No se puede registrar pokemones. El centro esta lleno.");
                        }
                        break;

                    case 2:

                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Pokémon " + (i + 1) + " - Vida: " +
                                vidasPokemones[i]);
                        }

                        break;

                    case 3:

                        Console.Write("ingrese la posición del pokemon a curar: ");
                        int pos = int.Parse(Console.ReadLine());

                        if (pos >= 0 && pos < cantidad)
                        {
                            Console.Write("ingrese puntos de vida a curar: ");
                            int cura = int.Parse(Console.ReadLine());

                            vidasPokemones[pos] += cura;

                            if (vidasPokemones[pos] > 100)
                                vidasPokemones[pos] = 100;
                        }

                        break;

                    case 4:

                        Console.Write("ingrese la posición del pokemon atacado: ");
                        pos = int.Parse(Console.ReadLine());

                        if (pos >= 0 && pos < cantidad)
                        {
                            Console.Write("ingrese daño recibido: ");
                            int daño = int.Parse(Console.ReadLine());

                            vidasPokemones[pos] -= daño;

                            if (vidasPokemones[pos] < 0)
                                vidasPokemones[pos] = 0;
                        }
                        break;

                    case 5:

                        Console.Write("ingrese puntos de curación general: ");
                        int c = int.Parse(Console.ReadLine());
                      
                        for (int i = 0; i < cantidad; i++)
                        { 
                            vidasPokemones[i] += c;
                            if (vidasPokemones[i] > 100)
                                vidasPokemones[i] = 100;
                                }
                        break;

                    case 6:

                        int debilitados = 0;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (vidasPokemones[i] == 0)
                            {
                                Console.WriteLine("Pokemones en posicion: " + i);

                                debilitados++;
                            }
                        }

                        Console.WriteLine("Cantidad total de debilitados: " + debilitados);

                        break;

                    case 7:

                        int mayor = vidasPokemones[0];

                        for (int i = 1; i < cantidad; i++)
                        {
                            if (vidasPokemones[i] > mayor)
                                mayor = vidasPokemones[i];
                        }

                        Console.WriteLine("El pokemon con mayor vida esta en la posicion: " + mayor);

                        break;

                    case 8:

                        int menor = vidasPokemones[0];

                        for (int i = 1; i < cantidad; i++)
                        {
                            if (vidasPokemones[i] < menor)
                                menor = vidasPokemones[i];
                        }
                        Console.WriteLine("El pokemon con menor vida esta en la posicion: " + menor);
                        break;
        
                    case 9:

                        int suma = 0;

                        for (int i = 0; i < cantidad; i++)
                            suma += vidasPokemones[i];

                        Console.WriteLine("Promedio: " + (double)suma / cantidad);
                        break;

                    case 10:
                        for (int i= 0; i < cantidad - 1; i++)
                        {
                            for (int j=0; j < cantidad - 1; j++)
                            {
                                if (vidasPokemones[j]> vidasPokemones[j + 1])
                                {
                                    int aux = vidasPokemones[j];
                                    vidasPokemones[j] = vidasPokemones[j + 1];
                                    vidasPokemones[j + 1] = aux;
                                }
                            }
                        }
                        Console.WriteLine("vidas ordenadas de menor a mayor: ");
                        for (int i= 0; i< cantidad; i++)
                        {
                            Console.WriteLine(vidasPokemones[i]);
                        }
                        break;

                    case 11:
                        for (int i = 0; i < cantidad - 1; i++)
                        {
                            for (int j = 0; j < cantidad - 1; j++)
                            {
                                if (vidasPokemones[j] < vidasPokemones[j + 1])
                                {
                                    int aux = vidasPokemones[j];
                                    vidasPokemones[j] = vidasPokemones[j + 1];
                                    vidasPokemones[j + 1] = aux;
                                }
                            }
                        }

                        Console.WriteLine("Vidas ordenadas de mayor a menor:");

                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine(vidasPokemones[i]);
                        }

                        break;

                    case 12:

                        Random random = new Random();
                        Console.WriteLine("¡Un pokemon salvaje ataco al equipo!");
                        int ataque =random.Next(5, 26);

                        for (int i = 0; i < cantidad; i++)
                        {
                            vidasPokemones[i] -= ataque;
                            if (vidasPokemones[i] < 0)
                                vidasPokemones[i] = 0;
                        }
                        Console.WriteLine("Daño recibido por todos: " + ataque);
                        Console.WriteLine("Las vidas fueron actualizadas.");
                        break;

                    case 13:
                        Console.WriteLine("Programa finalizado.");
                        break;
                }
          }
            Console.ReadKey();
        }
    }
}


