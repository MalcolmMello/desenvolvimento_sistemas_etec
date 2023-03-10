using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor: ");
            int valor = int.Parse(Console.ReadLine()) * 2;

            Console.WriteLine($"O dobro do valor é: {valor}");

            Console.ReadKey();
        }
    }
}
