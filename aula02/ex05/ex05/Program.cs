using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanto você ganha por hora? ");
            int ganho_hora = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas você trabalha? ");
            int horas_trabalhadas = int.Parse(Console.ReadLine());

            int salario = ganho_hora * horas_trabalhadas;

            Console.WriteLine($"Seu salário é: {salario}");

            Console.ReadKey();
        }
    }
}
