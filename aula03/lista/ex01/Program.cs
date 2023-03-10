using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peso = 0;
            int exc = 0;
            int multa = 0;

            Console.WriteLine("Digite o peso dos peixes pescado em kg: ");
            peso = int.Parse(Console.ReadLine());
            Console.Clear();
            if(peso > 50)
            {
                exc = peso - 50;
                multa = exc * 8;

                Console.WriteLine($"A multa foi de R${multa}.");
            }
            else
            {
                multa = 0;
                Console.WriteLine($"Você pagará R${multa} de multa.")
            }
            Console.ReadKey();
        }
    }
}
