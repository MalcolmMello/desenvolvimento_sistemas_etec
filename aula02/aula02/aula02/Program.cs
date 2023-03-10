using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga quanto choveu na segunda-feira: ");
            int segunda = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga quanto choveu na terça-feira: ");
            int terca = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga quanto choveu na quarta-feira: ");
            int quarta = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga quanto choveu na quinta-feira: ");
            int quinta = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga quanto choveu na sexta-feira: ");
            int sexta = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga quanto choveu na sábado: ");
            int sabado = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga quanto choveu na domingo: ");
            int domingo = int.Parse(Console.ReadLine());

            int media = (segunda + terca + quarta + quinta + sexta + sabado + domingo) / 7;

            Console.Clear();
            Console.WriteLine($"A média é essa ai vacilão:  {media}mm");

            Console.ReadKey();
        }
    }
}
