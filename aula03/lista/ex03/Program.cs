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
    }
}
