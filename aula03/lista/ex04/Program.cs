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
            Console.WriteLine("Digite sua altura em metros: ");
            float height = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite seu peso em kg: ");
            float peso = float.Parse(Console.ReadLine());

            float imc = peso / (height * height);

            Console.Clear();

            if (height < 10)
            {
                Console.WriteLine($"Seu imc é {Math.Round(imc, 2)}.");
                Calc(imc);
            }
            else
            {
                float newH = height / 100;
                imc = peso / (newH * newH);
                Calc(imc);
                Console.WriteLine("Você colocou centímetros, mas o programa é tão bom que corrigiu pra você.");
                Console.WriteLine($"Seu imc é {Math.Round(imc, 2)}");
            }

            Console.ReadKey();
        }

        static void Calc(float imc)
        {
            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso.");
            } else if (imc <= 24.9)
            {
                Console.WriteLine("Peso Normal");
            } else if (imc <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc <= 34.9)
            {
                Console.WriteLine("Obesidade grau 1");
            }
            else if (imc <= 39.9)
            {
                Console.WriteLine("Obesidade grau 2");
            } 
            else
            {
                Console.WriteLine("Obesidade grau 3");
            }
        }
    }
}
