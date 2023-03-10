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
            Console.WriteLine("Digite o lado A do triângulo: ");
            float A = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado B do triângulo: ");
            float B = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado C do triângulo: ");
            float C = float.Parse(Console.ReadLine());

            float soma1 = A + B;
            
            float soma2 = C + B;

            float soma3 = A + C;

            if (C < soma1 && A < soma2 && B < soma3)
            {
                if (A==B && B==C)
                {
                    Console.WriteLine("Triângulo é equilátero.");
                } else if(A == B || B == C || A == C)
                {
                    Console.WriteLine("Triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("Triângulo é escaleno.");
                }
            } else
            {
                Console.WriteLine("Bro, isso não é um triângulo.");
            }

            Console.ReadKey();

        }
    }
}
