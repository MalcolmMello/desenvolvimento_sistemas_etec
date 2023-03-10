using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano atual: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano que você nasceu: ");
            int bornIn = int.Parse(Console.ReadLine());

            int age = year - bornIn;

            Console.WriteLine($"Você tem {age} anos.");

            Console.ReadKey();
        }
    }
}
