using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura do Triangulo: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a base do Triangulo: ");
            int b = int.Parse(Console.ReadLine());

            float a = (h * b) / 2;

            Console.WriteLine($"A Área do Triangulo é {a}");

            Console.ReadKey();
        }
    }
}
