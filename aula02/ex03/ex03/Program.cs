using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine($"Seu nome é: {nome}, sua idade é: {idade} e sua altura é {altura}");

            Console.ReadKey();
        }
    }
}
