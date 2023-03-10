using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Digite seu salário mensal: ");
            float sal = float.Parse(Console.ReadLine());

            float desc = sal - (sal * 0.11f);

            Console.WriteLine($"O seu nome é {name} e o seu salário depois do desconto é R${desc}");

            Console.ReadKey();
        }
    }
}
