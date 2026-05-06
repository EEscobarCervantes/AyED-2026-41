using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca Un Presupuesto Anual Para Un Hospital: ");
            float presupuesto = float.Parse(Console.ReadLine());
            float gine = presupuesto * 40 / 100;
            float Trauma = presupuesto * 30 / 100;
            Console.WriteLine("El Presupuesto Para Ginecologia Es : " + gine + "$");
            Console.WriteLine("El Presupuesto Para Traumatologia Es : " + Trauma + "$");
            Console.WriteLine("El Presupuesto Para Pediatria Es : " + Trauma + "$");
            Console.ReadKey();
        }
    }
}
