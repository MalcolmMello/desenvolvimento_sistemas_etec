using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanto você ganha por hora? ");
            float salarioHora = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas você trabalha no mês? ");
            float horasTrabalhadas = float.Parse(Console.ReadLine());

            float salario = salarioHora * horasTrabalhadas;

            float imposto = 0;

            if(salario <= 1_903.98)
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
