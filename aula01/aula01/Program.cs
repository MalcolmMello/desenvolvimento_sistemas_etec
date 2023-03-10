using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Current date
            DateTime now = DateTime.Now;

            // Set up calendar
            Calendar calendar = CultureInfo.InvariantCulture.Calendar;

            // Set current year
            int year = calendar.GetYear(now);

            // User's name input
            Console.WriteLine("Seu nome é: ");
            string name = Console.ReadLine();
            
            // User's age input
            Console.WriteLine("Sua idade é: ");
            int ageInput = int.Parse(Console.ReadLine());

            // User's salary
            Console.WriteLine("Seu salário é: ");
            double salary = double.Parse(Console.ReadLine());

            salary += salary * 0.15;

            // User's born year
            int born_year = year - ageInput;

            // Verify if user is an adult or not
            if (ageInput >= 18) {
                Console.WriteLine($"Seu nome é {name} e você é de maior, {ageInput} anos, e você nasceu no ano de {born_year}, seu novo salário é {salary}");
            }
            else {
                Console.WriteLine($"Seu nome é {name} e você é de menor, {ageInput} anos, e você nasceu no ano de {born_year}, seu novo salário é {salary}");
            }
            
            // Finish program after user final click
            Console.ReadKey();
        }
    }
}
