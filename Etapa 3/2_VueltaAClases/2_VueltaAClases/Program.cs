using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de TPs: ");
            int cantTP = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de exámenes: ");
            int cantEx = int.Parse(Console.ReadLine());

            int[] tps= new int[cantTP];
            int[] examenes = new int[cantEx];
            int sumaexam = 0;
            int aprobado = 0;
            for (int i = 0; i < tps.Length; i++)
            {
                Console.Write("Nota TP" + (i + 1) + ": ");
                tps[i] = int.Parse(Console.ReadLine());

                if (tps[i] >= 6)
                {
                    aprobado++;
                }
            }

            for (int i = 0; i < examenes.Length; i++)
            {
                Console.Write("Nota examen " + (i + 1) + ": ");
                examenes[i] = int.Parse(Console.ReadLine());

                sumaexam += examenes[i];
            }

            double promedioExamenes = (double)sumaexam/ cantEx;
            double porcentajeTP = (double) aprobado * 100 / cantTP;

            if (promedioExamenes >= 6 && porcentajeTP >= 75)
            {
                Console.WriteLine("Phineas y Ferb APRUEBAN la materia.");
            }
            else
            {
                Console.WriteLine("Phineas y Ferb NO APRUEBAN la materia.");
            }

            Console.WriteLine("Promedio de exámenes: " + promedioExamenes);
            Console.WriteLine("Porcentaje de TPs aprobados: " + porcentajeTP + "%");

            Console.ReadKey();
     }
    }
}
