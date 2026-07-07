using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            int vida = 10;
            int hambre = 10;
            int dia = 1;

            int comidaCruda = 0;
            int comidaCocida = 0;

            bool refugio = false;
            bool fogata = false;

            Random rand = new Random();

            int opcion = 0;

            while (opcion != 8 && vida > 0 && dia <= 10)
            {
                Console.WriteLine("---------SUPERVIVENCIA EN LA ISLA----------");
                Console.WriteLine("Dia: " + dia);
                Console.WriteLine("Vida: " + vida + " | Hambre: " + hambre);
                Console.WriteLine("Cruda: " + comidaCruda + " | Cocida: " + comidaCocida);
                Console.WriteLine("Refugio: " + refugio + " | Fogata: " + fogata);

                Console.WriteLine("\n1. Buscar comida");
                Console.WriteLine("2. Explorar la isla");
                Console.WriteLine("3. Construir refugio");
                Console.WriteLine("4. Encender fogata");
                Console.WriteLine("5. Cocinar comida");
                Console.WriteLine("6. Comer comida cocida");
                Console.WriteLine("7. Descansar");
                Console.WriteLine("8. Salir");

                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        if (rand.Next(1, 101) <= 60)
                        {
                            comidaCruda += 2;
                            Console.WriteLine("Encontraste comida cruda!");
                        }
                        else
                        {
                            Console.WriteLine("No encontraste nada.");
                        }

                        vida -= 1;
                        break;

                    case 2:
                        int r = rand.Next(1, 101);

                        if (r <= 50)
                        {
                            Console.WriteLine("Encontraste materiales utiles.");
                            refugio = true; 
                        }
                        else if (r <= 80)
                        {
                            Console.WriteLine("No encontraste nada.");
                        }
                        else
                        {
                            Console.WriteLine("Sufriste un accidente.");
                            vida -= 2;
                        }
                        break;

                    case 3:
                        if (!refugio)
                        {
                            refugio = true;
                            Console.WriteLine("Construiste un refugio.");
                        }
                        else
                        {
                            Console.WriteLine("Ya tienes refugio.");
                        }
                        break;

                    case 4:
                        if (refugio)
                        {
                            fogata = true;
                            Console.WriteLine("Encendiste la fogata.");
                        }
                        else
                        {
                            Console.WriteLine("Necesitas refugio para encenderla.");
                        }
                        break;

                    case 5:
                        if (comidaCruda > 0 && fogata)
                        {
                            comidaCruda--;
                            comidaCocida++;
                            Console.WriteLine("Cocinaste comida.");
                        }
                        else
                        {
                            Console.WriteLine("No puedes cocinar (falta comida o fogata).");
                        }
                        break;

                    case 6:
                        if (comidaCocida > 0)
                        {
                            comidaCocida--;
                            hambre += 4;

                            if (hambre > 10) hambre = 10;

                            Console.WriteLine("Comiste comida cocida.");
                        }
                        else
                        {
                            Console.WriteLine("No tienes comida cocida.");
                        }
                        break;

                    case 7:
                        if (refugio)
                        {
                            vida += 3;
                            Console.WriteLine("Descansaste en el refugio.");
                        }
                        else
                        {
                            vida += 1;
                            Console.WriteLine("Descansaste sin refugio.");
                        }

                        if (vida > 10) vida = 10;
                        break;

                    case 8:
                        Console.WriteLine("Saliste del juego.");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }

                // avance del dia
                if (opcion >= 1 && opcion <= 7)
                {
                    dia++;
                    hambre -= 2;

                    if (hambre < 0)
                    {
                        hambre = 0;
                    }

                    if (hambre == 0)
                    {
                        vida -= 2;
                    }
                }

                if (vida <= 0)
                {
                    Console.WriteLine("\nPerdiste: te quedaste sin vida.");
                }

                if (dia > 10 && vida > 0)
                {
                    Console.WriteLine("\nGANASTE: sobreviviste 10 dias!");
                }


                Console.ReadKey();
          }
       }
    }
 }
