using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            int subtracao = n1 - n2;

            float divisao = n1 / n2;

            int multiplicacao = n1 * n2;

            Console.Clear();

            Console.WriteLine($"A soma dos números é: {soma}");
            Console.WriteLine($"A subtração dos números é: {subtracao}");
            Console.WriteLine($"A divisão dos números é: {divisao}");
            Console.WriteLine($"A multiplicação dos números é: {multiplicacao}");

            Console.ReadKey();
        }
    }
}
