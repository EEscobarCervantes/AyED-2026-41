using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña = "ghost";
            Console.Write("introducir contraseña: ");
            string usuario = Console.ReadLine();
            string a = usuario.ToLower();
            if (contraseña == a) 
            {
                Console.WriteLine("contraseña correcta");
            }
            else
            {
                Console.WriteLine("contraseña incorrecta");
            }
            Console.ReadKey();
        }
    }
}
