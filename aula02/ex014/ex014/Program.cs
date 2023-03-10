using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Digite sua altura em metros: ");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso em kg: ");
            float peso = float.Parse(Console.ReadLine());

            float imc = peso / (h * h);

            Console.Clear();

            if (h < 10)
            {
                Console.WriteLine($"Seu imc é {imc}.");
            } else
            {
                float newH = h / 100;
                imc = peso / (newH * newH);
                Console.WriteLine("Você colocou centímetros, mas o programa é tão bom que corrigiu pra você.");
                Console.WriteLine($"Seu imc é {imc}");
            }

            //1 - tentar trazer o ano atual do sistema ao inves de solicitar para o usuário
            //2 - Desenvolver um tratamento de erro, para caso o usuário informe letras ou deixe o valor vazio para números
            //3 - Tentar juntar todos os projetos em 1, numa espécie de menu onde o usuário seleciona a opção

            Console.ReadKey();

        }
    }
}
