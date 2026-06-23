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
            int[] vidas_pokemon = new int[6];
            int cantidad = 0;
            int opcion;
            Console.WriteLine("-------- CENTRO POKE-REMEDIO --------");
            Console.WriteLine("1.registrar un nuevo pokemon: ");
            Console.WriteLine("2.mostrar la vida de todos los pokemones: ");
            Console.WriteLine("3.curar un pokemon: ");
            Console.WriteLine("4.dañar un pokemon: ");
            Console.WriteLine("5.curar a todos los pokemones:");
            Console.WriteLine("6.mostrar pokemones debilitados: ");
            Console.WriteLine("7.mostrar el pokemon con mayor vida: ");
            Console.WriteLine("8.mostrar el pokemon con menor vida: ");
            Console.WriteLine("9.calcular promedio de vida del equipo: ");
            Console.WriteLine("10.ordenar pokemones por vida de menor a mayor: ");
            Console.WriteLine("11.ordenar pokemones por vida de mmayor a menor");
            Console.WriteLine("12.simular ataque enemigo a todo el equipo: ");
            Console.WriteLine("13.salir");
            Console.Write("opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    if (cantidad < 6)
                    {
                        int vidas;
                        while (true) ;
                        {
                            Console.Write("ingrese vida (1-100) : ");
                            vidas = int.Parse(Console.ReadLine());
                            if (vidas >= 0 && vidas <= 100) ;
                        }

                        vidas_pokemon[cantidad] = vidas;
                        cantidad++;
                        Console.Write("registrado.");
                    }
                    else
                    {
                        Console.Write("Centro lleno.");
                    }
                    break;

                case 2:
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("Pokemon" + (i - 1) + "-vidas:" + vidas_pokemon[i]);
                    }
                    break;

                case 3:
                    Console.WriteLine("ingrese la posicion del pokemon a curar: ");
                    int posicion = int.Parse(Console.ReadLine());

                    if (posicion >= 0 && posicion <= cantidad)
                    {
                        Console.Write("ingrese puntos de vida a curar: ");
                        int curar = int.Parse(Console.ReadLine());
                        vidas_pokemon += [curar];
                        if (vidas_pokemon[posicion] > 100)
                            vidas_pokemon[posicion] = 100;
                    }
                    break;

                case 4:
                    Console.WriteLine("ingrese la posicion del pokemon atacado: ");
                    int pos = int.Parse(Console.ReadLine());
                    
                    if (pos >= 0 && pos < cantidad )
                    {
                        Console.Write("ingrese daño recibido: ");
                        int daño = int.Parse(Console.ReadLine());
                        vidas_pokemon +- [daño];
                        if (vidas_pokemon[pos] < 0)
                            vidas_pokemon[pos] = 0; 
                    }
                    break;

                case 5:
                        Console.Write("ingrese puntos de curacion general: ");
                        int curacion = int.Parse(Console.ReadLine());
                        for (int i = 0; i < cantidad; i++)
                        {
                            vidas_pokemon[i] += curacion;
                        if (vidas_pokemon[i] > 100)
                            vidas_pokemon[i] = 100;
                        }
                    break;

                case 6:

                    int debilitados = int.Parse(Console.ReadLine());
                    for (int i= 0; i < cantidad; i++)
                    {
                        if (vidas_pokemon[i] == 0)
                        {
                            Console.Write("posicion " + (i-1));
                            debilitados ++;
                        }
                    }
                        Console.WriteLine("total: " + debilitados);
                    break;

                case 7:
                    int mayor = vidas_pokemon[0];
                    for (int i=0; i < cantidad; i ++)
                    {
                        if (vidas_pokemon[i] < mayor)
                            mayor = vidas_pokemon[i];
                        {
                            Console.WriteLine("el pokemon con mayor vida esta en la posicion: " + mayor);
                        }
                    }
                    break;
                case 8:
                    int menor = vidas_pokemon[0];
                    for (int i =0; i < cantidad; i++)
                    {
                        if (vidas_pokemon[i] > menor)
                            menor = vidas_pokemon[i];
                        {
                            Console.WriteLine("el pokemon con menor vida esta en la posicion: " + menor);
                        }
                    }
                    break;
                case 9:
                    int suma;
                    if (vidas_pokemon[i] < )
                    {
                        Console.WriteLine("")
                    }

                    break;

                case 10:
                    int mayor;






            }
            Console.ReadKey();

        }

    }
}
