using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Qual a cor do fundo desejado? ");
            Console.WriteLine("1- Branco \n 3- Amarelo \n 5- Azul");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
            }

            Console.ReadKey();
        }
    }
}
