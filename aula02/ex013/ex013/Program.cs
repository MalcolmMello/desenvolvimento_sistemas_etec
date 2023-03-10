using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da sua compra: ");
            float value = float.Parse(Console.ReadLine());

            float desc = value - (value * 0.15f);

            Console.WriteLine($"O Valor da sua compra com desconto é R${desc}.");

            Console.ReadKey();
        }
    }
}
