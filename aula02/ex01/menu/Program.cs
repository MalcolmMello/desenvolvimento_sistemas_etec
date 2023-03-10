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
                catch (Exception err)
                {
                        Console.WriteLine("Digite um número válido!");
                        Console.ReadKey();
                        Console.Clear();
                    continue;
                }
            }

            Console.Clear();

            switch(option)
            {
                case 1:
                        HelloWorld();
                    break;
                case 2:
                        Soma();
                    break;
                case 3:
                        Info();
                    break;
                case 4:
                        Calculadora();
                    break;
                case 5:
                        Salario();
                    break;
                case 6:
                        Dobro();
                    break;
                case 7:
                        ConversorTemperatura();
                    break;
                case 8:
                        Idade();
                    break;
                case 9:
                        Desconto();
                    break;
                case 10:
                        Area();
                    break;
                case 11:
                        AreaTriangulo();
                    break;
                case 12:
                        Media();
                    break;
                case 13:
                        CompraDesconto();
                    break;
                case 14:
                        IMC();
                    break;
                case 15:
                        Circunferencia();
                    break;
            }

            Console.ReadKey();
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
            Console.WriteLine("|--------------------10---------------------|");
            Console.WriteLine("|--------------------11---------------------|");
            Console.WriteLine("|--------------------12---------------------|");
            Console.WriteLine("|--------------------13---------------------|");
            Console.WriteLine("|--------------------14---------------------|");
            Console.WriteLine("|--------------------15---------------------|");
            Console.WriteLine("|----------- ESCOLHA UM PROGRAMA -----------|");
        }
        static void HelloWorld()
        {
            Console.WriteLine("Alô mundo, o malcolm e o gabriel santos estão programando em C#");
            Console.ReadKey();
        }
        static void Soma()
        {
            Console.WriteLine("Digite o primeiro número");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine($"A soma dos números é: {soma}");

            Console.ReadKey();
        }
        static void Info() 
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
        static void Calculadora()
        {
            Console.WriteLine("Digite o primeiro número");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int number2 = int.Parse(Console.ReadLine());

            int plus = number1 + number2;

            int minus = number1 - number2;

            float division = number1 / number2;

            int multiplication = number1 * number2;

            Console.Clear();

            Console.WriteLine($"A soma dos números é: {plus}");
            Console.WriteLine($"A subtração dos números é: {minus}");
            Console.WriteLine($"A divisão dos números é: {division}");
            Console.WriteLine($"A multiplicação dos números é: {multiplication}");

            Console.ReadKey();
        }
        static void Salario()
        {
            Console.WriteLine("Quanto você ganha por hora? ");
            int ganho_hora = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas você trabalha? ");
            int horas_trabalhadas = int.Parse(Console.ReadLine());

            int salario = ganho_hora * horas_trabalhadas;

            Console.WriteLine($"Seu salário é: {salario}");

            Console.ReadKey();
        }
        static void Dobro()
        {
            Console.WriteLine("Digite o valor: ");
            int valor = int.Parse(Console.ReadLine()) * 2;

            Console.WriteLine($"O dobro do valor é: {valor}");

            Console.ReadKey();
        }
        static void ConversorTemperatura()
        {
            Console.WriteLine("Digite a temperatura em fahrenheit: ");

            int fahrenheit = int.Parse(Console.ReadLine());

            int C = 5 * ((fahrenheit - 32) / 9);

            Console.WriteLine($"O valor em celsius é: {C}");

            Console.ReadKey();
        }
        static void Idade()
        {
            Console.WriteLine("Digite o ano atual: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano que você nasceu: ");
            int bornIn = int.Parse(Console.ReadLine());

            int age = year - bornIn;

            Console.WriteLine($"Você tem {age} anos.");

            Console.ReadKey();
        }
        static void Desconto()
        {
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Digite seu salário mensal: ");
            float sal = float.Parse(Console.ReadLine());

            float desc = sal - (sal * 0.11f);

            Console.WriteLine($"O seu nome é {name} e o seu salário depois do desconto é R${desc}");

            Console.ReadKey();
        }
        static void Area()
        {
            Console.WriteLine("Digite o lado do quadrado: ");
            int l = int.Parse(Console.ReadLine());

            int a = l * l;

            Console.WriteLine($"A Área do quadrado é {a}");

            Console.ReadKey();
        }
        static void AreaTriangulo()
        {
            Console.WriteLine("Digite a altura do Triangulo: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a base do Triangulo: ");
            int b = int.Parse(Console.ReadLine());

            float area = (h * b) / 2;

            Console.WriteLine($"A Área do Triangulo é {area}");

            Console.ReadKey();
        }
        static void Media()
        {
            Console.WriteLine("Digite um número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            int numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            int numero4 = int.Parse(Console.ReadLine());

            int media = (numero1 + numero2 + numero3 + numero4) / 4;

            Console.WriteLine($"A média dos quatro números é {media}.");

            Console.ReadKey();
        }
        static void CompraDesconto()
        {
            Console.WriteLine("Digite o valor da sua compra: ");
            float value = float.Parse(Console.ReadLine());

            float desconto = value - (value * 0.15f);

            Console.WriteLine($"O Valor da sua compra com desconto é R${desconto}.");

            Console.ReadKey();
        }
        static void IMC()
        {
            Console.WriteLine("Digite sua altura em metros: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso em kg: ");
            float peso = float.Parse(Console.ReadLine());

            float imc = peso / (height * height);

            Console.Clear();

            if (height < 10)
            {
                Console.WriteLine($"Seu imc é {imc}.");
            }
            else
            {
                float newH = height / 100;
                imc = peso / (newH * newH);
                Console.WriteLine("Você colocou centímetros, mas o programa é tão bom que corrigiu pra você.");
                Console.WriteLine($"Seu imc é {imc}");
            }

            //1 - tentar trazer o ano atual do sistema ao inves de solicitar para o usuário
            //2 - Desenvolver um tratamento de erro, para caso o usuário informe letras ou deixe o valor vazio para números
            //3 - Tentar juntar todos os projetos em 1, numa espécie de menu onde o usuário seleciona a opção

            Console.ReadKey();
        }
        static void Circunferencia()
        {
            float PI = 3.14f;

            Console.WriteLine("Digite o valor do raio: ");

            float raio = float.Parse(Console.ReadLine());

            float circunferencia = 2 * PI * raio;

            float area_circ = PI * raio * raio;

            Console.WriteLine($"A área é: {area_circ}");

            Console.WriteLine($"A circunferência é: {circunferencia}");

            Console.ReadKey();
        }
    }
}
