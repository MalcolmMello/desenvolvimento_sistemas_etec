using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace hablitacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int periodo;

            Console.WriteLine("Qual a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 50)
            {
                periodo = 10;
            }
            else if (idade < 70)
            {
                periodo = 5;
            } else
            {
                periodo = 3;
            }

            Console.WriteLine("Informe o ano de expedição: ");
            int ano = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            int resultado = anoAtual - ano;

            Console.Clear();

            if (resultado > periodo)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Carteira vencida, precisa de renovação.");
            } else if (resultado == periodo )
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("A carteira está no ano de renovação.");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Carteira está na validade, não precisa de renovação.");
            }

            Console.ReadKey();
        }
    }
}
