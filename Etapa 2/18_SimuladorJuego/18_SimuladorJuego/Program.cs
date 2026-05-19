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
            int dias = 1;
            int comidaCruda = 0;
            int comidaCocida = 0;
            bool tieneRefugio = false;
            bool tieneFogata = false;
            bool jugando = true;

            Random azar = new Random();

            Console.WriteLine("¡Sobrevive en la Isla!");

            while (vida > 0 && dias <= 10 && jugando)
            {
                Console.WriteLine($"\n----- DÍA {dias} -----");
                Console.WriteLine($"Vida: {vida} | Hambre: {hambre} | Comida: {comidaCocida} cocida");

                Console.WriteLine("1. Buscar comida\n2. Explorar\n3. Construir refugio\n4. Encender fogata\n5. Cocinar\n6. Comer\n7. Descansar\n8. Salir");
                Console.Write("Acción: ");
                string opcion = Console.ReadLine();
                bool pasoElDia = false;

                switch (opcion)
                {
                    case "1":
                        if (azar.Next(1, 101) <= 60)
                        {
                            comidaCruda += 2;
                            Console.WriteLine("Encontraste comida cruda.");
                        }
                        else
                        {
                            Console.WriteLine("No encontraste nada.");
                        }
                        vida -= 1;
                        pasoElDia = true;
                        break;

                    case "2":
                        int suerte = azar.Next(1, 101);
                        if (suerte <= 50) Console.WriteLine("Encontraste materiales.");
                        else if (suerte > 80)
                        {
                            vida -= 2;
                            Console.WriteLine("¡Accidente! Perdiste vida.");
                        }
                        pasoElDia = true;
                        break;

                    case "3":
                        if (!tieneRefugio)
                        {
                            tieneRefugio = true;
                            Console.WriteLine("Refugio construido.");
                            pasoElDia = true;
                        }
                        else Console.WriteLine("Ya tienes uno.");
                        break;

                    case "4":
                        if (tieneRefugio)
                        {
                            tieneFogata = true;
                            Console.WriteLine("Fogata encendida.");
                            pasoElDia = true;
                        }
                        else Console.WriteLine("Necesitas refugio.");
                        break;

                    case "5":
                        if (comidaCruda > 0 && tieneFogata)
                        {
                            comidaCruda--; comidaCocida++;
                            Console.WriteLine("Comida cocinada.");
                            pasoElDia = true;
                        }
                        else Console.WriteLine("Faltan recursos o fogata.");
                        break;

                    case "6":
                        if (comidaCocida > 0)
                        {
                            comidaCocida--;
                            hambre = Math.Min(hambre + 4, 10);
                            Console.WriteLine("Comiste.");
                            pasoElDia = true;
                        }
                        else Console.WriteLine("No tienes comida cocida.");
                        break;

                    case "7":
                        int recupera = tieneRefugio ? 3 : 1;
                        vida = Math.Min(vida + recupera, 10);
                        Console.WriteLine("Descansaste.");
                        pasoElDia = true;
                        break;

                    case "8":
                        jugando = false;
                        break;

                    default:
                        Console.WriteLine("Acción no válida.");
                        break;
                    }
                if (pasoElDia)
                {
                    dias++;
                    hambre -= 2;
                    if (hambre <= 0)
                    {
                        hambre = 0;
                        vida -= 2;
                    }
                }
            }
            if (vida <= 0) Console.WriteLine("Game Over. Moriste.");
            else
            if (dias > 10) Console.WriteLine("¡Ganaste! Sobreviviste 10 días.");

            Console.ReadKey();
        }
    }
}
