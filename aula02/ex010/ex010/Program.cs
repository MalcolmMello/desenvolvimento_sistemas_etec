using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o lado do quadrado: ");
            int l = int.Parse(Console.ReadLine());

            int a = l * l;

            Console.WriteLine($"A Área do quadrado é {a}");

            Console.ReadKey();
        }
    }
}
