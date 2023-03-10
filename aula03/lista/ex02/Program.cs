using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            if(n % 2 == 1)
            {
                Console.WriteLine("O número é ímpar e positivo");
            } else if(n % 2 == -1)
            {
                Console.WriteLine("O número é ímpar e negativo");
            } else if(n % 2 == 0 && n > 0)
            {
                Console.WriteLine("O número é par e postivo.");
            }
            else
            {
                Console.WriteLine("O número é par e negativo.");
            }

            Console.ReadKey();
        }
    }
}
