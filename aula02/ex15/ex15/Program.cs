using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float PI = 3.14f;

            Console.WriteLine("Digite o valor do raio: ");

            float raio = float.Parse(Console.ReadLine());

            float circunferencia = 2 * PI * raio;

            float area = PI* raio*raio;

            Console.WriteLine($"A área é: {area}");

            Console.WriteLine($"A circunferência é: {circunferencia}");

            Console.ReadKey();

        }
    }
}
