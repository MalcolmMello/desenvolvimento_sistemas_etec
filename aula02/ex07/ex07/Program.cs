using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em fahrenheit: ");

            int fahrenheit = int.Parse(Console.ReadLine());

            int C = 5 * ((fahrenheit - 32) / 9);

            Console.WriteLine($"O valor em celsius é: {C}");

            Console.ReadKey();
        }
    }
}
