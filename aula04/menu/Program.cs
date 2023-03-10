using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;

            while (true)
            {
                try
                {
                    EscolhaUmNumero();
                    option = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite um número válido!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
            Console.Clear();
            switch (option)
            {
                case 1:
                    
                    Ex01();
                    break;
                case 2:
                    Ex02();
                    break;
                case 3:
                    Ex03();
                    break;
                case 4:
                    Ex04();
                    break;
                case 5:
                    Ex05();
                    break;
                case 6:
                    Ex06();
                    break;
                case 7:
                    Ex07();
                    break;
                case 8:
                    Ex08();
                    break;
                case 9:
                    Ex09();
                    break;
            }
        }
        static void EscolhaUmNumero()
        {
            Console.WriteLine("|----------- ESCOLHA UM PROGRAMA -----------|");
            Console.WriteLine("|---------------------1---------------------|");
            Console.WriteLine("|---------------------2---------------------|");
            Console.WriteLine("|---------------------3---------------------|");
            Console.WriteLine("|---------------------4---------------------|");
            Console.WriteLine("|---------------------5---------------------|");
            Console.WriteLine("|---------------------6---------------------|");
            Console.WriteLine("|---------------------7---------------------|");
            Console.WriteLine("|---------------------8---------------------|");
            Console.WriteLine("|---------------------9---------------------|");
        }
        static void Ex01()
        {
            int peso = 0;
            int exc = 0;
            int multa = 0;

            Console.WriteLine("Digite o peso dos peixes pescado em kg: ");
            peso = int.Parse(Console.ReadLine());
            Console.Clear();
            if (peso > 50)
            {
                exc = peso - 50;
                multa = exc * 8;

                Console.WriteLine($"A multa foi de R${multa}.");
            }
            else
            {
                multa = 0;
                Console.WriteLine($"Você pagará R${multa} de multa.");
            }
            Console.ReadKey();
        }
        static void Ex02()
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 1)
            {
                Console.WriteLine("O número é ímpar e positivo");
            }
            else if (n % 2 == -1)
            {
                Console.WriteLine("O número é ímpar e negativo");
            }
            else if (n % 2 == 0 && n > 0)
            {
                Console.WriteLine("O número é par e postivo.");
            }
            else
            {
                Console.WriteLine("O número é par e negativo.");
            }

            Console.ReadKey();
        }
        static void Ex03()
        {
            Console.WriteLine("Qual seu código de operário? ");
            int cod = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas você trabalha ");
            int hrs = int.Parse(Console.ReadLine());

            float excesso = 0;

            float excessoHrs = hrs - 50;

            float salario = 0;

            if (excessoHrs > 0)
            {
                salario = (hrs - excessoHrs) * 20;
                excesso = excessoHrs * 30;
                salario += excesso;
            }
            else
            {
                salario = hrs * 20;
            }

            Console.WriteLine($"Seu código é {cod} salário foi de {salario}, e o excedente foi de {excesso}");

            Console.ReadKey();
        }
        static void Ex04()
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
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (imc <= 29.9)
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
        static void Ex05()
        {
            Console.WriteLine("Digite o lado A do triângulo: ");
            float A = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado B do triângulo: ");
            float B = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado C do triângulo: ");
            float C = float.Parse(Console.ReadLine());

            float soma1 = A + B;

            float soma2 = C + B;

            float soma3 = A + C;

            if (C < soma1 && A < soma2 && B < soma3)
            {
                if (A == B && B == C)
                {
                    Console.WriteLine("Triângulo é equilátero.");
                }
                else if (A == B || B == C || A == C)
                {
                    Console.WriteLine("Triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("Triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Bro, isso não é um triângulo.");
            }

            Console.ReadKey();
        }
        static void Ex06()
        {
            Console.WriteLine("Quanto você ganha por hora? ");
            float salarioHora = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas você trabalha no mês? ");
            float horasTrabalhadas = float.Parse(Console.ReadLine());

            float salario = salarioHora * horasTrabalhadas;

            float imposto = 0;

            if (salario <= 1_903.98)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= 2_826.65)
            {
                imposto += salario * 0.075f;
                Console.WriteLine($"7,5%, valor de {imposto}");
            }
            else if (salario <= 3_751.05)
            {
                imposto += salario * 0.15f;
                Console.WriteLine($"15%, valor de {imposto}");
            }
            else if (salario <= 3_751.05)
            {
                imposto += salario * 0.225f;
                Console.WriteLine($"22,5%, valor de {imposto}");
            }
            else
            {
                imposto += salario * 0.275f;
                Console.WriteLine($"27,5%, valor de {imposto}");
            }

            Console.ReadKey();
        }
        static void Ex07()
        {
            Console.WriteLine("Qual seu código de operário? ");
            int cod = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas você trabalha ");
            int hrs = int.Parse(Console.ReadLine());

            float excesso = 0;

            float excessoHrs = hrs - 50;

            float salario;

            float imposto = 0;

            if (excessoHrs > 0)
            {
                salario = (hrs - excessoHrs) * 20;
                excesso = excessoHrs * 30;
                salario += excesso;
            }
            else
            {
                salario = hrs * 20;
            }

            Console.WriteLine($"Seu código é {cod} salário foi de {salario}, e o excedente foi de {excesso}");

            if (salario <= 1_903.98)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= 2_826.65)
            {
                imposto += salario * 0.075f;
                Console.WriteLine($"7,5%, valor de {imposto}");
            }
            else if (salario <= 3_751.05)
            {
                imposto += salario * 0.15f;
                Console.WriteLine($"15%, valor de {imposto}");
            }
            else if (salario <= 3_751.05)
            {
                imposto += salario * 0.225f;
                Console.WriteLine($"22,5%, valor de {imposto}");
            }
            else
            {
                imposto += salario * 0.275f;
                Console.WriteLine($"27,5%, valor de {imposto}");
            }

            Console.ReadKey();
        }
        static void Ex08()
        {
            float maior = 0;
            float menor = 0;


            float[] numeros = new float[3];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}: ");
                float n = float.Parse(Console.ReadLine());
                numeros[i] = n;
            }


            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    maior = numeros[i];
                    menor = numeros[i];
                }

                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
                else if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            float multiplicacao = menor * maior;

            float divisao = maior / menor;

            Console.WriteLine($"O valor da multiplicação foi: {multiplicacao} e a da divisão foi: {divisao}");

            Console.ReadKey();
        }
        static void Ex09()
        {
            Console.WriteLine("Digite uma posição entre 0 e 50: ");

            int position;

            while(true)
            {
                try
                {
                    position = int.Parse(Console.ReadLine());
                    
                    if(position < 0 || position > 50)
                    {
                        throw new ArgumentException("Número deve estar entre 0 e 50!");
                    }

                    break;
                } catch(Exception)
                {
                    Console.WriteLine("Digite um número válido!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
               
            }

            int n1 = 1;

            double[] numeros = new double[50];
            
            Console.Clear();

            for(int i = 0; i < 49; i++)
            {
                if(i == 0)
                {
                    numeros[i] = n1;
                    numeros[i+1] = n1;
                } else
                {
                   
                    numeros[i + 1] = numeros[i] + numeros[i - 1];
                }
                
            }

            Console.WriteLine($"{numeros[position - 1]} \n");         

            Console.ReadKey();

        }
    }
}
