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
    }
}
