using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            int menor = 0;


            int[] numeros = new int[3];

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o número {i+1}: ");
                int n = int.Parse(Console.ReadLine());
                numeros[i] = n;
            }
            

            for(int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    maior = numeros[i];
                    menor = numeros[i];
                }

                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                } else if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            int multiplicacao = menor * maior;

            int divisao = maior / menor;

            Console.WriteLine($"O valor da multiplicação foi: {multiplicacao} e a da divisão foi: {divisao}");

            Console.ReadKey();
        }
    }
}
