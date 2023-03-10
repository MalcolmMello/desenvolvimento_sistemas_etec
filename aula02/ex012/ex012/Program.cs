using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            int n4 = int.Parse(Console.ReadLine());

            int media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine($"A média dos quatro números é {media}.");

            Console.ReadKey();

        }
    }
}
