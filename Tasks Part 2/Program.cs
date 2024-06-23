using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateTheFunction();
        }

        static void CalculateTheFunction()
        {
            double a;

            while (true)
            {
                Console.WriteLine("Enter the value of 'a' in function x = 12a^2 + 7a + 12 :");
                string input = Console.ReadLine();

                if(double.TryParse(input, out a))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid value. Please enter a valid value.");
                }
            }
            double x = 12 * a * a + 7 * a + 12;
            Console.WriteLine($"For a = {a}, x = {x}");
        }
    }
}
